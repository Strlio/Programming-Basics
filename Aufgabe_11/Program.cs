namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            int zahl1, zahl2;
            do
            {
                invalid = false;
                Console.WriteLine("Zahl 1: ");
                if (int.TryParse(Console.ReadLine(), out zahl1))
                {
                    Console.WriteLine("Zahl 2: ");
                    if (int.TryParse(Console.ReadLine(), out zahl2))
                    {
                        Console.WriteLine("Quersumme wird berechnet...");
                        BerechneQuersumme(zahl1, zahl2);
                    }
                    else
                    {
                        Console.WriteLine("Ungültige eingabe, es muss eine zahl sein, versuchen sie es erneut.");
                        invalid = true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige eingabe, es muss eine zahl sein, versuchen sie es erneut.");
                    invalid = true;
                    continue;
                }


            } while (invalid);
            Console.ReadLine(); //das es nicht abstürzt
        }

        static void BerechneQuersumme(int zahl1, int zahl2)
        {
            int sum = 0;
            int currentNum, calcNum;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Zahl\t| Quersumme\t| Zahl / Quersumme");
            Console.WriteLine("---------------------------------------");




            if (zahl1 <= zahl2)
            {












                currentNum = zahl1;
                while(currentNum !<= zahl2)
                {
                    calcNum = currentNum;
                    while (calcNum != 0)
                    {
                        sum += calcNum % 10;
                        calcNum /= 10;
                    }

                    if((currentNum % sum) == 0)
                    {
                        Console.WriteLine(currentNum + "\t| " + sum + "\t\t| " + (currentNum / sum));
                    }
                    sum = 0;
                    currentNum++;
                }
            }















            else //dass man die zahlen auch rückwärts eingeben kann => versuche es.
            {
                currentNum = zahl2;
                while(currentNum !<= zahl1)
                {
                    calcNum = currentNum;
                    while (calcNum != 0)
                    {
                        sum += calcNum % 10;
                        calcNum /= 10;
                    }

                    if((currentNum % sum) == 0)
                    {
                        Console.WriteLine(currentNum + "\t| " + sum + "\t\t| " + (currentNum / sum));
                    }
                    sum = 0;
                    currentNum++;
                }
            }
        }
    }
}