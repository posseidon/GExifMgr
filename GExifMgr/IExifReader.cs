namespace GExifMgr
{
    public enum ReaderType
    {
        MetadataExtractor,
        ExifLib
    }

    public interface IExifReader
    {
        List<string> Read(string FilePath);

        ReaderType Type();
    }
}
