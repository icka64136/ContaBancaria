using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoTeste cliente; // Variàvel declarada para não Haver Problema de Escopo

            Console.WriteLine("Bem Vindo ao Banco Teste !");
            Console.Write("Numero da Conta:");
            int conta = int.Parse(Console.ReadLine());     
            Console.Write("Nome :");
            string nome = Console.ReadLine();       
            Console.WriteLine("Haverá Valor de Depósito Inicial? ");
            Console.Write("Digite : S / N :");
            char verifica = char.Parse(Console.ReadLine());   
            
            if (verifica == 's'|| verifica == 'S')//Verificação de Caracters entre = ' ', o Programa Faz a comparação de uma Letra "String ou Char".
            {
                
                Console.Write("Digite o Valor de Depósito :$ ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new BancoTeste(nome, valor, conta);
            }
            else
            {
                cliente = new BancoTeste(nome, conta);
            }

            

            Console.WriteLine();
            Console.Write("Dados do Cliente :" + cliente);
            Console.WriteLine();
            Console.Write("Digite um Valor Para Depósito : $");
            double DS =double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
            cliente.Deposito(DS);
            Console.WriteLine();

            Console.WriteLine("Dados Atualizados!");
            Console.Write(cliente);
            Console.WriteLine();

            Console.Write("Digite um Valor Para Saque : $");
            DS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Saque(DS);
            Console.WriteLine();

            Console.WriteLine("Dados Atualizados!");
            Console.Write(cliente);
        }
    }
}
/* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
exemplo). 
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
mostrando os dados da conta após cada operação. */
