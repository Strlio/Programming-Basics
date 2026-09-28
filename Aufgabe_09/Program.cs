using System.Numerics;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            BigInteger input;
            string output = " ";
            Console.WriteLine("Gib eine ganzzahl ein die du in Binär umwandeln möchtest: ");
            inputString = Console.ReadLine();

            if (inputString == "q"){
                Console.WriteLine("Programm beendet.");
            }
            else if (BigInteger.TryParse(inputString, out input))
            {
                while (input != 0)
                {
                    output = (input % 2) + output;
                    input /= 2;
                }
                Console.WriteLine("Binär:");
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("ungültige Eingabe, versuchen sie ess erneut");
            }
        }
    }
}
