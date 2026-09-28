namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false, invalid2 = false;
            int AnzahlKilometer;
            double AnzahlBahnrunden;
            string EingabeJN;
            do
            {
                invalid = false;
                Console.WriteLine("Wie viele kilometer möchtest du rennen?");
                if (int.TryParse(Console.ReadLine(), out AnzahlKilometer))
                {
                    if(AnzahlKilometer <= 42)
                    {
                        Math.Round(AnzahlBahnrunden = (AnzahlKilometer * 1000) / 400,1);
                        Console.WriteLine("das wären " + AnzahlBahnrunden + " Runden, bist du bereit für den Lauf? (j/n)");
                        EingabeJN = Console.ReadLine();
                        do
                        {
                            if (EingabeJN == "j" || EingabeJN == "n")
                            {
                                if (EingabeJN == "j")
                                {
                                    
                                    for(int i = 1; i <= AnzahlBahnrunden; i++)
                                    {
                                        Console.WriteLine("Du laufst Runde " + i);
                                    }
                                }
                                else
                                {
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe, versuche es erneut");
                                invalid2 = true;
                                continue;
                            }
                        } while (invalid2);
                        

                    }
                    else
                    {
                        Console.WriteLine("Du schaffst das nicht");
                    }
                }
                else
                {
                    Console.WriteLine("Die eingabe ist ungültig, versuschen sie es erneut.");
                    invalid = true;
                    continue;
                }
            } while (invalid);
        }
    }
}
