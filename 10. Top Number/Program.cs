int number = int.Parse(Console.ReadLine());
for (int currNum = 17; currNum <= number; currNum++)
{
    if (IsAtLeastOneOddDigit(currNum))
    {
        if (IsTopNumber(currNum))
        {
            Console.WriteLine(currNum);
        }
    }
}


bool IsAtLeastOneOddDigit(int currNum)
{
    while (currNum > 0)
    {
        int isOddDigit = currNum % 10;
        if (isOddDigit % 2 != 0)
        {
            return true;
        }
        currNum /= 10;
    }

    return false;
}

bool IsTopNumber(int currNum)
{
    int sum = 0;
    while (currNum > 0)
    {
        sum += currNum % 10;
        currNum /= 10;
    }

    if (sum % 8 == 0)
    {
        return true;
    }

    return false;
}
