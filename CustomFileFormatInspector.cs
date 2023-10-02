using System.Reflection;
using FileSignatures;

namespace FileSignaturesDemo;

public class CustomFileFormatInspector : FileFormatInspector
{
    private readonly IEnumerable<FileFormat> _formats;

    public CustomFileFormatInspector() : base()
    {
        _formats = FileFormatLocator.GetFormats(Assembly.GetExecutingAssembly(), true);
    }

    public FileFormat GetFileFormat(Stream stream, string extension)
    {
        var formats = _formats.Where(x => string.Equals(x.Extension, extension, StringComparison.InvariantCultureIgnoreCase));

        foreach (var format in formats)
        {
            var isMatch = format.IsMatch(stream);

            if (isMatch)
                return format;
        }

        return null;
    } 
}