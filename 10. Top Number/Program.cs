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
