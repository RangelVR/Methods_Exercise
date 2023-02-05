while (true)
{
    string number = Console.ReadLine();

    if (number == "END")
    {
        break;
    }

    Console.WriteLine(GetReversedNumAndPrint(number).ToString().ToLower());
}


bool GetReversedNumAndPrint(string number)
{
    string revNumber = string.Empty;

    foreach (var item in number.Reverse())
    {
        revNumber += item;
    }

    if (revNumber == number)
    {
        return true;
    }

    return false;
}



//string n;
//while ((n = Console.ReadLine()) != "END")
//{
//    Console.WriteLine(PrintTrueOrFalse(n));
//}

//static bool PrintTrueOrFalse(string n)
//{
//    string reversedNum = string.Empty;
//    bool result = false;

//    for (int i = n.Length - 1; i >= 0; i--)
//    {
//        reversedNum += n[i];
//    }
//    if (n == reversedNum)
//    {
//        result = true;
//    }

//    return result;
//}
