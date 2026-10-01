namespace Memory
{
    public class Speicher
    {
        
    }
    internal class Program
    {
        public static bool[,] completetBoolArray = new bool[4, 4];
        public static bool[,] selectetFields = new bool[4, 4];
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("MEMORY -> Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeil12Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 dekt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.");
            
            char[,] charPos = new char[4, 4];
            char[] chars = {'#', '♦','♥', '♫', '☻', '▲', '◄', '§',};
            bool updateBoard = true, gameRunning = true, invalid = false;
            var (posX, posY) = (0, 0);
            Console.WriteLine("");
            Console.WriteLine("");

            if (updateBoard)
            {
                PrintBoard(completetBoolArray, charPos, selectetFields);
                charPos = AssignSymbols(chars);
                updateBoard = false;
            }
            //var (posX, posY) = RequestInput(1, true);
            //Console.WriteLine($"X: {posX}   Y: {posY}"); // test ob pos funktionieren
            do
            {
                do
                {
                    invalid = false;
                    (posX, posY) = RequestInput(true);
                    Console.WriteLine($"X:{posX}  Y: {posY}");
                    if(!IsFieldComplete(posX, posY, completetBoolArray))
                    {
                        selectetFields[posX, posY] = true;
                        PrintBoard(completetBoolArray, charPos, selectetFields);
                    }
                    else
                    {
                        Console.WriteLine("Dieses feld is nicht mehr verfügbar, wähle ein anderes");
                        invalid = true;
                        continue;
                    }
                } while (invalid);
                

            } while (gameRunning);
            
            PrintBoard(completetBoolArray, charPos, selectetFields);
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
                            if (completetBoolArray[j-1,i/2-1] == true)
                            {
                                Console.Write("   |");
                            }
                            else if (selectetFields[j - 1, i / 2 - 1] == true)
                            {
                                Console.Write($" {charPos[j - 1, i / 2 - 1]} |");
                            }
                            else
                            {
                                Console.Write(" ? |");
                            }                        }
                    }
                }
                else
                {
                    Console.Write("    +---+---+---+---+");
                }
                
                Console.WriteLine("");
            }
        }

        public static (int, int)RequestInput(bool firstCard)
        {
            string input;
            string[] inputs;
            int[] coordinates;
            bool invalid = false;

            do
            {
                invalid = false;
                if (firstCard)
                {
                    Console.WriteLine("Welche karte möchtest du aufdecken? (- |)");
                }
                else
                {
                    Console.WriteLine("Welche karte möchtest du als zweites aufdecken (- |)");
                }

                input = Console.ReadLine();
                inputs = input.Split(' ');
                coordinates = new int[inputs.Length];
                for (int i = 0; i < 2; i++)
                {
                    if (int.TryParse(inputs[i], out coordinates[i]) && coordinates[i] >= 1 && coordinates[i] <= 4 && inputs.Length == 2)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Ungültige eingabe, es muss eine zahl von 1-4 sein -> versuchen sie es erneut");
                        invalid = true;
                        continue;
                    }
                }
            } while (invalid);
            coordinates[0] -= 1;
            coordinates[1] -= 1;
            return (coordinates[0], coordinates[1]);
        }

        static char[,] AssignSymbols(char[] chars)
        {
            char[,] charPos = new char[4, 4];
            char[] char1d = new char[charPos.Length];
            for(int i = 0; i < char1d.Length; i++)
            {
                if(i < 8)
                {
                    char1d[i] = chars[i];
                }
                else
                {
                    char1d[i] = chars[i - 8];
                }
                
            }
            Random.Shared.Shuffle(char1d);
            int j, k = 0;
            for (int i = 0; i < char1d.Length; i++)
            {
                
                j = i / 4;
                if (k > 3)
                {
                    k = 0;
                }
                charPos[j, k] = char1d[i];
                k++;
            }
            return charPos;
        }

        static bool IsFieldComplete(int x, int y, bool[,] completetBoolArray)
        {
            if (completetBoolArray[x, y])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}