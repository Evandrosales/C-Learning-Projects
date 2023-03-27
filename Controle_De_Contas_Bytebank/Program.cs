//using Bytebank;
//using Controle_De_Contas_Bytebank;
//using System;

//ContaCorrente contadamaria = new ContaCorrente(19, "1010-Y");
//contadamaria.Titular = "André Silva";
//contadamaria.SetSaldo (-100);


//ContaCorrente contadoandre = new ContaCorrente(18, "1010-X");
//contadoandre.Titular = "André Silva";
//contadoandre.SetSaldo(100);
//contadoandre.GetSaldo();
//Cliente clienteandre = new Cliente();
//clienteandre.Nome = "André Silva Dos Santos";
//clienteandre.Cpf = "464.428.658-35";
//clienteandre.Profissao = "Analista de Dados";
//clienteandre.Cidade = "Carapicuiba";
//clienteandre.Estado = "São Paulo";


//int saida = 0;

//while (saida != -1) {

//    Console.WriteLine("\nBem Vindo " + contadoandre.Titular);
//    Console.WriteLine("Digite a operação: ");
//    Console.WriteLine("1 - sacar\n" + "2 - transferir\n" + "3 - depositar\n" + "4 - verificar perfil\n" + "0 - Sair\n");
//    double opcao = double.Parse(Console.ReadLine());



//    if (opcao == 1)
//    {
//        Console.WriteLine("qual o valor? ");
//        double valor = double.Parse(Console.ReadLine());
//        if (contadoandre.Sacar(valor) == true)
//        {
//            Console.WriteLine("Saque realizado...");
//            Console.WriteLine("Novo valor em conta para andré = " + contadoandre.GetSaldo());

//        }
//        else
//        {
//            Console.WriteLine("Saldo insuficiente em conta...");
//        }

//    }
//    else if (opcao == 2)
//    {
//        Console.WriteLine("Qual o valor? ");
//        double valor = double.Parse(Console.ReadLine());

//        if (contadoandre.Transferir(valor, contadamaria) == true)
//        {

//            Console.WriteLine("Saldo em conta André = " + contadoandre.GetSaldo());
//            Console.WriteLine("Saldo em conta Maria = " + contadamaria.GetSaldo());
//        }
//        else
//        {
//            Console.WriteLine("Saldo insuficiente em conta.");
//        }
//    }
//    else if (opcao == 3)
//    {
//        Console.WriteLine("Qual o valor? ");
//        double valor = double.Parse(Console.ReadLine());
//        contadoandre.depositar(valor);
//        Console.WriteLine("Novo saldo em conta: " + contadoandre.GetSaldo());
//    }
//    else if (opcao == 4)
//    {
//        Console.WriteLine("Titular: " + clienteandre.Nome);
//        Console.WriteLine("Saldo em Conta: " + "R$" + contadoandre.GetSaldo());
//        Console.WriteLine("Conta: " + contadoandre.Conta);
//        Console.WriteLine("Agencia: " + contadoandre.Numero_agencia);
//        Console.WriteLine("CPF: " + clienteandre.Cpf);
//        Console.WriteLine("Cidade: " + clienteandre.Cidade);
//        Console.WriteLine("Estado: " + clienteandre.Estado);

//    }
//    else if (opcao == 0)
//    {
//        Console.WriteLine("Saindo...");
//        saida = -1;
//    }
//    else
//    {
//        Console.WriteLine("Opção invalida...");
//    }
//}
using System;
using Bytebank;
using Controle_De_Contas_Bytebank.Funcionarios;
using Controle_De_Contas_Bytebank.Diretoria;
using Controle_De_Contas_Bytebank.Utilirario;

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Pedro Souza";
funcionario.CPF = "123456789-10";
funcionario.Salario = 2000;


Diretor diretor = new Diretor();
diretor.Nome = "Bruna Oliveira";
diretor.CPF = "987654321-10";
diretor.Salario = 5000;

GerenciadorDeBonificacao bonificacao = new GerenciadorDeBonificacao();
bonificacao.Registrar(funcionario);
bonificacao.Registrar(diretor);

Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.GetBonificacao());
Console.WriteLine(funcionario.Salario);
Console.WriteLine(diretor.Nome);
Console.WriteLine(diretor.GetBonificacao());
Console.WriteLine(diretor.Salario);