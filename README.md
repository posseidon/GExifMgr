# Exif Manager

Using Metadata Extractor
```csharp
IExifReader reader = ExifReaderFactory.GetReader(ReaderType.MetadataExtractor);
List<string> tags = reader.Read("absolute/path/to/your/file")
```

Using Exif Libarary NET
```csharp
IExifReader reader = ExifReaderFactory.GetReader(ReaderType.ExifLib);
List<string> tags = reader.Read("absolute/path/to/your/file")
```
