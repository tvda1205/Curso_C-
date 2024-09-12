using System.Globalization;


namespace S5_Ex1_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produtos p = new Produtos(nome, preco, quantidade);

            Produtos p2 = new Produtos();

            Produtos p3 = new Produtos
            {
                Nome = "Notebook",
                Preco = 2000.00,
                Quantidade = 10
            };

            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a serem adicionados: ");

            Console.WriteLine("");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine($"Dados atualizados {p}");

            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a serem removidos: ");

            Console.WriteLine("");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine($"Dados atualizados {p}");
        }
    }
}
