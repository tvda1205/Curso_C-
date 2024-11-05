using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioResolvido_Polimorfismo.Entities;

namespace ExercicioResolvido_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employees> list = new List<Employees>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional Charge ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, value, addCharge));
                } else if (ch == 'n')
                {
                    list.Add(new Employees(name, hours, value)); ;
                }

                

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS ");

            foreach (Employees emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
