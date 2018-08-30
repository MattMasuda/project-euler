<Query Kind="Program" />

void Main()
{
	var sumOfSquares = IntegersBelow(101).Select (x => x*x).Sum();
	var sums = IntegersBelow(101).Sum();
	Console.Write(sums * sums - sumOfSquares);
}

// Define other methods and classes here
public static IEnumerable<int> IntegersBelow(int limit)
{
	for (int i = 1; i < limit; i++)
	{
		yield return i;
	}
}