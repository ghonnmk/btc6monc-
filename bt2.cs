using System;
using System.Collections.Generic;
using System.IO;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
}

public class CsvManager
{
    public static List<Student> ReadStudentsFromCsv(string filePath)
    {
        var students = new List<Student>();

        using (var reader = new StreamReader(filePath))
        {
            // Bỏ qua tiêu đề
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var student = new Student
                {
                    Id = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Grade = double.Parse(values[3])
                };

                students.Add(student);
            }
        }

        return students;
    }

    public static void WriteStudentsToCsv(string filePath, List<Student> students)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Id,Name,Age,Grade");

            foreach (var student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Grade}");
            }
        }
    }
}

public class bt2
{
    public static void Main(string[] args)
    {
        var students = CsvManager.ReadStudentsFromCsv("students.csv");

        // Thao tác với danh sách students ở đây

        CsvManager.WriteStudentsToCsv("students_output.csv", students);
    }
}