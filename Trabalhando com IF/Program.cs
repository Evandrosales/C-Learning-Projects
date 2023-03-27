using System;

namespace Trabalhando_com_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Condicionais");
            Console.WriteLine("Digite a senha correta... ");
            
            int Idade;
            Idade = int.Parse(Console.ReadLine());

            if (Idade >= 18)
            {
                Console.WriteLine("Entrada Liberada... ");
                Console.WriteLine("Seja Bem-Vindo");
                Console.WriteLine("Digite um numero para calcular: ");
                int num = int.Parse(Console.ReadLine());
                int Total = num * 2;
                Console.WriteLine("O Valor Total é = " + Total);
            }
            else
            {
                Console.WriteLine("Entrada Proibida!! ");
                Console.WriteLine("Por Gentileza entrar em contato com o suporte. ");
            }
        }
    }
}
