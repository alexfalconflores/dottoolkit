# Extensions
`Bool Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## ToBool
Converts the specified value to a boolean (bool).
`Return` bool: The boolean representation of the value. If the value is non-zero, it returns true; otherwise, false. For strings, it will return true for values like "True", "true", "1", etc., and false for "False", "false", "0", etc.
```csharp
int intValue = 1;
bool result = intValue.ToBool();
//-> true

string stringValue = "false";
bool resultString = stringValue.ToBool();
//-> false
```
