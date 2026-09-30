namespace Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEMORY -> Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeil12Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 dekt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.");
            bool[,] completetBoolArray = new bool[4, 4];
            bool[,] selectetFields = new bool[4, 4];
            char[,] charPos = new char[4, 4];
            char[] chars = {'#', '♦','♥', '♫', '☻', '▲', '◄', '§',};
            bool updateBoard = true;
            Console.WriteLine("");
            Console.WriteLine("");

            if (updateBoard)
            {
                PrintBoard(completetBoolArray, charPos, selectetFields);
                updateBoard = false;
            }
            
            Console.ReadLine();
            
        }

        static void PrintBoard(bool[,] completetBoolArray, char[,] charPos, bool[,] selectetFields)
        {
            Console.Clear();
            Console.WriteLine("MEMORY -> Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeil12Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 dekt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.");
            Console.WriteLine("");
            Console.WriteLine("");
            

            for (int i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.Write("     ");
                        }
                        else if (i == 0)
                        {
                            Console.Write($" {j}  ");
                        }
                        else if (i != 0 && j == 0)
                        {
                            Console.Write($"  {i/2} |");
                        }
                        else if (i >= 1 && j >= 1)
                        {
                            Console.Write(" ? |");
                        }
                    }
                }
                else
                {
                    Console.Write("    +---+---+---+---+");
                }
                
                Console.WriteLine("");
            }
        }
    }
}
