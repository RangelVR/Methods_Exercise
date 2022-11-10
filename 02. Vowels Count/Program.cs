using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            GetCountVowels(input);
        }

        static void GetCountVowels(string input) 
        {
            int countVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        countVowels++;
                        break;
                }
            }
            Console.WriteLine(countVowels);
        }
        -----------------------------------------------------------------------------------------
        //        static void Main(string[] args)
        //        {
        //            string input = Console.ReadLine();

        //            Console.WriteLine(PrintVowels(input));

        //        }

        //        static int PrintVowels(string input)
        //        {
        //            char[] arrVowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        //            int countVowels = 0;

        //            foreach (var ch in input.ToLower())
        //            {
        //                if (arrVowels.Contains(ch))
        //                {
        //                    countVowels++;
        //                }
        //            }
        //            return countVowels;
        //        }
            
        ------------------------------------------------------------------------------------------------------
            
        //static void Main(string[] args)
        //{
        //    string inputStr = Console.ReadLine();
        //    PrintCountVowels(inputStr);
        //}

        //static void PrintCountVowels(string input)
        //{
        //    int counterVowels = 0;
        //    foreach (var ch in input.ToLower())
        //    {
        //        if (ch == 'a' || ch == 'o' || ch == 'u' || ch == 'e' || ch == 'i')
        //        {
        //            counterVowels++;
        //        }
        //    }
        //    Console.WriteLine(counterVowels);
        //}
    }
}
