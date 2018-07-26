using System.Linq;
using ClearMeasureTest.FizzBuzz;
using NUnit.Framework;

namespace ClearMeasureTest.UnitTest
{
	[TestFixture]
	public class FizzBuzzProcessorTests
	{
		[Test]
		public void Processor_ValueMatchesThreeAndFiveCase_ReturnsBoth()
		{
			// arrange
			var processor = new FizzBuzzProcessor();
			var max = 15;

			// act
			var results = processor.Process(max);

			// assert
			Assert.AreEqual("fizzbuzz", results.Last());
		}
	}
}
