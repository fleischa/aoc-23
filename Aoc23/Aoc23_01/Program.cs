internal class Program
{
	public static async Task Main(string[] args)
	{
		await Program.Part1();
		await Program.Part2();
	}

	private static async Task Part1()
	{
		using StreamReader reader = File.OpenText("input.txt");
		int calibration = 0;
		while (await reader.ReadLineAsync() is { } line)
		{
			char[] digits = line.Where(char.IsDigit).ToArray();
			string number = $"{digits.First()}{digits.Last()}";
			calibration += int.Parse(number);
		}

		Console.WriteLine(calibration);
	}
	
	private static async Task Part2()
	{
		using StreamReader reader = File.OpenText("input.txt");
		int calibration = 0;
		while (await reader.ReadLineAsync() is { } line)
		{
			char[] digits = line.Where(char.IsDigit).ToArray();
			string number = $"{digits.First()}{digits.Last()}";
			calibration += int.Parse(number);
		}

		Console.WriteLine(calibration);
	}
}