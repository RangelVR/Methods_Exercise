using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            PrintSequenceBetwinCh1AndCh2(ch1, ch2);
        }

        static void PrintSequenceBetwinCh1AndCh2(char ch1, char ch2)
        {
          
            int start = Math.Min(ch1, ch2);
            int stop = Math.Max(ch1, ch2);
            for (int i = start + 1; i < stop; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        ========================================================================================================
        //static void Main(string[] args)
        //{
        //    char ch1 = char.Parse(Console.ReadLine());
        //    char ch2 = char.Parse(Console.ReadLine());

        //    PrintSequenceBetwinCh1AndCh2(ch1, ch2);
        //}

        //static void PrintSequenceBetwinCh1AndCh2(char ch1, char ch2)
        //{
        //    if (ch1 > ch2)
        //    {
        //        for (int i = ch2 + 1; i < ch1; i++)
        //        {
        //            Console.Write((char)i + " ");
        //        }
        //    }
        //    else
        //    {
        //        for (int i = ch1 + 1; i < ch2; i++)
        //        {
        //            Console.Write((char)i + " ");
        //        }
        //    }
        //}

    }
}
