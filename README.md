# Exif Manager

Using Metadata Extractor
```
IExifReader reader = ExifReaderFactory.GetReader(ReaderType.MetadataExtractor);
List<string> tags = reader.Read("absolute/path/to/your/file")
```

Using Exif Libarary NET
```
IExifReader reader = ExifReaderFactory.GetReader(ReaderType.ExifLib);
List<string> tags = reader.Read("absolute/path/to/your/file")
```
