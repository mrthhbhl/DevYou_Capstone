using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Calc_Martha_Herrera
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your total bill?");
            decimal bill = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("What percentage would you like to tip?");
            decimal tip = Decimal.Parse(Console.ReadLine());

            decimal tip_calc = (tip / 100) * bill;
            string formattedMoneyValue = String.Format("{0:C}", tip_calc);
            
            Console.WriteLine($"Your total tip equals {formattedMoneyValue}");

            Console.ReadLine();

        }
    }
}
