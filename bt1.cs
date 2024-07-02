using System;
using System.IO;

class bt1
{
    static readonly string FilePath = "data.txt";

    static void CreateFile(string filePath)
    {
        File.Create(filePath).Close();
        Console.WriteLine($"File created at: {filePath}");
    }

    static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine($"Content written to: {filePath}");
    }

    static void ReadFromFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"Content read from: {filePath}");
        Console.WriteLine(content);
    }

    static void AppendToFile(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
        Console.WriteLine($"Content appended to: {filePath}");
    }

    static void DeleteFile(string filePath)
    {
        File.Delete(filePath);
        Console.WriteLine($"File deleted: {filePath}");
    }

    static void Main(string[] args)
    {
        CreateFile(FilePath);
        WriteToFile(FilePath, "This is the initial content.");
        ReadFromFile(FilePath);

        AppendToFile(FilePath, "\nThis is the appended content.");
        ReadFromFile(FilePath);

        DeleteFile(FilePath);
    }
}