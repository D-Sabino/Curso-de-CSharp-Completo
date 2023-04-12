using System;

namespace Danki_Bank
{
    /* Aula: Criando nosso primeiro erro */
    /*
    public class ContaCorrente
    {
        private int Agencia, Numero;
        public static double TaxaOperacao { get; private set; }
        public static int TotalContasCriadas { get; private set; }


        /*
        public ContaCorrente(int agencia, int numero)
        {

            /* Aula: Tratando nosso primeiro erro*/
            /*
            Agencia = agencia;
            Numero = numero;
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
            /*
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
    */
    class Progam
    {
        static void Main(string[] args)
        {
            /* Aula: Tratando nosso primeiro erro*/
            /*
            ContaCorrente conta = new ContaCorrente(9999, 123456);
            ContaCorrente conta2 = new ContaCorrente(8888, 654321);
            */
            /*
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.ReadLine();
            */

            /* Aula: Conhecendo os arrays*/
            /*
            int[] matriz;
            matriz = new int[10];
            */
            /*
            string[] nomes;
            nomes = new string[5];

            nomes[0] = "Joana";
            nomes[1] = "Roberto";
            nomes[2] = "Daniel";
            nomes[3] = "Lucas";
            nomes[4] = "Bianca";
            */
            /* Aula: Brincando com Arrays #1 */
            /*
            foreach(string nome in nomes) 
            {
                Console.WriteLine(nome);
            }
            */

            /* Aula: Brincando com Arrays #2 */
            /*
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero maior que zero:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }

            //Ordenar vetores.
            Array.Sort(numeros);
            Array.Sort(pares);
            Array.Sort(impares);

            Console.WriteLine("Estes são os numeros que voce digitou:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Estes são os numeros pares que voce digitou:");
            foreach (int numero in pares)
            {
                if (numero != 0 ) Console.WriteLine(numero);
            }

            Console.WriteLine("Estes são os numeros impares que voce digitou:");
            foreach (int numero in impares)
            {
                if (numero != 0) Console.WriteLine(numero);
            }
            */

            /* Aula: Brincando com Arrays #3 */
            String[] estudantes = new string[4];
            int[] idade = new int[4];
            String[] lista = new String[4];

            Console.WriteLine("Digite o nome de dez estudantes e suas respectivas idade:");

            for (int i = 0; i < estudantes.Length; i++)
            {
                Console.WriteLine("Nome do estudante:");
                estudantes[i] = Console.ReadLine();

                Console.WriteLine("Idade:");
                idade[i] = Convert.ToInt16(Console.ReadLine());

                if (idade[i] < 10) lista[i] = "0" + idade[i] + " " + estudantes[i];
                else lista[i] = idade[i] + " " + estudantes[i];


            }

            Array.Sort(lista);
            foreach(String l in lista)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine("O estudante mais velho é o: " + lista[3]);
            Console.WriteLine("O estudante mais novo é o: " + lista[0]);
        }
    }
}