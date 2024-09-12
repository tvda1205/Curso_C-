// Ex 3 - For

int n = int.Parse(Console.ReadLine());
double a, b, div;

for (int i = 0; i < n; i++)
{
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("DIVISÃO IMPOSSIVEL");
    }
    else
    {
        Console.WriteLine(a / b);
    }

}
