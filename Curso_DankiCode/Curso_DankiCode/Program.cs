using System;
using System.Runtime.CompilerServices;

namespace Curso_DankiCode
{
    /* Aula:  Metodos */
    /*
    abstract class Motocicleta
    {
        //Public, pode ser chamado por qualquer metodo.
        public void LigarMoto() { }

        //Protected, apenas classe derivadas pode chamar.
        protected void AdicionarGasolina(int galoes) { }

        public abstract double ChegarNaVelocidadeX();

        public virtual int Drive(int quilometros, int velocidade) { }
    }
    */

    /* Aula:  Criando classes no C# */
    /*
    public class Aluno
    {
        /*
        public string nome = "Daniel", cpf = "99999999999";
        public int nota_anual = 10;
        */

    /* Aula:  Construtor */
    /*
    public Aluno(string nome)
    {
        nomeDoAluno = nome;
    }

    public string nomeDoAluno { get; set; }
}
*/


    /* Aula:  Introdução as heranças */
    /*
    public class Alessandra
    {
        private int valor = 10;

        public class Joao : Alessandra
        {
            public int PegarValor()
            {
                return this.valor;
            }
        }
    }
    */


    /* Aula: Classes abstratas e o modificador Override */
    /*
    abstract class Forma
    {
        public abstract int CalcularArea();
    }

    class Quadrado : Forma
    {
        int lado;
        public Quadrado(int n) => lado = n;

        public override int CalcularArea() => lado * lado;
    }
    */

    /* Aula: Método Virtual e continuando a usar Override */
    /*
    public class Trabalhador
    {
        public string nome;
        protected decimal salarioBase;

        public Trabalhador(string nome, decimal salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public virtual decimal CalcularPagamento()
        {
            return salarioBase;
        }
    }

    public class vendasTrabalhador : Trabalhador
    {
        private decimal bonusDeVendas;

        public vendasTrabalhador(string nome, decimal salarioBase, decimal bonusDeVendas) : base(nome, salarioBase)
        {
            this.bonusDeVendas = bonusDeVendas;

        }

        public override decimal CalcularPagamento()
        {
            return salarioBase + bonusDeVendas;
        }
    }
    */


    /* Aula: Conhecendo Interfaces com C# */
    //Quando inserido na interface, a implementação é obrigatoria.
    interface IControle
    {
        void ApertarBotao();
    }

    interface ITela
    {
        void Pintar();
    }

    class ClasseBase : IControle, ITela
    {
        public void ApertarBotao()
        {

        }

        public void Pintar()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
                Aluno aluno1 = new Aluno("Daniel");
                Aluno aluno2 = new Aluno("Bianca");
                Console.WriteLine(aluno1.nomeDoAluno);
                Console.WriteLine(aluno2.nomeDoAluno);
            */

            /* Aula:  Introdução as heranças */
            /*
            var Joao = new Alessandra.Joao();
            Console.WriteLine(Joao.PegarValor());
            */

            /* Aula: Classes abstratas e o modificador Override */
            /*
            var dq = new Quadrado(12);
            Console.WriteLine($"Area do quadrado = {dq.CalcularArea()}");
            */

            /* Aula: Método Virtual e continuando a usar Override */
            /*
            var trabalhador1 = new vendasTrabalhador("Ana", 1000, 500);
            var trabalhador2 = new Trabalhador("Robson", 1200);

            Console.WriteLine($"Trabalhador1 {trabalhador1.nome} ganhou: {trabalhador1.CalcularPagamento()}");
            Console.WriteLine($"Trabalhador2 {trabalhador2.nome} ganhou: {trabalhador2.CalcularPagamento()}"); 
            */


        }
    }
}