using GExifMgr;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMetadataExtractor()
        {
            IExifReader reader = ExifReaderFactory.GetReader(ReaderType.MetadataExtractor);
            List<string> tags = reader.Read("Resources/Landsat_ETM_2001-08-26_multispectral.tif");
            Assert.IsNotEmpty(tags);
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }

        [Test]
        public void TestExifLib()
        {
            IExifReader reader = ExifReaderFactory.GetReader(ReaderType.ExifLib);
            List<string> tags = reader.Read("Resources/Landsat_ETM_2001-08-26_multispectral.tif");
            Assert.IsNotEmpty(tags);
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}