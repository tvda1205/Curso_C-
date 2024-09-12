// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double media = (a * 2 + b * 3 + c * 5) / 10;

    Console.WriteLine(media.ToString("F1"));
}