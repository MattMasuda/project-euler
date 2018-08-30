<Query Kind="Program" />

void Main()
{
	int count = 0;
	for (int i = 1; i <= 1000; i++)
	{
		count += GetWords(i).ToCharArray().Count ();
	}
	Console.WriteLine(count);
}

// Define other methods and classes here

public string GetWords(int number)
{
	string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
	string [] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

	bool hasThousandsOrHundreds = false;
	
	var builder = new StringBuilder();
	// > 9999 not supported
	if (number > 9999) throw new ArgumentException("Number too large");
	// if > 999  
	if (number > 999)
	{
		// find thousands 
		var thousands = number / 1000;
		builder.Append(numbers[thousands]);
		builder.Append("thousand");
		number = number - (thousands * 1000);
		hasThousandsOrHundreds = true;
	}
	// if > 99
	if (number > 99)
	{
		// find hundreds
		var hundreds = number / 100;
		builder.Append(numbers[hundreds]);
		builder.Append("hundred");
		number = number - (hundreds * 100);
		hasThousandsOrHundreds = true;
	}
	
	// is anything left?
	if (hasThousandsOrHundreds && number > 0)
	{
		builder.Append("and");
	}
	
	// if > 19
	if (number > 19)
	{
		// find tens
		var ten = number / 10;
		builder.Append(tens[ten-2]);
		number = number - (ten * 10);
	}
	
	if (number > 0)
	{
		builder.Append(numbers[number]);
	}
	return builder.ToString();
}