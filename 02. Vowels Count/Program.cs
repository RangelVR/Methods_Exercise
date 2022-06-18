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
    }
}
