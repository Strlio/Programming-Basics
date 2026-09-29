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
                //int[] output = new int[eingabeArray.Length];
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
                PrintArray(SumUp(input));
                


                
            } while (invalid);


            Console.ReadLine(); //macht dass das programm nicht direkt abstürzt
        }

        
        static int[] SumUp(int[] input)
        {
            int[] output = new int[input.Length];
            int sum = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                output[i] = sum;
            }

            return output;
        }

        static void PrintArray(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                Console.Write("[" + i + "] -> " + input[i] + ", ");
            }
        }
    }
}
