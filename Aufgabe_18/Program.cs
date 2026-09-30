namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            
            DateTime today = DateTime.Today;
            DateTime input;
            do
            {
                invalid = false;
                Console.Write("Gib ein Geburtsdatum ein: ");
                Console.Write("");
                if (DateTime.TryParse(Console.ReadLine(), out input))
                {
                    
                }
                else
                {
                    Console.WriteLine("ungültige eingabe, es muss ein Datum sein -> versuchen sie es erneut");
                    Console.Write("");
                    invalid = true;
                    continue;
                }
            } while (invalid);

            TimeSpan interval = today - input;
            Console.WriteLine("Alter in Jahren: " + (interval.Days)/365);
            Console.WriteLine("Alter in Monaten: " + (interval.Days * 12 / 365));
            Console.WriteLine("Alter in Wochen: " + (interval.Days)/7);
            Console.WriteLine("Alter in Tagen: " + (interval.Days));

        }
    }
}
