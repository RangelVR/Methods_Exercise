using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            while ((n = Console.ReadLine()) != "END")
            {
                Console.WriteLine(PrintTrueOrFalse(n));
            }
        }

        static bool PrintTrueOrFalse(string n)
        {
            string reversedNum = string.Empty;
            bool result = false;

            for (int i = n.Length - 1; i >= 0; i--)
            {
                reversedNum += n[i];
            }
            if (n == reversedNum)
            {
                result = true;
            }

            return result;
        }
    }
}
