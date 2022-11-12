using System;

namespace _10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopN = int.Parse(Console.ReadLine());

            for (int i = 17; i <= stopN; i++)
            {
                PrintTopNum(i);
            }
        }

        static void PrintTopNum(int i)
        {
            if (GetSumOfN(i) == 8 || GetSumOfN(i) % 8 == 0)
            {
                if (GetCountOdd(i) > 0)
                {
                    int topN = i;
                    Console.WriteLine(topN);
                }
            }
        }

        static int GetSumOfN(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }

        static int GetCountOdd(int i)
        {
            int counter = 0;
            while (i != 0)
            {
                int lastDigit = i % 10;
                if (lastDigit % 2 != 0)
                {
                    counter++;
                }
                i = i / 10;
            }
            return counter;
        }
    }
}
----------------------------------------------------------------------------------------
    
//using System;
//using System.Linq;

//namespace _10._Top_Number
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string num = Console.ReadLine();
//            GetSumOdDigits(num);
//        }

//        static void GetSumOdDigits(string num)
//        {
//            for (int i = 17; i <= int.Parse(num); i++)
//            {
//                string lenght = i.ToString();
//                int[] arr = new int[lenght.Length];
//                bool isOddDigit = false;

//                for (int k = 0; k < arr.Length; k++)
//                {
//                    string digit = i.ToString();
//                    arr[k] = digit[k] - '0';
//                }
//                int sum = arr.Sum();

//                foreach (var digit in arr)
//                {
//                    if (digit % 2 != 0)
//                    {
//                        isOddDigit = true;
//                        break;
//                    }
//                }

//                if (sum % 8 == 0)
//                {
//                    if (isOddDigit)
//                    {
//                        Console.WriteLine(i);
//                    }
//                }

//            }
//        }
//    }
//}
 ======================================================================================================================
    
//using System;
//using System.Linq;

//namespace _10._Top_Number
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = int.Parse(Console.ReadLine());
//            PrintTopNum(num);
//        }

//        static void PrintTopNum(int num)
//        {
//            for (int i = 17; i <= num; i++)
//            {
//                if (GetSumDigits(i))
//                {
//                    if (IsOddNumber(i))
//                    {
//                        Console.WriteLine(i);
//                    }
//                }
//            }
//        }

//        static bool GetSumDigits(int num)
//        {
//            int sumDigits = 0;
//            while (num != 0)
//            {
//                sumDigits += num % 10;
//                num /= 10;
//            }
//            if (sumDigits % 8 == 0)
//            {
//                return true;
//            }
//            return false;
//        }

//        static bool IsOddNumber(int i)
//        {
//            for (int k = i; k <= i; k++)
//            {
//                int oddNum = 0;
//                while (i != 0)
//                {
//                    oddNum += i % 10;
//                    i /= 10;
//                    if (i % 2 != 0)
//                    {
//                        return true;
//                    }
//                }
//            }
//            return false;
//        }

//    }
//}
