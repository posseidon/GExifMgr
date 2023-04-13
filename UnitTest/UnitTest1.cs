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
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\Drone_Images\\DSC00153.JPG");
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\Gregg1_2\\DJI_0001.JPG");
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\DroneMapper_Golf9\\Ortho-DroneMapper.tif");
            List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\DroneMapper_Golf9\\DEM32-DroneMapper.tif");
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
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\Drone_Images\\DSC00153.JPG");
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\Gregg1_2\\DJI_0001.JPG");
            // List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\DroneMapper_Golf9\\Ortho-DroneMapper.tif");
            List<string> tags = reader.Read("c:\\Users\\ngtha\\Downloads\\DroneMapper_Golf9\\DEM32-DroneMapper.tif");
            Assert.IsNotEmpty(tags);
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}