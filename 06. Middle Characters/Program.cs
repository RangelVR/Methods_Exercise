using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMidlChar(input);
        }

        static void PrintMidlChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString());
            }
            else
            {
                Console.WriteLine(input[input.Length / 2].ToString());
            }
        }
        ================================================================================================
        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();
        //    PrintMidCharOfInput(input);
        //}

        //static void PrintMidCharOfInput(string input) 
        //{
        //    if (input.Length % 2 == 0)
        //    {
        //        GetMidCharIfLenghtEven(input);
        //    }
        //    else
        //    {
        //        GetMidCharIfLenghtNotEven(input);
        //    }
        //}

        //static void GetMidCharIfLenghtEven(string input)
        //{
        //    string midTwoChars = string.Empty;
        //    for (int i = (input.Length / 2) - 1; i <= input.Length / 2; i++)
        //    {
        //        midTwoChars += input[i];
        //    }
        //    Console.WriteLine(midTwoChars);
        //}

        //static void GetMidCharIfLenghtNotEven(string input)
        //{
        //    char midChar = input[(char)(input.Length / 2)];
        //    Console.WriteLine(midChar);
        //}
    }
}
