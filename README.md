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

Check.That(myString.IsNotNullOrEmpty().And.ContainsThese(new string[]{ "World" })));
```

Currently Check.NET only supports NUnit but is extremely expandable to work with any Unit Testing Framework that exists.

# How To Use
Find the NuGet package in the PackageManager or install via console using.

`Install-Package CheckNET.Core`

Then just replace your asserts with `Check.That(conditions...)`

# Documentation WIP
[Documentation](https://github.com/AgentBurgundy/Check.NET/blob/master/DOCUMENTATION.md)

# Supported Unit Testing Frameworks
Currently Check.NET supports NUnit only but is easily expandable to ANY other Test Framework out. Plans are to implement XUnit and MSTest support soon.

# Not Just Asserts
The other benefit of this library is that these Checks can be used method arguments for null checking and throwing exceptions. Just use the Check.Argument() method.
```
public void MyMethod(string MyArgument)
{
	// Will throw ArgumentNull Exception for you!
	Check.Argument(myArgument.IsNotNull());
}
```

# How To Contribute
All issues are up for grabs, I plan to update this package to the best of my ability.

Please feel free to file issues for any bugs or questions as I'll be glad to help.