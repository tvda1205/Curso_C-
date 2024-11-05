using Ex_Heranca.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 100, 0.2));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Thiago", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Bruna", 500, 500));

            double sum = 0.0;
            foreach (Account acc in list)
            {

                sum += acc.Balance;

            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");


            foreach (Account acc in list)
            {

                acc.Withdraw(10.00);

            }

            foreach (Account acc in list)
            {

                Console.WriteLine($"Update Balance: {acc.Number} : {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

            }

        }
    }
}
