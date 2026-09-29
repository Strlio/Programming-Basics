namespace Aufgabe_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen von 1 bis 30 die 3 oder 5 teilbar sein");
            Console.WriteLine("");
            for(int i = 1; i <= 30; i++)
            {
                if((i % 3) == 0 || (i % 5) == 0)
                {
                    if(i == 30)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                    
                }
            }






            Console.ReadLine(); // machen dass das programm nicht direkt eine Fehlermeldung anzeigt
        }
    }
}
