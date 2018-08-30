<Query Kind="Program" />

void Main()
{
	Triplets(1000).Where (x => x.Item1 * x.Item1 + x.Item2 * x.Item2 == x.Item3 * x.Item3).Where (x => x.Item1 + x.Item2 + x.Item3 == 1000).Dump();
}

// Define other methods and classes here
public static IEnumerable<Tuple<int, int, int>> Triplets(int max)
{
	for (int i = 1; i < max; i++)
	{
		for (int j = 1; j < max; j++)
		{
			for (int k = 1; k < max; k++)
			{
				yield return new Tuple<int, int, int>(i, j, k);
			}
		}
	}
}