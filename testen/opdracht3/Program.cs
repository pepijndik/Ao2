using System;

namespace opdracht3
{
    //Schrijf een functie genaamd Resultaat(int getal). Als een cijfer kleiner is dan 5.5 dan wordt er afgedrukt “onvoldoende”.
    //Als het gelijk is aan 5.5 of hoger maar kleiner dan 8 dan wordt er afgedukt “ voldoende” . 
    //En als het cijfer een 8 is of hoger dan wordt er afgedrukt “Goed”.
    class Program
    {
        public void resultaat(int getal)
        {
            if(getal < 5.5)
            {
                Console.WriteLine("Onvoldoende");
            }
            else if(getal >= 5.5 && getal <8)
            {
                Console.WriteLine("Voldoende");
            }else if (getal > 8)
            {
                Console.WriteLine("Goed");
            }
            
        }
        static void Main(string[] args)
        {
           resul
        }
    }
}
