using System;

 namespace Calculo_Poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para Calcular o Reajuste, digite o valor de entrada:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Por gentileza, digite a % ao mês:");
            double porcentagem = double.Parse(Console.ReadLine());
            int mes = 1;
            Console.WriteLine("Digite a quantidade de meses e para investimento: ");
            int tempoInvestimento = int.Parse(Console.ReadLine());
            
            while(mes <= tempoInvestimento)
            {
                valor  = valor + (valor * porcentagem) + 200;
                Console.WriteLine("No mês " + mes + " o valor será de " + valor);
                mes += 1;
            }

        }
    }
}

