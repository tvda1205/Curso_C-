﻿using Ex_Heranca.Entities;

namespace Ex_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            
            Console.WriteLine(account.Balance);
            account.Balance = 200.0; */


            Account acc = new Account(1001, "Alex", 500.0);

            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = new SavingsAccount(1004, "Anna", 500.0, 0);
            Account acc2 = new BusinessAccount(1003, "Bob", 500.0, 0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount) {

                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");

            }


            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
