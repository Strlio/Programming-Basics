namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            string eingabe;
            

            do
            {
                invalid = false;
                Console.WriteLine("--------------------");
                Console.WriteLine("Zahlen Aufsummieren");
                Console.WriteLine("--------------------");
                Console.WriteLine("");
                Console.WriteLine("Welche Zahlen Möchtest du Aufsummieren, sie müssen mit einem \",\" getrennt sein");
                eingabe = Console.ReadLine();
                
                string[] eingabeArray = eingabe.Split(',');
                int[] input = new int[eingabeArray.Length];

                for (int i = 0; i < eingabeArray.Length; i++)
                {
                    if (int.TryParse(eingabeArray[i], out input[i]))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Ungültige eingabe, es müssen zahlen sein");
                        invalid = true;
                        break;
                    }
                }
                SumUp(input);

                /*for (int o = 0; o < eingabeArray.Length; o++)
                {
                    Console.WriteLine(input[o]);
                }
                Console.WriteLine(invalid);*/
            } while (invalid);
        }

        
        static int[] SumUp(int[] input)
        {
            int[] output = new int[input.Length];
            //und was soll ich bitte mit den zahlen machen??????????????!!!!!
            return output;
        }
    }
}
