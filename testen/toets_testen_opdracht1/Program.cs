using System;
using System.Threading;
namespace toets_testen_opdracht1
{
    class Program
    {
        /*
         Auhtor: pepijn dik
         project: calc
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Voer het type auto in druk daarna op enter");
            string type = Console.ReadLine();
            Console.WriteLine("Voer het aantal dagen in druk daarna op enter");
            int dagen = int.Parse( Console.ReadLine());
            Console.WriteLine("Voer het aantal km in druk daarna op enter");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("Bedankt voor de invoer het word berekend");
            bereken b = new bereken(type, dagen, km);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));

        
            Console.WriteLine("Totale prijs: "+ b.huur());
        }
    }
}
