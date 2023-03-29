﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula:  Variaveis e seus tipos */
            //TipoDessaVariavel nomeParaEssaVariavel = atribuirUmValor

            /*
                int - armazenam numeros inteiros. Ex: 10, 15, 20, 30 ...
                float - armazenam numeros quebrados. Ex: 20.5, 24.8...
                string - armazenam um texto
                char - armazenam um caractere
                bool - booleano (verdadeiro ou falso)
            */

            //Exemplo de declaração, Int:
            int numero = 10;

            //Float:
            float numero_2 = 2.5f;

            //String:
            string nome = "Daniel";

            //Char:
            char caractere = 'D';

            //Exibindo o valor preenchido no console.
            Console.WriteLine(nome);
            Console.WriteLine(numero);

            /* Aula:  Operadores aritmeticos */
            // +, -, /, ++, --

            Console.WriteLine("\nEscreva um numero:");
            int numero_3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscreva outro numero:");
            int numero_4 = Convert.ToInt32(Console.ReadLine());

            int soma = (numero_3 + numero_4);

            Console.WriteLine("\nA soma dos numeros é: " + soma);


            /* Aula:  Estrutura condicional e outros operadores */
            // ==, >, <, >=, <=, !=, 

            if (soma < 50 && soma != 8)
            {
                Console.WriteLine("\nA soma é menor que 50, o total da soma foi de " + soma);
            }
            if(soma == 50)
            {
                Console.WriteLine("\nA soma é igual a 50.");
            }
            else
            {
                Console.WriteLine("\nA soma é maior que 50, o total da soma foi de " + soma);
            }
        }
    }
}

