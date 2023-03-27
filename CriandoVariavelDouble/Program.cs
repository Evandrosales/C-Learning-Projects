using System;

namespace CriandoVariavelDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Valor do Salário...");
            double salario;
            salario = Console.Read();
            Console.WriteLine("Calculando...");
            double Total;
            Total = (salario - 10.50);
            Console.WriteLine("Valor Calculado = " + Total);
        }
    }
}
