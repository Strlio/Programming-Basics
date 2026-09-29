namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false, repeat = true;
            int eingabeInt;
            string eingabe;
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");
            Console.WriteLine("");
            while (repeat)
            {
                do
                {
                    invalid = false;


                    Console.Write("Eingabe Jahr (q to quit): ");
                    eingabe = Console.ReadLine();
                    if (int.TryParse(eingabe, out eingabeInt))
                    {
                        if ((eingabeInt % 4) == 0)
                        {
                            Console.WriteLine("Das Jahr " + eingabe + " ist ein Schaltjahr.");
                        }
                        
                        else
                        {
                            Console.WriteLine("das Jahr ist KEIN Schaltjahr");
                        }
                        
                    }
                    else if (eingabe == "q")
                    {
                        repeat = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ungültige eingabe, es muss eine Zahl sein");
                        invalid = true;
                        continue;
                    }
                } while (invalid);
            }
        }
    }
}
