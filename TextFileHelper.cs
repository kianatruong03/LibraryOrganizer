using System.IO;

public static class TextFileHelper
{
    //textfile reads the textfile and data of the book
    public static string ReadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        return string.Empty;
    }

    //textfile writes any changes like edit or add
    public static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
}

