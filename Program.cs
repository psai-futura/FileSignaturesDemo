using System.Reflection;
using FileSignatures;
using FileSignaturesDemo;
using FileSignaturesDemo.CustomFileFormats;

// var assembly = typeof(Dwg).GetTypeInfo().Assembly;
var formats = FileFormatLocator.GetFormats(Assembly.GetExecutingAssembly(), true);
var inspector = new FileFormatInspector(formats);

const string path = @"C:\Users\p.sai\Documents\FileSignatureTest";
var files = Directory.GetFiles(path);
   
foreach (var file in files) {
    Console.WriteLine(file);
    var fileInfo = new FileInfo(file);

    var magic = GetMagicNumbers(file, 4);

    using var stream = fileInfo.OpenRead();
    var format = inspector.DetermineFileFormat(stream);

    if (format == null) 
        Console.WriteLine("File format was not recognised.");
    else
    {
        Console.WriteLine("Media Type : " + format.MediaType);
        Console.WriteLine("Signature  : " + BitConverter.ToString(format.Signature.ToArray()));
        Console.WriteLine("Extension  : " + format.Extension);
    }
}

string GetMagicNumbers(string filepath, int bytesCount)
{
    byte[] buffer;
    using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
    using (var reader = new BinaryReader(fs))
        buffer = reader.ReadBytes(bytesCount);

    var hex = BitConverter.ToString(buffer);
    return hex.Replace("-", String.Empty).ToLower();
}