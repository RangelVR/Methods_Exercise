int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{(GetFactorialN1(n1) / GetFactorialN2(n2)):f2}");



decimal GetFactorialN1(int n1)
{
    decimal factorialN1 = 1;
    while (n1 > 0)
    {
        factorialN1 *= n1;
        n1--;
    }
    return factorialN1;
}

decimal GetFactorialN2(int n2)
{
    decimal factorialN2 = 1;
    while (n2 > 0)
    {
        factorialN2 *= n2;
        n2--;
    }
    return factorialN2;
}
