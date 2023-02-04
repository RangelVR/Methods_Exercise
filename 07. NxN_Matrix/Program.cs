int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    GerRowOfN(n);
}


void GerRowOfN(int n)
{
	for (int i = 0; i < n; i++)
	{
		Console.Write("{0} ", n);
	}
	Console.WriteLine();
}
