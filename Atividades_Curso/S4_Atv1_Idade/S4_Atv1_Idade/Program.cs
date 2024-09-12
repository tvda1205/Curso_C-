namespace S4_Atv1_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;

            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");

            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} é a pessoa mais velha");
            } else
            {
                Console.WriteLine($"{p2.Nome} é a pessoa mais velha");
            }
        }
    }
}
