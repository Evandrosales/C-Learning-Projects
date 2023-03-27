using System;

namespace For_With_break
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int contadorLinhas =0; contadorLinhas <=9; contadorLinhas++)
            {
                Console.WriteLine();
                for (int contadorColunas =0; contadorColunas <=9; contadorColunas++)
                {
                    Console.Write("*");
                    if(contadorColunas == contadorLinhas)
                    {
                        break;
                    }
                }
            }
        }
    }
}
