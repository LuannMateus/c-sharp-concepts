using System.IO;

namespace fileManipulation.src
{
  public class FileManager
  {
    public void ListAllDirectories(string path)
    {
      var directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

      foreach (var directory in directories)
      {
        System.Console.WriteLine(directory);
      }
    }

    public void ListAllFiles(string path)
    {
      var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

      foreach (var file in files)
      {
        System.Console.WriteLine(file);
      }
    }

    public void MakeDirectories(string path)
    {
      var fullPath = Directory.CreateDirectory(path);
      System.Console.WriteLine(fullPath);
    }

    public void RemoveDirectories(string path, bool deleteFiles)
    {
      Directory.Delete(path, deleteFiles);
    }

    public void CreateFile(string path, string content)
    {
      if (!(File.Exists(path)))
      {
        File.WriteAllText(path, content);
      }
    }

    public void CreateStreamFile(string path, List<string> content)
    {
      using (var stream = File.CreateText(path))
      {
        foreach (var line in content)
        {
          stream.WriteLine(line);
        }
      }
    }

    public void AddText(string path, string content)
    {
      File.AppendAllText(path, content);
    }

    public void AddStreamText(string path, List<string> content)
    {
      using (var stream = File.AppendText(path))
      {
        foreach (var line in content)
        {
          stream.WriteLine(line);
        }
      }
    }

    public void ReadFile(string path)
    {
      var content = File.ReadAllLines(path);

      foreach (var line in content)
      {
        System.Console.WriteLine(line);
      }
    }

    public void ReadStreamFile(string path)
    {
      string? line = string.Empty;

      using (var stream = File.OpenText(path))
      {
        line = stream.ReadLine();

        while (line != null)
        {
          System.Console.WriteLine(line);
          line = stream.ReadLine();
        }
      }
    }

    public void MoveFile(string oldPath, string newPath, bool substition)
    {
      File.Move(oldPath, newPath, substition);
    }

    public void CopyFile(string oldPath, string newPath, bool substition)
    {
      File.Copy(oldPath, newPath, substition);
    }

    public void DeleteFile(string path)
    {
      File.Delete(path);
    }
  }
}