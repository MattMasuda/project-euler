<Query Kind="Program" />

void Main()
{
	var number = 600851475143;
	var root = (int)Math.Sqrt(number);
	var primes = PrimesBelow(root);
	Console.WriteLine(primes.Reverse().First (x => number%x == 0));
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