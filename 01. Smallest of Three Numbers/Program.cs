using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMinValue(n1, n2, n3));
        }

        static int GetMinValue(int n1, int n2, int n3)
        {
            int minValue = n1;
            if (n2 < minValue)
            {
                minValue = n2;
            }
            if (n3 < minValue)
            {
                minValue = n3;
            }
            return minValue;
        }
------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    int num3 = int.Parse(Console.ReadLine());

        //    Console.WriteLine(GetMinValue(num1, num2, num3));
        //}

        //static int GetMinValue(int num1, int num2, int num3)
        //{
        //    int[] allNums = { num1, num2, num3 };
        //    int minValue = allNums[0];
        //    foreach (var num in allNums)
        //    {
        //        if (num < minValue)
        //        {
        //            minValue = num;
        //        }
        //    }
        //    return minValue;
        //}
-------------------------------------------------------------------------------------------------

        //static void Main(string[] args)
        //{
        //    int[] arr = new int[3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int n = int.Parse(Console.ReadLine());
        //        arr[i] = n;
        //    }
        //    GetSmolestNum(arr);
        //}

        //static void GetSmolestNum(int[] arr)
        //{
        //    int smolestNum = int.MaxValue;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (arr[i] < smolestNum)
        //        {
        //            smolestNum = arr[i];
        //        }
        //    }
        //    Console.WriteLine(smolestNum);
        //}



    }
}
