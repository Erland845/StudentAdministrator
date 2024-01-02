using System;

public class Karakter
{
    public static List<int> Allgrades {  get; } = new List<int>();
    public Student Student { get; set; }
    public Fag Fag { get; set; }
    public List<int> Grades { get; set; }
    public Karakter (Student student, Fag fag, int grade)
    {
        Student = student;
        Fag = fag;
        Grades = new List<int> { grade };
        Allgrades.Add(grade);
    }
    public void AddGrade(int grade)
    {
        Grades.Add(grade);
        Allgrades.Add(grade);   
    }
    public double AverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        double sum = Grades.Sum();
        return sum / Grades.Count;
    }
    public static double AllGradesAverage()
    {
        if (Allgrades.Count == 0) 
        {
            return 0; 
        }
        double sum = Allgrades.Sum();
        return sum / Allgrades.Count;
    }
    public void PrintKarakter()
    {
        Console.WriteLine($"Student: {Student.Name}, {Student.Age}, {Student.Studieprogram}");
        Console.WriteLine($"Fag: {Fag.Fagnavn}, {Fag.Fagkode}, {Fag.Studiepoeng}");
        Console.WriteLine($"Grades: {string.Join(",", Grades)}");
        Console.WriteLine($"Average Grade: {AverageGrade()}");
    }
}
