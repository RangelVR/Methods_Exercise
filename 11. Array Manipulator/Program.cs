using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            if (command == "end")
            {
                Console.WriteLine($"[{string.Join(", ", numbers)}]");
            }
            else
            {
                while (command != "end")
                {
                    string[] commandOfAll = command.Split();
                    string mainComm = commandOfAll[0];

                    if (mainComm == "exchange")
                    {
                        int index = int.Parse(commandOfAll[1]);
                        if (index >= 0 && index <= numbers.Length - 1)
                        {
                            GetEchangeNums(index, numbers);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                    }
                    else if (mainComm == "max")
                    {
                        string subCommEvenOrOdd = commandOfAll[1];
                        Console.WriteLine(PrintMaxIndexIvenOrOdd(subCommEvenOrOdd, numbers));
                    }
                    else if (mainComm == "min")
                    {
                        string subCommEvenOrOdd = commandOfAll[1];
                        Console.WriteLine(PrintMinIndexIvenOrOdd(subCommEvenOrOdd, numbers));
                    }
                    else if (mainComm == "first")
                    {
                        int count = int.Parse(commandOfAll[1]);
                        string commEvenOrOdd = commandOfAll[2];
                        PrintFirstCountEvenOrOddNums(count, commEvenOrOdd, numbers);
                    }
                    else if (mainComm == "last")
                    {
                        int count = int.Parse(commandOfAll[1]);
                        string commEvenOrOdd = commandOfAll[2];
                        PrintLastCountEvenOrOddNums(count, commEvenOrOdd, numbers);
                    }
                    command = Console.ReadLine();
                }
                
                Console.WriteLine($"[{string.Join(", ", numbers)}]");
                
            }
            
        }


        static void GetEchangeNums(int index, int[] numbers)
        {
            int[] firstHalfOfNums = new int[index + 1];
            int counter = numbers.Length - firstHalfOfNums.Length;

            for (int i = 0; i <= index; i++)
            {
                firstHalfOfNums[i] = numbers[i]; 
            }
            for (int j = 0; j <= index; j++)
            {
                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    numbers[k] = numbers[k + 1];
                }
            }
            for (int i = 0; i < firstHalfOfNums.Length; i++)
            {
                numbers[counter] = firstHalfOfNums[i];
                counter++;
            }
           
        }


        static string PrintMaxIndexIvenOrOdd(string subCommand, int[] numbers) 
        {
            if (subCommand == "even")
            {
                int maxNum = int.MinValue;
                int indexMaxNum = -1;
                bool index = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int num = numbers[i];
                    if (num % 2 == 0)
                    {
                        if (num >= maxNum)
                        {
                            maxNum = num;
                            indexMaxNum = i;
                            index = true;
                        }
                    }
                }
                if (index)
                {
                    return indexMaxNum.ToString();
                }
            }
            else if (subCommand == "odd")
            {
                int maxNum = int.MinValue;
                int indexMinNum = -1;
                bool index = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int num = numbers[i];
                    if (num % 2 != 0)
                    {
                        if (num >= maxNum)
                        {
                            maxNum = num;
                            indexMinNum = i;
                            index = true;
                        }
                    }
                }
                if (index)
                {
                    return indexMinNum.ToString();
                }
            }
            return "No matches";
        }


        static string PrintMinIndexIvenOrOdd(string subCommand, int[] numbers)
        {
            if (subCommand == "even")
            {
                int minNum = int.MaxValue;
                int indexOfMinNum = -1;
                bool index = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int num = numbers[i];
                    if (num % 2 == 0)
                    {
                        if (num <= minNum)
                        {
                            minNum = num;
                            indexOfMinNum = i;
                            index = true;
                        }
                    }
                }
                if (index)
                {
                    return indexOfMinNum.ToString();
                }
            }
            else if (subCommand =="odd")
            {
                int minNum = int.MaxValue;
                int indexOfMinNum = -1;
                bool index = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int num = numbers[i];
                    if (num % 2 != 0)
                    {
                        if (num <= minNum)
                        {
                            minNum = num;
                            indexOfMinNum = i;
                            index = true;
                        }
                    }
                }
                if (index)
                {
                    return indexOfMinNum.ToString();
                }
            }
            return "No matches";
        }


        static void PrintFirstCountEvenOrOddNums(int count, string commEvOrOdd, int[] numbers)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (commEvOrOdd == "even")
                {
                    int counter = 0;
                    int[] evenNums = new int[count];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int num = numbers[i];
                        if (num % 2 == 0)
                        {
                            if (counter < count)
                            {
                                evenNums[counter] = num;
                                counter++;
                            }
                        }
                    }

                    PrintCountEvenOrOdNums(counter, evenNums);
                }
                else if (commEvOrOdd == "odd")
                {
                    int counter = 0;
                    int[] oddNums = new int[count];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int num = numbers[i];
                        if (num % 2 != 0)
                        {
                            if (counter < count)
                            {
                                oddNums[counter] = num;
                                counter++;
                            }
                        }
                    }

                    PrintCountEvenOrOdNums(counter, oddNums);
                }

            }
        }


        static void PrintLastCountEvenOrOddNums(int count, string commEvenOrOdd, int[] numbers) 
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (commEvenOrOdd == "even")
                {
                    int counter = 0;
                    int[] evenNums = new int[count];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int num = numbers[i];
                        if (num % 2 == 0)
                        {
                            if (counter < count)
                            {
                                if (numbers.Sum() > 0)
                                {
                                    evenNums[counter] = numbers[i];
                                    counter++;
                                }
                                
                            }
                        }
                    }

                    PrintCountEvenOrOdNums(counter, evenNums);
                }
                else if (commEvenOrOdd == "odd")
                {
                    int counter = 0;
                    int[] oddNums = new int[count];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int num = numbers[i];
                        if (num % 2 != 0)
                        {
                            if (counter < count)
                            {
                                oddNums[counter] = numbers[i];
                                counter++;
                            }
                        }
                    }

                    PrintCountEvenOrOdNums(counter, oddNums);
                }
            }
        }


        static void PrintCountEvenOrOdNums(int counter, int[] evenOrOddnums) 
        {
            int counterOfNums = 0;

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < counter; i++)
                {
                    if (counterOfNums > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(evenOrOddnums[i]);
                    counterOfNums++;
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
