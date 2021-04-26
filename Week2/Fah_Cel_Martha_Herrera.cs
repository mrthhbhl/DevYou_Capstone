using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current weather in fahrenheit?");
            int fah = Int32.Parse(Console.ReadLine());
            int cel = (fah - 32) * 5 / 9;

            Console.WriteLine($"{fah} in Fahrenheit is equivalent to {cel} in Celcius");
            Console.ReadLine();
        }
    }
}
