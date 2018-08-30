<Query Kind="Program" />

void Main()
{
	Triangles().First (x => Factorize(x).Count > 500).Dump();
	//Factorize(21).Dump();
}

// Define other methods and classes here
public static IEnumerable<int> Triangles()
{
	int triangle = 0;
	int index = 1;
	while(true)
	{
		triangle += index++;
		yield return triangle;
	}
}

public static IList<int> Factorize(int number)
{
	HashSet<int> factors = new HashSet<int>();
	factors.Add(1);
	for (int i = 2; i <= number / 2 ; i++)
	{
		if (number % i == 0)
		{
			if (factors.Contains(i)) break;

			factors.Add(i);
			factors.Add(number /i);
		}
	}
	factors.Add(number);
	return factors.ToList();
}