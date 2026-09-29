namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stemWidth = 0, stemHeight = 0, entireHeight = 0;
            bool invalid = false;
            do
            {
                invalid = false;
                Console.Write("Breite des Stammes? (muss eine ungerade Zahl sein)");
                if (int.TryParse(Console.ReadLine(), out stemWidth))
                {
                    if (stemWidth % 2 == 0)
                    {
                        Console.WriteLine("es muss leider eine Ungerade Zahl sein -> versuchen sie es erneut");
                        invalid = true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, es muss eine Zahl sein -> versuchen sie es erneut");
                    invalid = true;
                    continue;
                }
            } while (invalid);


            do {
                invalid = false;
                Console.Write("Höhe des Stammes? ");
                if (int.TryParse(Console.ReadLine(), out stemHeight))
                {

                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, es muss eine Zahl sein -> versuchen sie es erneut");
                    invalid = true;
                    continue;
                }
            } while (invalid);


            do {
                invalid = false;
                Console.Write("Höhe der Krone? (Muss eine Gerade Zahl sein)");
                if (int.TryParse(Console.ReadLine(), out entireHeight))
                {
                    if (entireHeight % 2 != 0)
                    {
                        Console.WriteLine("es muss leider eine Gerade Zahl sein -> versuchen sie es erneut");
                        invalid = true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, es muss eine Zahl sein -> versuchen sie es erneut");
                    invalid = true;
                    continue;
                }
            } while (invalid);

            
            
            for(int i = 0; i < entireHeight; i++)
            {
                for (int j = 0; j < (entireHeight - i)-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i * 2) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            for(int j = 0; j < stemHeight; j++)
            {
                for (int k = 0; k < entireHeight - ((stemWidth / 2) + 1); k++)
                {
                    Console.Write(" ");
                }

                for (int l = 0; l < stemWidth; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            

            
        }
    }
}
