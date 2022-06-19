using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                int[] exchArr = arr;
                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "exchange")
                {
                    GetExchange(arr, command, exchArr);
                }
                else if (command[0] == "max")
                {
                    GetMaxEvenOddIndex(arr, command);
                }
                else if (command[0] == "min")
                {
                    
                }
                else if (command[0] == "first")
                {
                    GetFirstEvenOdd(arr, command);
                }
                else if (command[0] == "last")
                {
                   
                }
            }
            Console.WriteLine($"[{string.Join(" ,", arr)}]");

        }

        static int[] GetExchange(int[] arr, string[] command, int[] exchArr)
        {
            int index = (int.Parse(command[1]));

            if (index >= arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int counter = 0;
                int[] firstHalf = new int[index + 1];
                int[] secondHalf = new int[arr.Length - firstHalf.Length];

                for (int i = 0 ; i <= index; i++)
                {
                    firstHalf[i] = arr[i];
                }
                for (int i = index + 1; i < arr.Length; i++)
                {
                    secondHalf[counter] = arr[i];
                    counter++;
                }
                for (int i = 0; i < secondHalf.Length; i++)
                {
                    exchArr[i] = secondHalf[i];
                }
                counter = 0;
                for (int i = secondHalf.Length; i < exchArr.Length; i++)
                {
                    exchArr[i] = firstHalf[counter];
                    counter++;
                }
            }
            arr = exchArr;
            return arr;
        }

        static void GetMaxEvenOddIndex(int[] arr, string[] command)
        {
            int index = 0;
            int counter = 0;
            string comm = command[1];
            if (comm == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int num = arr[i];
                    if (num % 2 == 0)
                    {
                        if (num.CompareTo(index) > 0)
                        {
                            index = i;
                            counter++;
                        }
                    }
                }
            }
            else if (comm == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int num = arr[i];
                    if (num % 2 != 0)
                    {
                        if (num.CompareTo(index) > 0)
                        {
                            index = i;
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetMinEvenIndex(int[] arr, string[] command)
        {
            int indexMinEven = 0;
            int counterMinEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num % 2 == 0)
                {
                    if (num.CompareTo(indexMinEven) < 0)
                    {
                        indexMinEven = i;
                        counterMinEven++;
                    }
                }
            }
            if (counterMinEven != 0)
            {
                Console.WriteLine(indexMinEven);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetMinOddIndex(int[] arr, string[] command)
        {
            int indexMinOdd = 0;
            int counterMinOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num % 2 != 0)
                {
                    if (num.CompareTo(indexMinOdd) < 0)
                    {
                        indexMinOdd = i;
                        counterMinOdd++;
                    }
                }
            }
            if (counterMinOdd != 0)
            {
                Console.WriteLine(indexMinOdd);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void GetFirstEvenOdd(int[] arr, string[] command)
        {
            int countCommand = int.Parse(command[1]);
            string comm = command[2];
            int[] arrEvOdd = new int[countCommand];
            int counter = 0;

            if (countCommand > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (comm == "even")
                    {
                        if (arr[i] % 2 == 0 && counter < countCommand)
                        {
                            arrEvOdd[counter] = arr[i];
                            counter++;
                        }
                    }
                    else if (comm == "odd")
                    {
                        if (arr[i] % 2 != 0 && counter < countCommand)
                        {
                            arrEvOdd[counter] = arr[i];
                            counter++;
                        }
                    }
                    
                }
                Console.Write("[");
                for (int i = 0; i < counter; i++)
                {
                    if (i < counter - 1)
                    {
                        Console.Write(arrEvOdd[i] + "," + " ");
                    }
                    else if (i == counter - 1)
                    {
                        Console.Write(arrEvOdd[i]);
                    }
                }
                Console.Write("]");
            }
            
        }


        static void GetLastEven(int[] arr, string[] command)
        {

        }

        static void GetLastOdd(int[] arr, string[] command)
        {

        }
    }
}
