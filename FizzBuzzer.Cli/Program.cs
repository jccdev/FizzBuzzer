using System;
using FizzBuzzer.Library;

namespace FizzBuzzer.Cli
{
    class Program
    {
		// Divisible by 3 print fizz
		// Divisible by 5 print buzz
		// neither see the number
		// allow pass in number pairs, ie 8 -> hamburger
		// as many pairs as they want.
		// fully unit test the project
		// extra credit- Setup build script, Git Repo in a fashion to work in a continuous integration manor.
		// upload to github and send to rayne

        static void Main(string[] args)
        {
	        var fizzProcessor = new FizzBuzzProcessor();
			var output = fizzProcessor.Process(100);
	        foreach (var item in output)
	        {
		        Console.WriteLine(item);
	        }
	        Console.ReadKey();
        }
    }
}
