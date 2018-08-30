<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	Console.WriteLine(GetDigits(Factorial(100)).Sum ());
}

// Define other methods and classes here
public BigInteger Factorial(BigInteger number)
{
	BigInteger total = 1;
	for (int i = 2; i <= number; i++)
	{
		total = total * i;
	}
	return total;
}

public IEnumerable<int> GetDigits(BigInteger number)
{
	foreach (var digit in number.ToString())
	{
		yield return Convert.ToInt32(digit) - 48;
	}
}