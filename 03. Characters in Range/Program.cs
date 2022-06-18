using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharsBetwin(begin, end);
        }

        static void PrintCharsBetwin(char start, char stop)
        {
            if (start > stop)
            {
                for (char i = (char)(stop + 1); i < start; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = (char)(start + 1); i < stop; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
        }

        //static void Main(string[] args)
        //{
        //    char startChar = char.Parse(Console.ReadLine());
        //    char stopChar = char.Parse(Console.ReadLine());

        //    PrintTheCharsBetweenTwoChars(startChar, stopChar);
        //}

        //static void PrintTheCharsBetweenTwoChars(char firstCharacter, char secondCharacter)
        //{

        //    int startCh = Math.Min(firstCharacter, secondCharacter);
        //    int stopCh = Math.Max(firstCharacter, secondCharacter);

        //    for (int i = ++startCh; i < stopCh; i++)
        //    {
        //        Console.Write((char)i + " ");
        //    }

        //}
    }
}
