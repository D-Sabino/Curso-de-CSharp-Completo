﻿using System;
using System.Runtime.CompilerServices;

namespace Curso_DankiCode
{
    /* Aula:  Criando classes no C# */
    public class Aluno
    {
        /*
        public string nome = "Daniel", cpf = "99999999999";
        public int nota_anual = 10;
        */

        /* Aula:  Construtor */
        public Aluno(string nome)
        {
            nomeDoAluno = nome;
        }

        public string nomeDoAluno { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Daniel");
            Aluno aluno2 = new Aluno("Bianca");
            Console.WriteLine(aluno1.nomeDoAluno);
            Console.WriteLine(aluno2.nomeDoAluno);
        }
    }
}