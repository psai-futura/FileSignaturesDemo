using FileSignatures;

namespace FileSignaturesDemo.CustomFileFormats;

public class Plt : FileFormat
{
    public Plt() : base(new byte[] { 0x20, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, "application/vnd.rar", "rar")
    { }
}