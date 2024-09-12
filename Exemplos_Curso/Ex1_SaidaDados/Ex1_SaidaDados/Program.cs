using System;

namespace Ex1_SaidaDados // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;

            double saldo = 10.35784;

            string nome = "Thiago";


            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Tecnica Placeholder

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Tecnica Interpolação

            Console.WriteLine( nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais"); //Tecnica Concatenação
        }
    }
}