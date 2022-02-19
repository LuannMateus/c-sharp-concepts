using fileManipulation.src;

namespace fileManipulation
{
  public class Program
  {
    public static void Main(string[] args)
    {
      FileManager fileManager = new FileManager();
      string path = ".", directoryOne = "dirOne", subDirectoryOne = "subDirOne";

      fileManager.ListAllDirectories(".");
      fileManager.ListAllFiles(".");

      // * Create a directory
      fileManager.MakeDirectories(Path.Combine(path, directoryOne, subDirectoryOne));

      // * Remove a directory or directories
      fileManager.RemoveDirectories(Path.Combine(path, directoryOne), true);

      // * Create a file 
      fileManager.CreateFile(Path.Combine(path, "file.txt"), "LINE ONE");

      // * Create a file with Stream 
      List<string> text = new List<string>() { "Line one", "Line two" };
      fileManager.CreateStreamFile(Path.Combine(path, "streamFile.txt"), text);

      // * Add a text in an existing file
      fileManager.AddText(Path.Combine(path, "file.txt"), "\nNew line");

      // * Add a text in an existing file with stream
      List<string> text2 = new List<string>() { "New line one", "New line two" };
      fileManager.AddStreamText(Path.Combine(path, "streamFile.txt"), text2);

      // * Read a single file
      fileManager.ReadFile(Path.Combine(path, "file.txt"));

      // * Read a single file with stream
      fileManager.ReadStreamFile(Path.Combine(path, "streamFile.txt"));

      // * Move a file
      // string oldPath = Path.Combine(path, "file.txt");
      // string newPath = Path.Combine(path, "src", "fileMoved.txt");

      // fileManager.MoveFile(oldPath, newPath, false);

      // * Copy a file
      // string oldPathToCopy = Path.Combine(path, "streamFile.txt");
      // string newPathToPast = Path.Combine(path, "src", "streamFileCopied.txt");

      // fileManager.CopyFile(oldPathToCopy, newPathToPast, false);

      // * Delete a file
      fileManager.DeleteFile(Path.Combine(path, "src", "fileMoved.txt"));

    }
  }
}