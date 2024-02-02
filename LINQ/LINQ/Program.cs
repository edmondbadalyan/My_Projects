using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Text.Json;
public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
    public int Group { get; set; }
    public int Grade { get; set; }


    public Student() { }
    public Student(string name, string surname, string city, int group, int grade)
    {
        Name = name;
        Surname = surname;
        City = city;
        Group = group;
        Grade = grade;
    }

    public override string ToString() => $"{Name} {Surname} {City} {Group} {Grade}";
}

class Program
{
    static void Main()
    {
        List<Student> list = new List<Student>
        {
            new ("Edmond", "Badalyan", "Moscow", 1, 5),
            new ("John", "Doe", "Praga", 2, 4),
            new ("Alice", "Smith", "Tokyo", 3, 3),
            new ("Vinni", "Bad", "France", 1, 5)
        }; 


        
        Console.WriteLine("1.Распечатайте информацию обо всех студентах");
        foreach (Student student in list)
        {
            Console.WriteLine($" Name: {student.Name} ,Surname: {student.Surname} ,City: {student.City} ,Group: {student.Group} ,Grade: {student.Grade} ");
        }

        Console.WriteLine();

        Console.WriteLine("2.Распечатайте информацию о студентах из определённого города. Отсортируйте по фамилии, во вторую очередь по имени");
        var ourStudents = list
            .Where(student => student.City == "Moscow")
            .OrderBy(student => student.Surname)
            .ThenBy(student => student.Name);


        foreach (Student student in ourStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, City: {student.City}");
        }

        Console.WriteLine();
        Console.WriteLine("3.Распечатайте только имена студентов, отсортированные по алфавиту.");
        IEnumerable<string> studentNames = list
            .OrderBy(student => student.Name)
            .Select(student => student.Name)
            .ToList();
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        Console.WriteLine("Распечатайте топ-3 студентов по успеваемости.");

        var topStudents = list
            .Where(student => student.Grade > 3)
            .OrderBy(student => student.Name)
            .ToList();
        foreach (Student student in topStudents)
        {
            Console.WriteLine();
                
        }
             



        


    }
}

