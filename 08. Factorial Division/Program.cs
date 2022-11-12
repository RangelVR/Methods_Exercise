using System;

namespace _08.Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
         
            Console.WriteLine($"{PrintFactorialN1(n1) / PrintFactorialN2(n2):f2}");
        }

        static decimal PrintFactorialN1(int n1) 
        {
            decimal sum1 = 1;
            for (int i = 2; i <= n1; i++)
            {
                sum1 *= i;
            }
            return sum1; 
        }

        static decimal PrintFactorialN2(int n2)
        {
            decimal sum2 = 1;
            for (int i = 2; i <= n2; i++)
            {
                sum2 *= i;
            }
            return sum2;
        }

    }
}
