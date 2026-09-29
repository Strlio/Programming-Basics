namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            int length;
            do
            {
                invalid = false;
                Console.WriteLine("Wie lang soll die diagonale Linie sein?");
                Console.Write("Deine Eingabe: ");
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    length -= 1;
                    if(length > 150)
                    {
                        string eingabejn;
                        Console.WriteLine("Warnung bei zu hohen zahlen die linie nicht richtig dargestellt werden da mehr zeichen auf einer zeile sind als platz haben und die zeile darum umbricht.");
                        Console.WriteLine("Möchten sie es Trotzdem versuchen? j/n");
                        eingabejn = Console.ReadLine();
                        if(eingabejn == "j")
                        {

                        }else
                        {
                            break;
                        }
                    }
                    for(int i = 0; i <= length; i++)
                    {
                        for(int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write(" ");
                        for (int k = 0; k < (length - i); k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, es muss eine Zahl sein");
                    invalid = true;
                    continue;
                }
            } while (invalid);

            Console.ReadLine(); // dass das Programm nicht direkt abstürzt
            
        }
    }
}
