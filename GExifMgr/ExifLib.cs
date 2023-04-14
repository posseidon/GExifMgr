using ExifLibrary;

namespace GExifMgr
{
    /// <summary>
    /// Exif Reader using Exif Library
    /// <see>https://oozcitak.github.io/exiflibrary/</see>
    /// <seealso cref="https://nugetmusthaves.com/Package/ExifLibNet"/>
    /// </summary>
    class ExifLib : IExifReader
    {
        public List<string> Read(string FilePath)
        {
            List<string> tags = new();
            ImageFile file = ImageFile.FromFile(FilePath);
            foreach (ExifProperty item in file.Properties)
            {
                //tags.Add(item.ToString());
                //tags.Add(Enum.GetName(typeof(IFD), ExifTagFactory.GetTagIFD(item.Tag)));
                tags.Add(ExifTagFactory.GetTagName(item.Tag));
            }

            return tags;
        }

        public ReaderType Type()
        {
            return ReaderType.ExifLib;
        }
    }
}
