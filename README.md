# Check.NET
An open source library for null checking and value checking classes and structs in C#.

# Why Use?
The point behind this library is to promote an easy to read DSL for Unit Testing. Null checking objects in C# 
can be cumbersome sometimes and Asserts can end up being bloated with too much text. With Check.NET you can turn this
```
// Example using NUnit testing framework for Assertations.

var myString = "Hello World"

Assert.That(!string.IsNullOrEmpty(myString) && myString.Contains("World"));
```

to

```
// Example using NUnit testing framework for Assertations.

var myString = "Hello World"

Assert.That(Check.IsNotNull(myString).MeetsCondition(s => s.Contains("World")));
```

# How To Use
Find the NuGet package in the PackageManager or install via console using.

`Install-Package CheckNET.Core`

# How To Contribute
All issues are up for grabs, I plan to update this package to the best of my ability.

Please feel free to file issues for any bugs or questions as I'll be glad to help.