namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            PrintTheSmallestOne(n1, n2, n3);
        }

        static void PrintTheSmallestOne(int n1, int n2, int n3)
        {
            if (n1 <= n2 && n1 <= n3)
            {
                Console.WriteLine(n1);
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }
        }
    }
}
-----------------------------------------------------

//namespace _01._Smallest_of_Three_Numbers
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n1 = int.Parse(Console.ReadLine());
//            int n2 = int.Parse(Console.ReadLine());
//            int n3 = int.Parse(Console.ReadLine());

//            PrintTheSmallestOne(n1, n2, n3);
//        }

//        static void PrintTheSmallestOne(int n1, int n2, int n3)
//        {
//            int result = Math.Min(n1, Math.Min(n2, n3));
//            Console.WriteLine(result);
//        }
//    }
//}
-----------------------------------------------------

//namespace _01._Smallest_of_Three_Numbers
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[3];

//            for (int i = 0; i < 3; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            PrintTheSmallestOne(arr);
//        }

//        static void PrintTheSmallestOne(int[] arr)
//        {
//            int minValue = int.MaxValue;

//            foreach (var num in arr)
//            {
//                if (num < minValue)
//                {
//                    minValue = num;
//                }
//            }

//            Console.WriteLine(minValue);
//        }
//    }
//}

