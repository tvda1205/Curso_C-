﻿using Atv_Delegate.Entities;
using Atv_Delegate.Services;
using System.Globalization;

namespace Atv_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            ProductService ps = new ProductService();

            double sum = ps.FilteredSum(list, p => p.Name[0] == 'T');

            Console.WriteLine("Sum = " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
