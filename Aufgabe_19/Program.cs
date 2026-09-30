using static System.Net.Mime.MediaTypeNames;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Deine Eingabe: ");
            input = Console.ReadLine();
            char[] contains = {'a','e','i','o','u','ä','ö','ü'};
            int[] counter = new int[contains.Length];
            int anythingCounter = 0;
            for(int i = 0; i < contains.Length; i++)
            {
                counter[i] = input.Count(c => char.ToLower(c) == char.ToLower(contains[i]));
            }

            Console.WriteLine("");
            if(anythingCounter != 0)
            {
                Console.WriteLine($"Dein Text hat total {anythingCounter} Vokale");
            }
            for(int i = 0; i < contains.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine($"Der Buchstabe '{contains[i]}' kommt {counter[i]} mal vor");
                }
            }


            Console.ReadLine(); // das es nicht abstürtzt/schliesst
            
        }
    }
}
