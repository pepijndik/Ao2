using System;

namespace opdracht1
{
    class Program
    {
        public static double verkoop(int inkoop)
        {
            double noBtw = inkoop + 300;
            double totaal = noBtw * 1.21;
            return totaal;
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Verkoop prijs");
            double totaal = verkoop(1);
            Console.Write(totaal);

        }
       
}
}
