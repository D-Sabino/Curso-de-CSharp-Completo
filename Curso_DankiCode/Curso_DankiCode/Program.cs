using System;

namespace Curso_DankiCode
{
    /* Aula:  Criando classes no C# */
    public class Aluno
    {"
        public string nome = "Daniel", cpf = "99999999999";
        public int nota_anual = 10;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine(aluno.nome);
        }
    }
}