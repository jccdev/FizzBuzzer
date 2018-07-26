using System.Collections.Generic;

namespace ClearMeasureTest.FizzBuzz
{
	public interface IFizzBuzzProcessor
	{
		IEnumerable<string> Process(int max);
	}
}