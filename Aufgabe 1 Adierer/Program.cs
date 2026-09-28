namespace Aufgabe_1_Adierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double zahl1, zahl2, ergebnis;
            bool repeat = false;
            do
            {
                Console.Write("Zahl 1: ");
                if (double.TryParse(Console.ReadLine(), out zahl1))
                {

                }
                else
                {
                    Console.WriteLine("Ungütlige eingabe, bitte versuchen sie es erneut");
                    repeat = true;
                    continue;
                }

                Console.Write("Zahl 2: ");
                if (double.TryParse(Console.ReadLine(), out zahl2))
                {

                }
                else
                {
                    Console.WriteLine("Ungütlige eingabe, bitte versuchen sie es erneut");
                    repeat = true;
                    continue;
                }

                ergebnis = zahl1 + zahl2;
                Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                
            } while (repeat);
            

        }
    }
}
