using FileSignatures;
using FileSignatures.Formats;

namespace FileSignaturesDemo.CustomFileFormats;

public class Rar : FileFormat
{
    public Rar() : base(new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, "application/vnd.rar", "rar")
    { }
}