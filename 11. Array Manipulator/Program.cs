int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("exchange"))
    {
        GetExchangeIndex(command, ref array);
    }
    else if (command.StartsWith("max"))
    {
        GetMaxIndexEvenOrOdd(command, array);
    }
    else if (command.StartsWith("min"))
    {
        GetMinIndexEvenOrOdd(command, array);
    }
    else if (command.StartsWith("first"))
    {
        GetCountOfFirsEvenOrOdNumbers(command, array);
    }
    else if (command.StartsWith("last"))
    {
        GetCountOfLastEvenOrOdNumbers(command, array);
    }
    command = Console.ReadLine();
}

Console.WriteLine("[{0}]", string.Join(", ", array));



void GetExchangeIndex(string command, ref int[] array)
{
    int index = int.Parse(command.Split().Last());
    if (index >= 0 && index < array.Length)
    {
        int[] newArr = array.Skip(index + 1).Take(array.Length).Concat(array.Take(index + 1)).ToArray();
        array = newArr;
    }
    else
    {
        Console.WriteLine("Invalid index");
    }
}

void GetMaxIndexEvenOrOdd(string command, int[] array)
{
    if (command.Split().Last() == "even")
    {
        if (!array.Any(x => x % 2 == 0))
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int maxNum = array.Where(x => x % 2 == 0).Max();
            Console.WriteLine(Array.LastIndexOf(array, maxNum));
        }
    }
    else if (command.Split().Last() == "odd")
    {
        if (!array.Any(x => x % 2 != 0))
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int maxNum = array.Where(x => x % 2 != 0).Max();
            Console.WriteLine(Array.LastIndexOf(array, maxNum));
        }
    }
}

void GetMinIndexEvenOrOdd(string command, int[] array)
{
    if (command.Split().Last() == "even")
    {
        if (!array.Any(x => x % 2 == 0))
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int minNum = array.Where(x => x % 2 == 0).Min();
            Console.WriteLine(Array.LastIndexOf(array, minNum));
        }
    }
    else if (command.Split().Last() == "odd")
    {
        if (!array.Any(x => x % 2 != 0))
        {
            Console.WriteLine("No matches");
        }
        else
        {
            int minNum = array.Where(x => x % 2 != 0).Min();
            Console.WriteLine(Array.LastIndexOf(array, minNum));
        }
    }
}

void GetCountOfFirsEvenOrOdNumbers(string command, int[] array)
{
    string[] commArr = command.Split().ToArray();
    int count = int.Parse(commArr[1]);

    if (count > array.Length)
    {
        Console.WriteLine("Invalid count");
    }
    else
    {
        if (command.Split().Last() == "even")
        {
            int[] result = array.Where(x => x % 2 == 0).Take(count).ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
        else if (command.Split().Last() == "odd")
        {
            int[] result = array.Where(x => x % 2 != 0).Take(count).ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}

void GetCountOfLastEvenOrOdNumbers(string command, int[] array)
{
    string[] commArr = command.Split().ToArray();
    int count = int.Parse(commArr[1]);

    if (count > array.Length)
    {
        Console.WriteLine("Invalid count");
    }
    else
    {
        if (command.Split().Last() == "even")
        {
            int[] result = array.Where(x => x % 2 == 0).TakeLast(count).ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
        else if (command.Split().Last() == "odd")
        {
            int[] result = array.Where(x => x % 2 != 0).TakeLast(count).ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }

}
