using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace financial_budget_console_app_problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //This section of code below will be specifically for UI cosmetic changes
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Dictionary<string, int> billItems = new Dictionary<string, int>();   // example dictionary items = <phone bill, 101>, <rent, 800>

            var done = false;

            Console.WriteLine("Welcome To The Bi-Weekly Budget App!");
            Console.WriteLine("(***When your finish using the app, type exit to quit the program***)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            while (!done)
            {
                Console.WriteLine("Main Screen: Press Enter to Continue");
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Menu Options:");
                    Console.WriteLine("Enter Bills - Calculate Bill Payment - Display all Bills - Download Bill Report");
                    var userSelection = Console.ReadLine();
                    switch (userSelection)
                    {
                        case "Enter Bills":
                            var input1 = Console.ReadLine();
                            var done1 = false;

                            while (!done1)
                            {
                                if (input1 == "done")
                                {
                                    done1 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Bill name:");
                                    var billName = Console.ReadLine();

                                    Console.WriteLine("Payment");
                                    var billPayment = Convert.ToInt32(Console.ReadLine());

                                    billItems.Add(billName, billPayment);

                                    input1 = Console.ReadLine();
                                }
                            }
                            break;

                        case "Calculate Bill Payment":

                            var total = billItems.Sum(x => x.Value);
                            Console.WriteLine(total);

                            break;

                        case "Display all Bills":
                            foreach (var bill in billItems)
                            {
                                Console.WriteLine(bill.Key + " " + bill.Value);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            break;

                        case "Download Bill Report":
                            string path = @"C:\Users\qfjr\Desktop\bill_report.txt";

                            using (StreamWriter sw = File.AppendText(path))
                            {
                                sw.WriteLine("Bill Report - " + DateTime.Now);

                                foreach (var bill in billItems)
                                {
                                    sw.WriteLine();
                                    sw.WriteLine();
                                    sw.WriteLine();

                                    sw.WriteLine(bill.Key + " " + bill.Value);
                                }

                                var total1 = billItems.Sum(x => x.Value);
                                sw.WriteLine("Total Bill Amount: " + total1);
                            }
                            break;
                    }
                }
            }
        }
    }
}
