// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");
//Write a code that will calculate students assign grades to
//students and then return a record with the complete  data
List<string> Student = new List<string> { "Godwin", "Grace", "Amos",};
List<string> Studentrecord = new List<string> { "Maths", "English", "chemistry" };
String[,] StudentGrades =
{{ "Godwin[maths 50] [English, 70] [chemistry, 20]" },
    { "Grace[maths 50] [English, 70] [chemistry, 20]"},
    { "Amos[maths 50] [English, 70] [chemistry, 20]" }
};


for (int i = 0; i < StudentGrades.GetHashCode(); i++)
{
    for (int j = 0; j < StudentGrades.GetHashCode(); j++)
    {
        Console.Write(StudentGrades[i, j] + " ");
    }
    Console.WriteLine();
}
    

    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string FullName { get; set; }
         



    //}

    //public class StudentRecord
    //{
    //    public int StudentId { get; set; }
    //    public int EnglishScore { get; set; }
    //    public int MathsScore { get; set; }

    //}

