# IntervalMerge

Start time: 28.04.2021, 0:05

## Planning and implementing Project setup

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

8. Running project is broken due introduced double entry point by new dependencies

Fixed by adding to IntervalMerge.csproj:

```xml
<GenerateProgramFile>false</GenerateProgramFile>
```
=> our code is running again.

```sh
$ dotnet run
```

9. Rebase into master branch.

10. Add dummy unit test class for program (in Peperation of TDD)

```cs
// /Program.test.cs
using Xunit;

namespace IntervalMerge.Test
{
    public class TestProgram
    {
        public class UnitTest1
        {
            [Fact]
            public void TestMethod1()
            {
                Assert.False(true);
            }
        }
    }
}
```

Test should actually fail:

```sh
$ dotnet test
```

...and it does go red how expected - all right!

## Planning and Implementation of Merge Algorithm

### Planning

#### Toughts about implementation

##### 1st approach: toughts

just iterate over interval array and compare as we go if overlap was found. If overlap was found, merge with current one and remove the overlapping interval from array. This step has to be repeated for any left over interval. So this gives an squared runtime cost at minimum.

- Advantage: simple to understand.
- Disadvantage: There might be a more performat solution - this one has an estimated of O(n^2) cost.

##### 2nd approach: thoughts

We proceed like before, but this time we sort the intervals by lower bound values. Afterwards we traverse the array just linear during merging. Only one loop required.

- Advantage: Roughly about O(n log n) runtime cost which will be mainly consumed by sorting. Actual merging has constant cost (vs squared cost in first approach).
- Disadvantage: Increase of complexity.

So we go for this approach!

#### Planned Implementation details

- Implementation of a IntervallService in form of a class in subfolder 'services'.
- Implementation of a Interval model class which will represent an single Interval
- Input will be provided hard coded via array.
- Output will be on console.
- Writing unit tests first (TDD).


### Implementation

At this stage the Interval model and comparer is already implemented. We clean up this flaw by writing tests now.

- First remove unnecessary main test
- Unit Test of IntervalComparer makes no sence, since Implementation details are in derived IComparer are private to comparer class. This will automatically be tested in IntervalService functions.

You can run current tests like so:
(replace <project root> with your current project root folder path)

```sh
$ cd <project root>
$ dotnet test
```


You can run current solution like so:
(replace <project root> with your current project root folder path)

```sh
$ cd <project root>
$ dotnet run
```

# Conclusion

Finally we reached around 06:00 CET.

Implemented merge of integer intervals with runtime cost around O(n log n) plus constant runtime for actually merging.

Test for large numbers including int.MaxValue is provided.
