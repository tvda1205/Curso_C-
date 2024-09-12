using System.Globalization;

namespace S4_ExTriangulo_SemPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double xA, yA, xB, yB, xC, yC;

            Console.WriteLine("Lados do triangulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Lados do triangulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = ( xA + xB + xC) / 2;
            double areaX = Math.Sqrt( p * (p - xA) * (p - xB) * (p - xC));


            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("A area do triangulo x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do triangulo y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}
