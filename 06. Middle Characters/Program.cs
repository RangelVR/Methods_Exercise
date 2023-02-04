string input = Console.ReadLine();

if (input.Length % 2 == 0)
{
    PrintMiddleChar(input);
}
else
{
    PrintMiddleChars(input);
}



void PrintMiddleChar(string input)
{
    Console.Write(input[input.Length / 2 - 1]);
    Console.Write(input[input.Length / 2]);
}

void PrintMiddleChars(string input)
{
    Console.WriteLine(input[input.Length / 2]);
}

