namespace Aufgabe_aufsummieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            string eingabe;
            try
            {
                do
                {
                    invalid = false;
                    eingabe = "1,5,8,4,2,7,9"; // das was der benutzer eingibt

                    string[] eingabeArray = eingabe.Split(',');
                    int[] input = new int[eingabeArray.Length];
                    for (int i = 0; i <= eingabeArray.Length; i++)
                    {
                        if (!int.TryParse(eingabeArray[i], out input[i]))
                        {
                            Console.WriteLine("Ungültige eingabe, es müssen zahlen sein");
                            invalid = true;
                            break;
                        }
                    }
                    SumUpAndPrintArray(input);
                } while (invalid);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            
        }

        static void SumUpAndPrintArray(int[] input)
        {
            int[] output = new int[input.Length];
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
                output[i] = sum;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"[{i}] -> {input[i]}, ");
            }
        }
    }
}






















































/*
 * Lösung: 
 * IndexOutOfRangeExcepion
 * 
 * Zusatzaufgabe:
 * auf Zeile 18 da in der for schleife <= statt < steht
 */