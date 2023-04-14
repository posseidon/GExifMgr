namespace GExifMgr
{
    public class ExifReaderFactory
    {
        private static readonly Dictionary<ReaderType, IExifReader> ExifReaders = new()
        {
            { ReaderType.MetadataExtractor, new MetadataExifReader() },
            { ReaderType.ExifLib, new ExifLib() }
        };

        public static IExifReader GetReader(ReaderType Type)
        {
            return ExifReaders[Type];
        }
    }
}
