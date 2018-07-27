var target = Argument("target", "Default");

// Tasks

Task("Clean")
    .Does(() =>
{
	DotNetCoreClean("./FizzBuzzer.Cli");
	DotNetCoreClean("./FizzBuzzer.Library");
	DotNetCoreClean("./FizzBuzzer.UnitTest");
});

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
	{
		DotNetCoreBuild("./FizzBuzzer.sln", new DotNetCoreBuildSettings
		{
			Configuration = "Release"
		});
	});

Task("Unit Tests")
    .IsDependentOn("Build")
	.Does(() =>
	{
		DotNetCoreTest("./FizzBuzzer.UnitTest/FizzBuzzer.UnitTest.csproj",new DotNetCoreTestSettings
		{
			NoBuild = true,
			Configuration = "Release"
		});
	});

Task("Default")
    .IsDependentOn("Unit Tests");

// Run
RunTarget(target);