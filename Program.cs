using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financial_budget_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Bi-Weekly Pay:");
            var biWeeklyPay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Rent:");
            var rent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Car Note payment:");
            var carNote = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Car Insurance payment:");
            var carInsurance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Internet bill:");
            var internetBill = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone bill:");
            var phoneBill = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Groceries:");
            var groceries = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.ReadLine();

            var totalBiWeeklyBill = rent + carNote + carInsurance + internetBill + phoneBill + groceries;

            // *DISCRETIONARY INCOME* is the amount of an individuals income that is left for spending, investing, or saving after paying taxes, food, rent, or bills

            var discretionaryIncome = biWeeklyPay - totalBiWeeklyBill;

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine(discretionaryIncome);

        }
    }
}
