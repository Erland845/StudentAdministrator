using System;

public class Fag
{
	public string Fagnavn {  get; set; }
	public int Fagkode { get; set; }
	public int Studiepoeng { get; set; }
	public Fag(string fagnavn, int fagkode, int studiepoeng) 
	{
		Fagnavn = fagnavn;
		Fagkode = fagkode;
		Studiepoeng = studiepoeng;
	}
	public void PrintFag()
	{
		Console.WriteLine($"Fagnavn: {Fagnavn}, Fagkode:{Fagkode}, Studiepoeng: {Studiepoeng}");
	}
}
