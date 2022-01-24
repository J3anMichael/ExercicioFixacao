using System;
using ExercicioFixacao;
using System.Globalization;


namespace Exercicio
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Instanciando nossa classe ContaBancaria
            ContaBancaria conta;
            //code ..
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            if(resp == "s" || resp == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial); // instanciamos com os valores que iremos alterar

            }
            else
            {
                conta = new ContaBancaria(numero, titular); // instancia que trará os valores padrão e nosso ToString() da classe ContaBancaria;
            }


            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            //Deposito
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            //Saque
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}