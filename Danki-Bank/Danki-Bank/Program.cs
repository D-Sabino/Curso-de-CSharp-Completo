using System;

namespace Danki_Bank
{
    /* Aula: Criando nosso primeiro erro */
    public class ContaCorrente
    {
        private int Agencia, Numero;
        public static double TaxaOperacao { get; private set; }
        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalContasCriadas;
            TotalContasCriadas++;
        }
    }

    class Progam
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(9999, 123456);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.ReadLine();
        }
    }
}