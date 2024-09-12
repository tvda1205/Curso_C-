using System.Globalization;

namespace Encapsulamento
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Produtos p = new Produtos("TV", 30.00, 10);

            p.Nome = "Whopper";

            Console.WriteLine( p.Nome );
        }

    }
}
