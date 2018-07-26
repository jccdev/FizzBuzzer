using System.Linq;
using FizzBuzzer.Library;
using NUnit.Framework;

namespace FizzBuzzer.UnitTest
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
