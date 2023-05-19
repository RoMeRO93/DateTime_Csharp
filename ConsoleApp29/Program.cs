using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplu de instanțiere a unei date și afișare
        var date1 = new DateTime(2008, 3, 1, 7, 0, 0, DateTimeKind.Utc);
        Console.WriteLine("Exemplu de afisare a unei date: " + date1.ToString("yyyy-MM-ddTHH:mm:sszzz", System.Globalization.CultureInfo.InvariantCulture));

        // Afișare data și ora curentă
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Data si ora curenta: " + currentDate.ToString("yyyy-MM-dd HH:mm:ss"));

        // Manipulare dată și timp
        DateTime modifiedDate = currentDate.AddDays(7); // Adăugăm 7 zile
        Console.WriteLine("Data modificata (adaugam 7 zile): " + modifiedDate.ToString("yyyy-MM-dd HH:mm:ss"));

        // Calculul diferenței dintre două date
        TimeSpan difference = modifiedDate - currentDate;
        Console.WriteLine("Diferenta dintre cele doua date: " + difference.TotalDays + " zile");

        // Conversie între fusuri orare
        DateTime localTime = modifiedDate.ToLocalTime();
        Console.WriteLine("Data in fusul orar local: " + localTime.ToString("yyyy-MM-dd HH:mm:ss"));

        DateTime utcTime = modifiedDate.ToUniversalTime();
        Console.WriteLine("Data în fusul orar UTC: " + utcTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Verificarea dacă anul curent este bisect
        int currentYear = DateTime.Now.Year;
        bool isLeapYear = DateTime.IsLeapYear(currentYear);
        Console.WriteLine("Anul curent este bisect? " + (isLeapYear ? "Da" : "Nu"));
    }
}
