var target = Argument("target", "Default");

// Tasks

Task("Clean")
    .Does(() =>
{
	var settings = new DotNetCoreCleanSettings
	{
		Configuration = "Release"
	};

	var projectFiles = GetFiles("./**/**/*.csproj");
	foreach(var file in projectFiles)
    {
		DotNetCoreClean(file.FullPath, settings);
	}
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
		var settings = new DotNetCoreTestSettings
		{
			NoBuild = true,
			Configuration = "Release"
		};
		
		var projectFiles = GetFiles("./**/**/*Test.csproj");
		foreach(var file in projectFiles)
		{
			DotNetCoreTest(file.FullPath, settings);
		}
	});

Task("Default")
    .IsDependentOn("Unit Tests");

// Run
RunTarget(target);