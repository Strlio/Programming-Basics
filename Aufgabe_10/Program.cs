namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            int eingabe;
            do
            {
                invalid = false;
                Console.WriteLine("von welcher zahl möchtest du die quersumme berechen? ");
                if (int.TryParse(Console.ReadLine(), out eingabe))
                {
                    Console.WriteLine("Quersumme wird berechnet...");
                    int ergebnis = BerechneQuersumme(eingabe);
                    Console.WriteLine("Die quersumme ist: " + ergebnis);
                }
                else
                {
                    Console.WriteLine("Ungültige eingabe, es muss eine zahl sein, versuchen sie es erneut.");
                    invalid = true;
                    continue;
                }
            } while (invalid);        }

        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while(zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl /= 10;
            }
            return sum;
        }
    }
}
