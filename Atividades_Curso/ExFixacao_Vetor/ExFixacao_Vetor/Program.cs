namespace ExFixacao_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos será alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel [] hospedagem = new Aluguel[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome ");
                string nome = Console.ReadLine();
                Console.Write("Email ");
                string email = Console.ReadLine();
                Console.Write("Quarto ");
                int quarto = int.Parse(Console.ReadLine());

                hospedagem[i] = new Aluguel(nome, email, quarto);

            }


            Console.WriteLine("Quartos Ocupados");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(hospedagem[i].ToString());
            }

        }
    }
}
