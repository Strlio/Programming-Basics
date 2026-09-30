namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false, gussedNumber = true;
            int eingabe, randomNumber, numberOfTries = 0;
            Console.WriteLine("----------------------");
            Console.WriteLine("Zahlen raten (1...100");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Console.WriteLine("Deine Zahle (1...100):");
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 100);
            do
            {
                do
                {

                    
                    invalid = false;
                    if (int.TryParse(Console.ReadLine(), out eingabe))
                    {
                        if (eingabe == randomNumber)
                        {
                            numberOfTries++;
                            Console.WriteLine($"Glückwunsch du hast die richtige zahl geraten! du hast {numberOfTries} gebraucht");
                            gussedNumber = false;
                        }
                        else if (eingabe < randomNumber)
                        {
                            numberOfTries++;
                            Console.WriteLine("Zahl ist zu klein! Nächster Versuch: ");
                        }
                        else if (eingabe > randomNumber)
                        {
                            numberOfTries++;
                            Console.WriteLine("Zahl ist zu gross! Nächster Versuch: ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ungültige Eingabe, es muss eine Ganzzahl sein -> versuche es erneut.");
                        invalid = true;
                        continue;

                    }
                } while (invalid); // wiederholt wenn das tryparse fehlschlägt
            } while (gussedNumber); // widerhohlt bis die richtige nummer geraten wurde

            Console.ReadLine();
        }
    }
}
