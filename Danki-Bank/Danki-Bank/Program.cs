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

            /* Aula: Tratando nosso primeiro erro*/
            /*
            if (TotalContasCriadas == 0)
            {
                TaxaOperacao = 30;
                TotalContasCriadas++;
            }
            else
            {
                TaxaOperacao = 30 / (TotalContasCriadas + 1);
                TotalContasCriadas++;
            }
            */

            /* Aula: Conhecendo o Try e o Catch */
            try
            {
                TotalContasCriadas++;
                TaxaOperacao = 30 / TotalContasCriadas;
                Console.WriteLine("O resultado é:" + TaxaOperacao);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não podemos dividir por zero!");
            }
        }   
    }

    class Progam
    {
        static void Main(string[] args)
        {
            /* Aula: Tratando nosso primeiro erro*/
            ContaCorrente conta = new ContaCorrente(9999, 123456);
            ContaCorrente conta2 = new ContaCorrente(8888, 654321);

            /*
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            */

            Console.ReadLine();
        }
    }
}