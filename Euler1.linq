<Query Kind="Program" />

void Main()
{
	Console.Write(IntegersBelow(1000).Where (x => x%3 == 0 || x%5 ==0).Sum ());
}

// Define other methods and classes here

public static IEnumerable<int> IntegersBelow(int limit)
{
	for (int i = 1; i < limit; i++)
	{
		yield return i;
	}
}