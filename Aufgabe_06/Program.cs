namespace Aufgabe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("------------");
            Console.WriteLine("");

            for(int i = 1; i <= 10; i++)
            {
                for (int o = 1; o <= 10; o++)
                {
                    Console.Write((i * o) + "\t");
                }
                Console.WriteLine("");
            }






            Console.ReadLine(); //Das es am schluss nicht direkt eine fehlermeldung gibt.
        }
    }
}
