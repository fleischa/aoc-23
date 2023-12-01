internal class Program
{
	private static readonly Dictionary<string, int> numbers;

	static Program()
	{
		Program.numbers = new Dictionary<string, int>()
		{
			{"0", 0},
			{"1", 1},
			{"2", 2},
			{"3", 3},
			{"4", 4},
			{"5", 5},
			{"6", 6},
			{"7", 7},
			{"8", 8},
			{"9", 9},
			{"zero", 0},
			{"one", 1},
			{"two", 2},
			{"three", 3},
			{"four", 4},
			{"five", 5},
			{"six", 6},
			{"seven", 7},
			{"eight", 8},
			{"nine", 9}
		};
	}
	
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
			string? keyFirst = Program.numbers.Keys.MinBy(k =>
			{
				int i = line.IndexOf(k, StringComparison.Ordinal);
				return i < 0 ? int.MaxValue : i;
			});
			string? keyLast = Program.numbers.Keys.MaxBy(k => line.LastIndexOf(k, StringComparison.Ordinal));
			calibration += Program.numbers[keyFirst] * 10 + Program.numbers[keyLast];
		}

		Console.WriteLine(calibration);
	}
}