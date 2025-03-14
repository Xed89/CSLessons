using ImageMagick;

public class Program
{
  public static void Main(string[] args)
  {
    foreach (var fullFileName in System.IO.Directory.EnumerateFiles(@"C:\temp\immagini\"))
    {
      if (System.IO.Path.GetExtension(fullFileName) == ".webp")
      {
        ConvertFileToPng(fullFileName);
      }
    }
  }

  public static void ConvertFileToPng(string inputFullFileName)
  {
    // Read first frame of gif image
    using var image = new MagickImage(inputFullFileName);

    // Save frame as jpg
    var dstPath = System.IO.Path.GetDirectoryName(inputFullFileName);
    var dstFileNameNoExt = System.IO.Path.GetFileNameWithoutExtension(inputFullFileName);
    image.Write(dstPath + @"\" + dstFileNameNoExt + ".png");
  }
}

