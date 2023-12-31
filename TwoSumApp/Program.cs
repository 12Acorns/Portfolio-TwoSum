internal class Program
{
	private static void Main(string[] args)
	{
		ReadOnlySpan<int> _input = new Span<int>(new int[4]
		{
			2, 7, 11, 15
		});

		int[] _result = TwoSumSorted(_input, 9);

		if(_result.Length <= 0)
		{
			return;
		}

		Console.WriteLine(_result[0]);
		Console.WriteLine(_result[1]);
		Console.ReadLine();
	}

	private static int[] TwoSumSorted(ReadOnlySpan<int> _inputNumbers, int _target)
	{
		if(_inputNumbers.Length <= 0)
		{
			return [];
		}
		for(int i = 0; i < _inputNumbers.Length; i++)
		{
			int _result = _target - _inputNumbers[i];
			if(_result < 0) // Know any array element past will also be negative result.
			{
				break;
			}
			int _index = _inputNumbers.BinarySearch(_result);
			if(_index < 0)
			{
				continue;
			}
			return [i, _index];
		}
		return [];
	}
}