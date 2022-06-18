using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            PringtResult(n1, n2);
        }

        static void PringtResult(decimal n1, decimal n2) 
        {
            decimal sum1 = 1;
            decimal sum2 = 1;
            
            if (n1 != 0 && n2 != 0)
            {
                for (decimal i = 1; i < n1; i++)
                {
                    sum1 *= i + 1;
                }
                for (decimal i = 1; i < n2; i++)
                {
                    sum2 *= i + 1;
                }
                Console.WriteLine($"{(sum1 / sum2):f2}");
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
