using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtor 1
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0; //Por padrão o valor já é zero, mas por questões didáticas irei colocar.
        }

        //Construtor 2
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) // aqui estamos refêrenciando o construtor 1
        {
            Saldo = depositoInicial;
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        // Aqui vamos será mostrados os dados completos do titular da conta
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
