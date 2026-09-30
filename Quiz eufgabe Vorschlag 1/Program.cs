namespace Quiz_eufgabe_Vorschlag_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true, invalid = false;
            string input;
            int operand1 = 0, operand2 = 0, output = 0;
            do
            {
                do
                {
                    invalid = false;
                    Console.WriteLine("Make your calculation (or press Q to quit): ");
                    input = "1+ 1";

                    string[] inputs = input.Split('+', '-', '*', '/', '%');
                    if (int.TryParse(inputs[0], out operand1) && inputs.Length! <= 2)
                    {

                    }
                    else
                    {
                        invalid = true;
                        Console.WriteLine("Ungültige eingabe, es muss eine Zahl sein -> versuche es erneut");
                        continue;
                    }
                    if (int.TryParse(inputs[1], out operand2))
                    {

                    }
                    else
                    {
                        invalid = true;
                        Console.WriteLine("Ungültige eingabe, es muss eine Zahl sein -> versuche es erneut");
                        continue;
                    }
                } while (invalid);
                if (input.Contains('+'))
                {
                    output = operand1 + operand2;
                    Console.WriteLine(output);
                }
                else if (input.Contains('-'))
                {
                    output = operand1 - operand2;
                    Console.WriteLine(output);

                }
                else if (input.Contains('*'))
                {
                    output = operand1 * operand2;
                    Console.WriteLine(output);
                }
                else if (input.Contains('/'))
                {
                    try
                    {
                        output = operand1 / operand2;
                        Console.WriteLine(output);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Du kannst nicht durch null teilen");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("unbehandelter Fehler: " + ex);
                    }
                }
            } while (repeat);

        }
    }
}
