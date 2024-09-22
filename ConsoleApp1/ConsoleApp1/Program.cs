using System;

public class Student
{
    public string FullName { get; set; }
    public string Group { get; set; }
    public double AvgGrade { get; set; }

    public Student(string fullName, string group, double averageGrade)
    {
        FullName = fullName;
        Group = group;
        AvgGrade = averageGrade;
    }

    public virtual double CalculateScholarship()
    {
        if (AvgGrade == 5)
        {
            return 2000;
        }
        else
        {
            return 1900;
        }
    }
}

public class Aspirant : Student
{
    public string ResearchWork { get; set; }

    public Aspirant(string fullName, string group, double averageGrade, string researchWork)
        : base(fullName, group, averageGrade)
    {
        ResearchWork = researchWork;
    }

    public override double CalculateScholarship()
    {
        if (AvgGrade == 5)
        {
            return 2500;
        }
        else
        {
            return 2200;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Иванов Иван Иванович", "Группа 1", 4.5);
        Console.WriteLine($"Стипендия студента {student.FullName}: {student.CalculateScholarship()} руб.");

        Aspirant aspirant = new Aspirant("Петров Петр Петрович", "Группа 2", 5, "Научное исследование по программированию");
        Console.WriteLine($"Стипендия аспиранта {aspirant.FullName}: {aspirant.CalculateScholarship()} руб.");

        Console.ReadKey();
    }
}
