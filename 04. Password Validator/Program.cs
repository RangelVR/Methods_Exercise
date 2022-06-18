using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PrintAssessmentPass(password);
        }

        static void PrintAssessmentPass(string pass) 
        {
            int digitCount = 0;
            int digitOrLetter = 0;
            foreach (var ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                if (!char.IsDigit(ch) && !char.IsLetter(ch))
                {
                    digitOrLetter++;
                }               
            }

            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (digitOrLetter != 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (digitCount >= 2 && digitOrLetter == 0 && pass.Length >= 6 && pass.Length <= 10)
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}
