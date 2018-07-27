using System.Collections.Generic;

namespace FizzBuzzer.Library
{
	public interface IFizzBuzzGenerator
	{
		IEnumerable<string> Generate(int max);

		IEnumerable<string> Generate(int max, IEnumerable<(int, string)> pairs);
	}
}