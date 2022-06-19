using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTopNum(num);
        }

        static void PrintTopNum(int num)
        {
            for (int i = 17; i <= num; i++)
            {
                if (GetSumDigits(i))
                {
                    if (IsOddNumber(i))
                    {
                        Console.WriteLine(i);
                    }
                  
                }
            }
        }

        static bool GetSumDigits(int num)
        {
            int sumDigits = 0;
            while (num != 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }
            if (sumDigits % 8 == 0)
            {
                return true;
            }
            return false;

        }

        static bool IsOddNumber(int i)
        {
            for (int k = i; k <= i; k++)
            {
                int oddNum = 0;
                while (i != 0)
                {
                    oddNum += i % 10;
                    i /= 10;
                    if (i % 2 != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
