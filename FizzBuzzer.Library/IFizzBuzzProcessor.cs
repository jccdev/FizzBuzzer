using System.Collections.Generic;

namespace FizzBuzzer.Library
{
	public interface IFizzBuzzProcessor
	{
		IEnumerable<string> Process(int max);
	}
}