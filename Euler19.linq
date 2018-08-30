<Query Kind="Program" />

void Main()
{
	int count = 0;
	var time = new DateTime(1901, 01, 01);
	var end = new DateTime(2000, 12, 31);
	while (time <= end)
	{
		if (time.DayOfWeek == DayOfWeek.Sunday) count += 1;
		time = time.AddMonths(1);
	}
	
	Console.WriteLine(count);
}

// Define other methods and classes here
