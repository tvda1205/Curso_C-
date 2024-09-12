using System.Globalization;
namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorMoeda.Converter(cot, dolar);
            

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
