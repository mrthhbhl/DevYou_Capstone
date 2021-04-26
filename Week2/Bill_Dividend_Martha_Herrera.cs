using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Dividend_Martha_Herrera
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the total of your bill?");
            decimal bill = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many people are paying for the total bill?");
            decimal total = Decimal.Parse(Console.ReadLine());

            decimal bill_dividend = bill/total;
            string formattedMoneyValue = String.Format("{0:C}", bill_dividend);

            Console.WriteLine($"Each person owes {formattedMoneyValue}");
            Console.ReadLine();
        }
    }
}
