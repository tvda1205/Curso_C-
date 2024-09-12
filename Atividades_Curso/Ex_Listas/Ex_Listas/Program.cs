using System.Globalization;

namespace Ex_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> f = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Funcionario #{i+1}");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario func = new Funcionario(id, nome, salario);

                f.Add(func);
            }

            Console.Write("Forneça o id do funcionario que vai ter aumento: ");
            int id1 = int.Parse(Console.ReadLine());

            Funcionario funcionario = f.Find(x => x.Id == id1);

            if (funcionario != null)
            {
                Console.Write("Forneça a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.Salario += funcionario.Salario * porcentagem / 100;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }

            Console.WriteLine("Lista atualizada de funcionarios: ");

            foreach (var item in f)
            {

            Console.WriteLine(item.ToString()); 
            
            }

        }
    }
}
