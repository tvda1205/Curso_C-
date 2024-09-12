using System.Globalization;
namespace ExS5_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Entre com o numero da conta: ");
            int numbConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();


            Banco b = new Banco(numbConta, titular, 0);

            Console.Write("Haverá depósito na conta?(S/N) ");
            string x = Console.ReadLine();

            if (x == "S")
            {

                Console.Write("Qual é o deposito inicial? ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                b.Deposito(saldo);
                Console.WriteLine(b);
            }
            else if (x == "N")
            {

                Console.WriteLine(b);

            }

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(deposito);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(b);

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(b);

        }
    }
}
