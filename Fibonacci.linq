<Query Kind="Program" />

void Main()
{
	Console.WriteLine(Fibonacci().TakeWhile (x => x < 4000000).Where (x => x%2 == 0).Sum ());
}

// Define other methods and classes here

public static IEnumerable<long> Fibonacci()
{
	long fib0 = 0;
	long fib1 = 1;
	long nextFib = 0;
	while (true)
	{
		yield return fib0;
		nextFib = fib0 + fib1;
		fib0 = fib1;
		fib1 = nextFib;
	}
}

public static IEnumerable<int> IntegersBelow(int limit)
{
	for (int i = 1; i < limit; i++)
	{
		yield return i;
	}
}

public static IEnumerable<long> PrimesBelow(long limit)
{
	var numbers = new bool[limit];
	numbers[0] = true;
	numbers[1] = true;

	for (long i = 2; i < limit; i++)
	{
		if (numbers[i] == false)
		{
			yield return i;
			// Mark all multiples of p
			for (long j = i * 2; j < limit; j += i)
			{
				numbers[j] = true;
			}
		}
	}
}

public static IEnumerable<int> ProductsOf(int num1, int num2)
{
	for (int  i= 1; i < num1; i++)
	{
		for (int j = 1; j < num2; j++)
		{
			yield return i * j;
		}
	}
}

public static bool IsPalindrome(int x)
{
	var numString = x.ToString().ToCharArray();
	var reverseString = numString.Reverse().ToArray();
	for (int i = 0; i < numString.Length; i++)
	{
		if (numString[i] != reverseString[i])
			return false;
	}
	return true;
}

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
	// The upper limit should be sqrt(number)
	// but doing number/2 and checking for factors.contains(i)
	// is faster
	for (int i = 2; i <= number /2 ; i++)
	{
		if (number % i == 0)
		{
			/* Optimization: Add both factors to the set of factors.
				If we get to a factor that is already in the set
				we know we're done because we've already found
				the factors that remain.
			*/
			if (factors.Contains(i)) break;

			factors.Add(i);
			factors.Add(number /i);
		}
	}
	factors.Add(number);
	return factors.ToList();
}