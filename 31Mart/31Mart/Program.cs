using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Calculator.Sum(n1, n2));
            Console.WriteLine(Calculator.Multiply(n1, n2));
            Console.WriteLine(Calculator.Divide(n1, n2));
            Console.WriteLine(Calculator.Subtract(n1, n2));
            Console.WriteLine(n1.Pow(n2));
            Console.ReadLine();
        }
    }
}
