using FileSignatures;

namespace FileSignaturesDemo.CustomFileFormats;

public abstract class Dwg : FileFormat
{
    protected Dwg(byte[] signature, string mediaType, string extension) : base(signature, mediaType, extension)
    {
    }

    protected Dwg(byte[] signature, string mediaType, string extension, int offset) : base(signature, mediaType, extension, offset)
    {
    }
}

public class DwgR25 : Dwg
{
    public DwgR25() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x32 }, "application/acad", "dwg")
    { }
}

public class DwgR26 : Dwg
{
    public DwgR26() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x33 }, "application/acad", "dwg")
    { }
}

public class DwgR9 : Dwg
{
    public DwgR9() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x34 }, "application/acad", "dwg")
    { }
}

public class DwgR10 : Dwg
{
    public DwgR10() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x36 }, "application/acad", "dwg")
    { }
}

public class DwgR11_12 : Dwg
{
    public DwgR11_12() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x39 }, "application/acad", "dwg")
    { }
}

public class DwgR13_10 : Dwg
{
    public DwgR13_10() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x30 }, "application/acad", "dwg")
    { }
}

public class DwgR13_11 : Dwg
{
    public DwgR13_11() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x31 }, "application/acad", "dwg")
    { }
}

public class DwgR13_12 : Dwg
{
    public DwgR13_12() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x32 }, "application/acad", "dwg")
    { }
}

public class DwgR13_13 : Dwg
{
    public DwgR13_13() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x33 }, "application/acad", "dwg")
    { }
}

public class DwgR13_14 : Dwg
{
    public DwgR13_14() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x34 }, "application/acad", "dwg")
    { }
}

public class DwgR2000 : Dwg
{
    public DwgR2000() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x35 }, "application/acad", "dwg")
    { }
}

public class DwgR2004 : Dwg
{
    public DwgR2004() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x38 }, "application/acad", "dwg")
    { }
}

public class DwgR2007 : Dwg
{
    public DwgR2007() : base(new byte[] { 0x41, 0x43, 0x31, 0x30, 0x32, 0x31 }, "application/acad", "dwg")
    { }
}
