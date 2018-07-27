using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzer.Library
{
    public class FizzBuzzGenerator : IFizzBuzzGenerator
    {
		private readonly IEnumerable<(int, string)> _defaultPairs = new []{ (3, "fizz"), (5, "buzz") } ;
	    public IEnumerable<string> Generate(int max)
	    {
		    return Generate(max, Enumerable.Empty<(int, string)>());
	    }

	    public IEnumerable<string> Generate(int max, IEnumerable<(int, string)> pairs)
	    {
		    var allPairs = _defaultPairs.Union(pairs);
		    return Enumerable.Range(1, max).Select(i =>
		    {
			    var matches = allPairs.Where(x => i % x.Item1 == 0);
			    if (matches.Any())
			    {
				    return string.Join("", matches.Select(x => x.Item2));
			    }

			    return $"{i}";
		    });
	    }
	}
}
