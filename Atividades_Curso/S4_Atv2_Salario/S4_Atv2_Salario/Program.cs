using System.Globalization;

namespace S4_Atv2_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionário: ");

            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");

            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (f2.Salario + f1.Salario)/2;

            Console.WriteLine($"A Media Salarial dos 2 salarios é {mediaSalario.ToString("F2")}");
        }
    }
}
