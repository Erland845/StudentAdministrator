namespace StudentAdministrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student Jonas = new Student("Jonas", 26, "Matte");
            Student Selmer = new Student("Selmer", 29, "Filosofi");
            Student Josefine = new Student("Josefine", 32, "Medisin");
            Student Kaja = new Student("Kaja", 25, "Farmasi");
            Fag Matte = new Fag("Matte", 101, 10);
            Fag Filosofi = new Fag ("Filosfi", 111, 15);
            Fag Medisin = new Fag ("Medisin", 110, 20);
            Fag Farmasi = new Fag("Farmasi", 122, 10);
            Karakter Mathgrade = new Karakter(Jonas, Matte, 5);
            Karakter Filosofigrade = new Karakter(Selmer, Filosofi, 6);
            Karakter Medisingrade = new Karakter(Josefine, Medisin, 4);
            Karakter Farmasigrade = new Karakter (Kaja, Medisin, 4);
            Mathgrade.PrintKarakter();
            Console.WriteLine();
            Filosofigrade.PrintKarakter();
            Console.WriteLine();
            Medisingrade.PrintKarakter();
            Console.WriteLine();
            Farmasigrade.PrintKarakter();
            Console.WriteLine();
            double overallAverage = Karakter.AllGradesAverage();
            Console.WriteLine($"Overall Average Grade: {overallAverage}");
        }
    }
}