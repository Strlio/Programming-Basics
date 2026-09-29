using System.Reflection.Metadata.Ecma335;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            bool invalid = false;
            do
            {
                invalid = false;
                Console.WriteLine("Zahl eingeben: ");
                if (int.TryParse(Console.ReadLine(), out zahl))
                {
                    if(zahl is >= 1 and <= 12)
                    {
                        string[] month= new string[] {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
                        Console.WriteLine("Monat: " + month[zahl -1]);




                        switch (zahl)
                        {
                            case 1:
                                Console.WriteLine("Monat: Januar");
                                break;
                            case 2:
                                Console.WriteLine("Monat: Februar");
                                break;
                            case 3:
                                Console.WriteLine("Monat: März");
                                break;
                            case 4:
                                Console.WriteLine("Monat: April");
                                break;
                            case 5:
                                Console.WriteLine("Monat: Mai");
                                break;
                            case 6:
                                Console.WriteLine("Monat: Juni");
                                break;
                            case 7:
                                Console.WriteLine("Monat: Juli");
                                break;
                            case 8:
                                Console.WriteLine("Monat: August");
                                break;
                            case 9:
                                Console.WriteLine("Monat: September");
                                break;
                            case 10:
                                Console.WriteLine("Monat: Oktober");
                                break;
                            case 11:
                                Console.WriteLine("Monat: November");
                                break;
                            case 12:
                                Console.WriteLine("Monat: Dezember");
                                break;

                        } //ich habe gehört das ihr einen array lieber habt :)
                    }
                    else
                    {
                        Console.WriteLine("ungütige Zahl: den Monat " + zahl + " gibt es nicht");
                        invalid = true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige eingabe, es muss eine zahl sein, versuchen sie es erneut");
                }
            } while (invalid);
        }
    }
}
