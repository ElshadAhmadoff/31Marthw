using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_2022_Homework
{
    internal static class Calculator
    {
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

     

        public static double Divide(int n1, int n2)
        {
            return (double)n1 / (double)n2;
        }


        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Pow(this int variable, int a)
        {
            int pow = 1;
            for (int i = 1; i <= a; i++)
            {
                pow = pow * variable;
            }
            return pow;
        }
    }
}
