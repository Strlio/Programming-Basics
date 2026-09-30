using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.Json;

namespace Witz_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat;
            do
            {
                
                
                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string jsonData = new StreamReader(responseStream).ReadToEnd();

                JArray arr = JArray.Parse(jsonData);

                string witz = (string)arr[0]["text"];

                Console.WriteLine(witz);

                Console.WriteLine("");
                Console.Write("Möchtest du den nächsten Witz hohlen?  j/n: ");
                if (Console.ReadLine() == "j")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                Console.WriteLine("");
            } while (repeat);

            
            //JArray array = JArray.Parse(json);

            Console.ReadLine();
        }
    }
}
