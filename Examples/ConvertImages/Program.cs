using ImageMagick;

public class Program
{
  public static void Main(string[] args)
  {
    var webpFullFileNameList = System.IO.Directory.EnumerateFiles(Environment.CurrentDirectory, "*.jpg").ToList();

    if (webpFullFileNameList.Count == 0)
    {
      Console.WriteLine("Nessun file webp trovato nella cartella corrente");
      return;
    }

    Console.Write($"Trovati {webpFullFileNameList.Count} file nella cartella corrente, convertirli in png? (y/N): ");
    if (Console.ReadLine() != "y")
    {
      Console.WriteLine("Operazione annullata");
      return;
    }

    for (var i = 0; i < webpFullFileNameList.Count; i++)
    {
      var inputFullFileName = webpFullFileNameList[i];
      Console.Write($"[{i + 1}/{webpFullFileNameList.Count}] Conversione di '{inputFullFileName}'");

      var dstPath = System.IO.Path.GetDirectoryName(inputFullFileName);
      var dstFileNameNoExt = System.IO.Path.GetFileNameWithoutExtension(inputFullFileName);
      var outputFullFileName = dstPath + @"\" + dstFileNameNoExt + ".png";
      if (System.IO.File.Exists(outputFullFileName))
      {
        Console.WriteLine(" - [Errore] - File saltato perché il png esiste già");
      }
      else
      {
        using var image = new MagickImage(inputFullFileName);
        image.Write(outputFullFileName);
        Console.WriteLine(" - [Ok] - File convertito in png");
      }
    }
  }
}

