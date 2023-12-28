using System;
using System.Globalization;
using System.Threading;

namespace TestGlobalization
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DateTime startDate, finishDate;
                TimeSpan workingTime;
                int workingDays, taxRate;
                Decimal salaryRate, netIncome, grossSalary, taxDeduction;
                CultureInfo ci = null;
                Console.WriteLine("Please select your country:");
                Console.WriteLine("\n");
                Console.WriteLine("a) USA \tb) Canada");
                Console.WriteLine("c) UK  \td) Brasil");
                Console.WriteLine("\n");
                ConsoleKeyInfo option = Console.ReadKey(true);
                switch (option.Key) { 
                    case ConsoleKey.A:
                        ci = new CultureInfo("en-US");
                        break;
                    case ConsoleKey.B:
                        ci = new CultureInfo("fr-CA");
                        break;
                    case ConsoleKey.C:
                        ci = new CultureInfo("en-GB");
                        break;
                    case ConsoleKey.D:
                        ci = new CultureInfo("pt-BR");
                        break;
                    default:
                        ci = Thread.CurrentThread.CurrentCulture;
                        break;
                }
                Thread.CurrentThread.CurrentCulture = ci;
                Console.Write("Start date: ");
                startDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Finish date: ");
                finishDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Salary rate: ");
                salaryRate = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Tax rate %: ");
                taxRate = Convert.ToInt32(Console.ReadLine());
                workingTime = finishDate - startDate;
                workingDays = workingTime.Days;
                grossSalary = workingDays * salaryRate;
                taxDeduction = grossSalary * Convert.ToDecimal(taxRate * .01);
                netIncome = grossSalary - taxDeduction;
                Console.WriteLine("\n");
                Console.WriteLine("Start date:   \t{0:D}", startDate);
                Console.WriteLine("Finish date:  \t{0:D}", finishDate);
                Console.WriteLine("Working days: \t{0:N}", workingDays);
                Console.WriteLine("Gross Salary: \t{0:C}", grossSalary);
                Console.WriteLine("Net income:   \t{0:C}", netIncome);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}