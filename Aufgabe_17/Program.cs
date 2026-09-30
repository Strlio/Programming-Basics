namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool invalid = false;
            int[] inputInteger = new int[1];
            Console.WriteLine("------------------");
            Console.WriteLine("Array-Sorter-3000");
            Console.WriteLine("------------------");
            do
            {
                invalid = false;
                Console.WriteLine("Gib die Ganzzahlen, die sortiert werden sollen, mit Leerzeichen getrennt ein:");
                input = Console.ReadLine();
                string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                inputInteger = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (int.TryParse(inputArray[i], out inputInteger[i]))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Ungültige eingaben, es dürfen nur zahlen sein -> versuchen sie es erneut");
                        invalid = true;
                        break;
                    }
                }
            } while (invalid);
            
            
            
            
            
            inputInteger = SortArray(inputInteger);
            Console.WriteLine("");
            Console.WriteLine("Das Ergabnis ist :");
            for ( int i = 0; i < inputInteger.Length; i++)
            {
                Console.Write($"{inputInteger[i]} ");
            }

            Console.ReadLine();
        }

        static int[] SortArray(int[] input)
        {
            bool sorted = true; // sortet true == nicht sortiert
            bool error = false;
            int[] output = new int[input.Length];
            output = input;
            int cache = 0;
            while (sorted)
            {
                for(int i = 0; i <= input.Length - 1; i++)
                {
                    if(i == 0)
                    {
                        continue;
                    }else if (output[i] <= output[i - 1]){
                        cache = output[i - 1];
                        output[i - 1] = output[i];
                        output[i] = cache;
                    }
                    else
                    {
                        error = false;
                        
                        for(int j = 1; j < output.Length - 1; j++)
                        {
                            if (output[j] >= output[j - 1])
                            {

                            }
                            else
                            {
                                error = true;
                            }
                        }
                        if(error == false)
                        {
                            sorted = false;
                        }
                    }
                    
                }
            }
            return output;
        }
    }
}
