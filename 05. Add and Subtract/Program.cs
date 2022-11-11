using System;
using System.Linq;

namespace _05. Add and Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            GetSumOfN1AndN2(n1, n2);
            Console.WriteLine(GetSubstractN3(n1, n2, n3));
        }

        static int GetSubstractN3(int n1, int n2, int n3)
        {
            int result = GetSumOfN1AndN2(n1, n2) - n3;
            return result;
        }

        static int GetSumOfN1AndN2(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        //================================================================================================================
        //static void Main(string[] args)
        //{
        //    int n1 = int.Parse(Console.ReadLine());
        //    int n2 = int.Parse(Console.ReadLine());
        //    int n3 = int.Parse(Console.ReadLine());
        //    PrintResult(n1, n2, n3);
        //}

        //static void PrintResult(int n1, int n2, int n3)
        //{
        //    int sum = n1 + n2 - n3;
        //    Console.WriteLine(sum);
        //}

    }
}
