<Query Kind="Program" />

void Main()
{
	//Console.Write(IsPalindrome(10102));
	ProductsOf(1000,1000).Distinct().OrderByDescending(x=>x).First (x => IsPalindrome(x)).Dump();
	//ProductsOf(1000,1000).Distinct().OrderByDescending (x => x).Dump();
}

// Define other methods and classes here
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