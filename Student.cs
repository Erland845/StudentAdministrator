using System;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
	public string Studieprogram { get; set; }
	public Student(string name, int age, string studieprogram) 
	{
		Name = name;
		Age = age;
		Studieprogram = studieprogram;
	}
	public void PrintStudent()
	{
		Console.WriteLine($"Name:{Name}, Age: {Age}, Studieprogram:{Studieprogram}");
	}
	

}
