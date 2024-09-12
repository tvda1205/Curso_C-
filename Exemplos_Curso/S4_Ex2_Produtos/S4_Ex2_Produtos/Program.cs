namespace S4_Ex2_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Produtos p = new Produtos();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

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
