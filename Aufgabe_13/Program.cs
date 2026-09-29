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
                Console.WriteLine("Wie lang soll die Linie sein?");
                Console.Write("Deine Eingabe: ");
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    for(int i = 1; i < length; i++)
                    {

                    }
                }
            } while (invalid);
            
        }
    }
}
