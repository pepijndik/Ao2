using System;

namespace opdracht2
{
    class Program
    {
        
        public static int positief(int getal){
            if(getal < 1){
                     String text = "Getal is positief!";
                  return text;
            }
            else if(getal < -1){
                String text = "Getal is Negatief of nul";
                  return text;
}                     
}
        static void Main(string[] args)
        {
            String text = positief(0);
           Console.WriteLine(text);
        }
    }
}
