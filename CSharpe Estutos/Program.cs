using System;

namespace CSharpe_Estutos
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double NOTA = ((A * 3.5) + (B * 7.5))/(3.5 + 7.5) ;
     
            Console.WriteLine("MÍDIA = " + NOTA.ToString("0.00000", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
