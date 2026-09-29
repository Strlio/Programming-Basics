namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            int eingabe, randomNumber;
            Console.WriteLine("----------------------");
            Console.WriteLine("Zahlen raten (1...100");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Console.WriteLine("Deine Zahle (1...100):");
            do
            {
                invalid = false;
                if (int.TryParse(Console.ReadLine(), out eingabe))
                {
                    if(eingabe == randomNumber)
                    {

                    }else if(eingabe < randomNumber){

                    }else if(eingabe > randomNumber) {

                    }
                    else
                    {
                        Console.WriteLine("wtf just happend -> thiss schudn't be possible");
                    }
                }
                else
                {
                    Console.WriteLine("ungültige Eingabe, es muss eine Ganzzahl sein -> versuche es erneut.");
                    invalid = true;
                    continue;

                }
            } while (invalid);
        }
    }
}
