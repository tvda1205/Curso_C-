namespace Ex_ParamVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculadora.Sum(new int[] { 5,6,6});

            Console.WriteLine(result);

            //Testar o ref modificando parametro

            int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);

            int triple;
            Calculadora.Triple2(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
