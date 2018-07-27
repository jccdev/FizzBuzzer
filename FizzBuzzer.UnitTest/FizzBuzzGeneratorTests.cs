using System.Linq;
using FizzBuzzer.Library;
using NUnit.Framework;

namespace FizzBuzzer.UnitTest
{
	[TestFixture]
	public class FizzBuzzGeneratorTests
	{
		[Test]
		public void Generate_NoMatch_ReturnsNumber()
		{
			// arrange
			var max = 1;
			var processor = new FizzBuzzGenerator();

			// act
			var results = processor.Generate(max);

			// assert
			Assert.AreEqual($"1", results.First());
		}

		[Test]
		public void Generate_CustomMatchPair_ReturnsCustomMatch()
		{
			// arrange
			var max = 1;
			var matchValue = "test";
			var pairs = new[] { (1, matchValue)};
			var processor = new FizzBuzzGenerator();

			// act
			var results = processor.Generate(max, pairs);

			// assert
			Assert.AreEqual(matchValue, results.First());
		}

		[Test]
		public void Generate_MultipleMatch_CombinesMatches()
		{
			// arrange
			var max = 1;
			var first = "first";
			var second = "second";
			var pairs = new[] { (1, first), (1, second) };
			var processor = new FizzBuzzGenerator();

			// act
			var results = processor.Generate(max, pairs);

			// assert
			Assert.AreEqual(first + second, results.Last());
		}

		[Test]
		public void Generate_DefaultMatch_UsesDefaultGenerators()
		{
			// arrange
			var processor = new FizzBuzzGenerator();
			var max = 5;

			// act
			var results = processor.Generate(max);

			// assert
			Assert.AreEqual("fizz", results.ElementAt(2));
			Assert.AreEqual("buzz", results.ElementAt(4));
		}
	}
}
