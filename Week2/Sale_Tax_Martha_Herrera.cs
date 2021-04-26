using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_Tax_Martha_Herrera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the cost of your product?");
            decimal cost = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("What is your sales tax?");
            decimal tax = Decimal.Parse(Console.ReadLine());

            decimal total = cost + tax / 100;
            string formattedMoneyValue = String.Format("{0:C}", total);

            Console.WriteLine($"Your total cost is {formattedMoneyValue}");
            Console.ReadLine();
        }
    }
}
