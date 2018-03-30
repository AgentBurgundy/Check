# Getting Started
`Install-Package CheckNET.Core`

Or pull in the NuGet package through Package Manager.

Once installed, your Asserts in any NUnit test can be replaced with Check.That statements.

# Extensions
## Object Extensions
These extensions apply to all types, since all types inherit object in C#.
```
object.IsNotNull() - Passes if the object is Not Null.

object.IsNull() - Passes if the object is Null.

object.IsEqual(object otherValue) - Passes if the object is equal to the other value passed in.
```

## String Extensions
These extensions apply to all strings.
```
string.IsNotEmpty() - Passes if the string is not an empty string.

string.IsEmpty() - Passes if the string is an empty string.

string.IsNotNullOrEmpty() - Passes if the string is not null or empty.

string.IsNullOrEmpty() - Passes if the string is null or empty.

string.ContainsThese(IEnumerable<string> elementsToLookFor) - Passes if the string contains all of the elements in the IEnumerable<string>.

string.MeetsCondition(Func<string, bool> condtion) - Passes if the string meets the bool condition passed in as an anonymous method.
```

## Int and Nullable Int Extensions
These extensions apply to both Ints and Nullable<int>.
```
int.IsDivisibleBy(int divisor) - Passes if int is divisible by divisor with no remainder.

int?.IsDivisibleBy(int? divisor) - Passes if int? is divisible by divisor? with no remainder.
```