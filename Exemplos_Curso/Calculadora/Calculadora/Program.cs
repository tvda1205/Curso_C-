﻿using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia = " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi = " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
