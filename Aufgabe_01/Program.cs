namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            int Seconds;
            do
            {
                invalid = false;
                Console.Write("Anzahl tage des Monats: ");
                if (int.TryParse(Console.ReadLine(), out int NumberOfDays))
                {
                    if(NumberOfDays is >= 28 and <= 31)
                    {
                        Seconds = ((NumberOfDays * 24) * 60) * 60;
                        Console.WriteLine(Seconds);
                    }
                    else
                    {
                        Console.WriteLine("Es gibt einen monat mit " + NumberOfDays + " Tagen");
                        invalid = true;
                        continue;
                    }
                    
                }
                else
                {
                    invalid = true;
                    Console.WriteLine("Ungültige Eingabe, Versuchen sie es erneut.");
                    continue;
                }
            } while (invalid);
        }
    }
}
