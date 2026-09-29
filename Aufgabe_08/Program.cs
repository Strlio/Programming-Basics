using System.Text.Json;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Comment;
            bool forbidden = false;
            Console.WriteLine("Was ist dein kommenter");
            Comment = Console.ReadLine();


            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch"};


            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                if (Comment.Contains(forbiddenWords[i], StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Dein kommentar ist verboten");
                    forbidden = true;
                    break;
                }
                
            }
            if (forbidden)
            {

            }
            else
            {
                Console.WriteLine("Danke für dein kommentar");
            }
        }
    }
}
