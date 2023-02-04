int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int sum = 0;

GetSumN1AndN2(n1, n2, ref sum);
Console.WriteLine(GetSubstractN3(n3, sum));


int GetSumN1AndN2(int n1, int n2, ref int sum)
{
    sum = n1 + n2;
    return sum;
}

int GetSubstractN3(int n3, int sum)
{
    return sum - n3;
}
