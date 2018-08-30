<Query Kind="Program" />

void Main()
{
	int longestNumber = 0;
	int longestLength = 0;
	foreach (var number in IntegersBelow(1000000))
	{
		var numbers = CollatzChain(number);
		var length = numbers.Count ();
		//Console.WriteLine("{0} => {1}", number, length);
		if (length >= longestLength)
		{
			longestNumber = number;
			longestLength = length;
		}
	}
	Console.Write(longestNumber);
}

// Define other methods and classes here

public static IEnumerable<long> CollatzChain(int n)
{
	while (n > 1)
	{
		yield return n;
		if (n % 2 == 0)
		{
			n = n/2;
		}
		else
		{
			n = 3 * n + 1;
		}
	}
	yield return 1;
}

public static IEnumerable<int> IntegersBelow(int limit)
{
	for (int i = 1; i < limit; i++)
	{
		yield return i;
	}
}