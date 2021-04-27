# IntervalMerge

Start time: 28.04.2021, 0:05

## Steps

1. Initialized git repo, added .gitignore and README.md
2. Switched to branch develop for active development
3. Chose C# .NET console app as most simple way to fullfill requirements. Downloaded and installed .NET 5.0 SDK.

- https://dotnet.microsoft.com/download

4. Initialize basic console project

```sh
$ dotnet new console
$ dotnet run
```

Last command actually printed "Hello World!" on console.

5. Git: Performed rebase of master branch based on develop

6. Add nuget source url to nuget package manager (in order to add framework to project)

```sh
dotnet nuget add source --name nuget.org https://api.nuget.org/v3/index.json
```
7. Add MS Test SDK, XUnit and runner to project dependencies via nuget manager in vs code

In VS Code: Press F1 and select 'NuGet Package manager: Add package'

and add following packages:

- Microsoft.NET.Test.Sdk (latest version)
- xunit (latest version)
- xunit.runner.visualstudio (latest version)
