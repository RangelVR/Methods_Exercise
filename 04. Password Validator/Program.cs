string password = Console.ReadLine();

bool isValid = true;

if (!IsContainBetwin6And10Chars())
{
    Console.WriteLine("Password must be between 6 and 10 characters");
    isValid = false;
}
if (!IsOnlyLettersAndDigits())
{
    Console.WriteLine("Password must consist only of letters and digits");
    isValid = false;
}
if (!IsHaveAtLeast2Digits())
{
    Console.WriteLine("Password must have at least 2 digits");
    isValid = false;
}
if (isValid)
{
    Console.WriteLine("Password is valid");
}


bool IsContainBetwin6And10Chars()
{
    return password.Length >= 6 && password.Length <= 10;
}

bool IsOnlyLettersAndDigits()
{
    return password.All(char.IsLetterOrDigit);
}

bool IsHaveAtLeast2Digits()
{
    return password.Count(char.IsDigit) >= 2;
}
  =====================================================================================================================      
        //    string password = Console.ReadLine();
        //    bool charCount = true;
        //    bool letAndDig = true;
        //    bool countDig = true;
        //    ValidationCharactersCount(password, ref charCount);
        //    ValidationLettersAndDigits(password, ref letAndDig);
        //    ValidationCountDigits(password, ref countDig);

        //    if (charCount)
        //    {
        //        if (letAndDig)
        //        {
        //            if (countDig)
        //            {
        //                Console.WriteLine("Password is valid");
        //            }
        //        }
        //    }
        //}

        //static void ValidationCharactersCount(string password, ref bool charCount)
        //{
        //    if (password.Length < 6 || password.Length > 10)
        //    {
        //        Console.WriteLine("Password must be between 6 and 10 characters");
        //        charCount = false;
        //    }
        //}

        //static void ValidationLettersAndDigits(string password, ref bool letAndDig)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (!char.IsDigit(password[i]) && !char.IsLetter(password[i]))
        //        {
        //            Console.WriteLine("Password must consist only of letters and digits");
        //            letAndDig = false;
        //            break;
        //        }
        //    }
        //}

        //static void ValidationCountDigits(string password, ref bool countDig)
        //{
        //    int counterDigits = 0;
        //    foreach (var ch in password)
        //    {
        //        if (char.IsDigit(ch))
        //        {
        //            counterDigits++;
        //        }
        //    }
        //    if (counterDigits < 2)
        //    {
        //        Console.WriteLine("Password must have at least 2 digits");
        //        countDig = false;
        //    }
        //}
    }
}
=====================================================================================================================
    
//string password = Console.ReadLine();

//bool isValid = true;

//if (!ValidationBetwin6And10Chars(password, isValid))
//{
//    isValid = false;
//}
//if (!ValidationOnlyLettersAndDigits(password, isValid))
//{
//    isValid = false;
//}
//if (!ValidationAtLeast2Digits(password, isValid))
//{
//    isValid = false;
//}
//if (isValid)
//{
//    Console.WriteLine("Password is valid");
//}




//bool ValidationBetwin6And10Chars(string password, bool isValid)
//{
//    isValid = password.Length >= 6 && password.Length <= 10;

//    if (!isValid) 
//    {
//        Console.WriteLine("Password must be between 6 and 10 characters");
//        return false;
//    }

//    return true;
//}

//bool ValidationOnlyLettersAndDigits(string password, bool isValid)
//{
//    isValid = password.All(char.IsLetterOrDigit);

//    if (!isValid)
//    {
//        Console.WriteLine("Password must consist only of letters and digits");
//        return false;
//    }

//    return true;
//}

//bool ValidationAtLeast2Digits(string password, bool isValid)
//{
//    isValid = password.Count(char.IsDigit) >= 2;

//    if (!isValid)
//    {
//        Console.WriteLine("Password must have at least 2 digits");
//        return false;
//    }

//    return true;
//}

=====================================================================================================================
//string password = Console.ReadLine();
//PrintAssessmentPass(password);

//static void PrintAssessmentPass(string pass)
//{
//    int digitCount = 0;
//    int digitOrLetter = 0;
//    foreach (var ch in pass)
//    {
//        if (char.IsDigit(ch))
//        {
//            digitCount++;
//        }
//        if (!char.IsDigit(ch) && !char.IsLetter(ch))
//        {
//            digitOrLetter++;
//        }
//    }

//    if (pass.Length < 6 || pass.Length > 10)
//    {
//        Console.WriteLine("Password must be between 6 and 10 characters");
//    }
//    if (digitOrLetter != 0)
//    {
//        Console.WriteLine("Password must consist only of letters and digits");
//    }
//    if (digitCount < 2)
//    {
//        Console.WriteLine("Password must have at least 2 digits");
//    }
//    if (digitCount >= 2 && digitOrLetter == 0 && pass.Length >= 6 && pass.Length <= 10)
//    {
//        Console.WriteLine("Password is valid");
//    }

//}
