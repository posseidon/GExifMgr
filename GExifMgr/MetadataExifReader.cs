using MetadataExtractor;

namespace GExifMgr
{
    /// <summary>
    /// Exif reader using Metadata Extractor.
    /// <see>https://github.com/drewnoakes/metadata-extractor-dotnet</see>
    /// <seealso cref="https://nugetmusthaves.com/Package/MetadataExtractor"/>
    /// </summary>
    class MetadataExifReader : IExifReader
    {
        public List<string> Read(string FilePath)
        {
            var directories = ImageMetadataReader.ReadMetadata(FilePath);
            List<String> tags = new();
            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    tags.Add(tag.ToString());
                }
            }
            return tags;
        }

        public ReaderType Type()
        {
            return ReaderType.MetadataExtractor;
        }
    }
}