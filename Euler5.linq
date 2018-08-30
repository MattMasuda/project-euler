<Query Kind="Program" />

void Main()
{
	//PrimesBelow(21).Dump();
	// This is incomplete.
	Console.Write(PrimesBelow(11).Aggregate ((a,b) => a * b ));
	
	
}

// Define other methods and classes here
public static IEnumerable<int> PrimesBelow(int limit)
{
	var numbers = new bool[limit];
	numbers[0] = true;
	numbers[1] = true;

	for (int i = 2; i < limit; i++)
	{
		if (numbers[i] == false)
		{
			// Mark all multiples of p
			for (int j = i * 2; j < limit; j += i)
			{
				numbers[j] = true;
			}
		}
	}
	
	for (int i = 2; i < limit; i++)
	{
		if (numbers[i] == false)
		{
			yield return i;
		}
	}
}