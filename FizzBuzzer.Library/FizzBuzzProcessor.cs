using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearMeasureTest.FizzBuzz
{
    public class FizzBuzzProcessor : IFizzBuzzProcessor
    {
	    public IEnumerable<string> Process(int max)
	    {
		    return Enumerable.Range(1, max).Select(i =>
		    {
			    if (i % 3 == 0 && i % 5 == 0)
			    {
				    return "fizzbuzz";
			    }

			    if (i % 3 == 0)
			    {
				    return "fizz";
			    }

			    if (i % 5 == 0)
			    {
				    return "buzz";
			    }

			    return $"{i}";
			});
	    }
	}
}
