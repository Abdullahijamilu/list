using list;

//Grade grade = new Grade();



List<Student> Student = new List<Student>
{
    new Student
    {
        FullName = "Abdul",
        Id = 1
    },
    new Student
    {
        FullName = "mohammed",
        Id=2
    },
};

List<StudentRecord> StudentRecord = new List<StudentRecord>
{
    new StudentRecord
    {
        StudentId= 1,
        EnglishScore = 30,
        MathsScore = 50
    },
    new StudentRecord
    {
        StudentId= 2,
        EnglishScore = 70,
        MathsScore = 50
    }
};

var studentRecordWithGrade = StudentRecord.Select(x => new RecordWithGrade
{
    EnglishScore = x.EnglishScore,
    MathsScore = x.MathsScore,
    StudentId = x.StudentId,
    EnglishGrade = Grade.CalculateGrade(x.EnglishScore),
    MathsGrade = Grade.CalculateGrade(x.MathsScore)
}).ToList();

for (int i = 0; i < studentRecordWithGrade.Count; i++)
{
    RecordWithGrade? student = studentRecordWithGrade[i];
    Console.WriteLine(studentRecordWithGrade);
}

public class RecordWithGrade
{
    public int StudentId { get; set; }
    public int EnglishScore { get; set; }
    public int MathsScore { get; set; }
    public char EnglishGrade {  get; set; }
    public char MathsGrade { get; set; }
    
}


public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

public class StudentRecord
{
    public int StudentId { get; set; }
    public int EnglishScore { get; set; }
    public int MathsScore { get; set; }

}

