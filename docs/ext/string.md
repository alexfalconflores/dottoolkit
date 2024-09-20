# Extensions
`String Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## IsNullOrEmpty
Indicates whether the specified string is `null` or an `String.Empty` string.
`Return` `true` if the value parameter is `null` or an empty string `""`; otherwise, `false`.
```csharp
string str1 = null;
string str2 = "";
string str3 = "Hello, World!";
///
bool result1 = str1.IsNullOrEmpty(); // true
bool result2 = str2.IsNullOrEmpty(); // true
bool result3 = str3.IsNullOrEmpty(); // false
```

## IsNullOrWhiteSpace
Indicates whether a specified string is `null`, empty, or consists only of white-space.
`Return` `true` if the value parameter is `null` or `String.Empty`, or if value consists exclusively of white-space characters.
```csharp
string str1 = null;
string str2 = "";
string str3 = "   "; // Only white-space characters
string str4 = "Hello, World!";
///
bool result1 = str1.IsNullOrWhiteSpace(); // true
bool result2 = str2.IsNullOrWhiteSpace(); // true
bool result3 = str3.IsNullOrWhiteSpace(); // true
bool result4 = str4.IsNullOrWhiteSpace(); // false
```

## Join (`string separator`)
Concatenates the members of a collection, using the specified separator between each member.
`Return`A string that consists of the members of values delimited by the separator string. If the collection has no members or is `null`, the method returns `String.Empty`.
```csharp
var fruits = new List<string>; { "Apple", "Banana", "Cherry" };
string result = fruits.Join(", ");
// Output: "Apple, Banana, Cherry"
///
var emptyList = new List<string>;();
string result = emptyList.Join(", ");
// Output: ""
///
var singleItem = new List<string>; { "Orange" };
string result = singleItem.Join(", ");
// Output: "Orange"
///
var names = new List<string>; { "John", "Jane" };
string result = names.Join(null);
// Output: "JohnJane" (without separator)
///
List<string>? nullList = null;
string result = nullList.Join(", ");
// Output: ""
///
var numbers = new List<int>; { 1, 2, 3, 4, 5 };
string result = numbers.Join(" - ");
// Output: "1 - 2 - 3 - 4 - 5"
///
public class Person
{
    public string Name { get; set; }
    public override string ToString() => Name;
}
var people = new List<Person>;
{
    new Person { Name = "Alice" },
    new Person { Name = "Bob" },
    new Person { Name = "Charlie" }
};
string result = people.Join(", ");
// Output: "Alice, Bob, Charlie"
```

## Join (`string separator, Func<T, string> formatFunc`)
Joins the elements of a collection into a single string using the specified separator and a formatting function.
`Return` A string that consists of the formatted elements joined by the separator.
```csharp
var people = new List&lt;Person&gt;(){
    new Person(){Name="Alice", Age=30}
    new Person(){Name="Bob", Age=25}
    new Person(){Name="Charlie", Age=35}
}.Join(",", p => $"{p.Name} : {p.Age}");
//-> Alice : 30,Bob : 25,Charlie : 35
```

## Repeat
Repeats the specified string a given number of times.
`Return` A string that consists of the input string repeated the specified number of times. If `numberRepeat` is less than or equal to zero, or `input` is `null`, an empty string is returned.
```csharp
string repeated = "Hello".Repeat(3);
// -> "HelloHelloHello"

string repeatedSingle = "World".Repeat();
// -> "World"

string repeatedNegative = "Test".Repeat(-1);
// -> ""
```

## ToCamelCase
`Returns` Converts string to [camelCase](https://en.wikipedia.org/wiki/Camel_case).
```csharp
string result1 = "HELLO_WORLD".ToCamelCase();
// -> helloWorld

string result2 = ((string?)null).ToCamelCase();
// -> ""

string result3 = "".ToCamelCase();
// -> ""

string result4 = "HELLO WORLD".ToCamelCase();
// -> helloWorld

string result5 = "HelloWorld".ToCamelCase();
// -> helloworld
```

## ToPascalCase
`Return` Converts string to PascalCase.
```csharp
string result1 = "HELLO_WORLD".ToCamelCase();
// -> HelloWorld

string result2 = ((string?)null).ToCamelCase();
// -> ""

string result3 = "".ToCamelCase();
// -> ""

string result4 = "HELLO WORLD".ToCamelCase();
// -> HelloWorld

string result5 = "HelloWorld".ToCamelCase();
// -> Helloworld
```

## ToKebabCase
Converts string to [kebab-case](https://en.wikipedia.org/wiki/Letter_case#Special_case_styles).
```csharp
string result1 = "___-__HELLO_WORLD_____".ToKebabCase();
// -> hello-world

string result2 = ((string?)null).ToKebabCase();
// -> ""

string result3 = "".ToKebabCase();
// -> ""

string result4 = "HELLO WORLD".ToKebabCase();
// -> hello-world

string result5 = "HelloWorld".ToKebabCase();
// -> hello-world
```

## ToSnakeCase
`Return` Converts string [Snake Case](https://en.wikipedia.org/wiki/Snake_case).
```csharp
string result1 = "___-__HELLO_WORLD_____".ToSnakeCase();
// -> hello_world

string result2 = ((string?)null).ToSnakeCase();
// -> ""

string result3 = "".ToSnakeCase();
// -> ""

string result4 = "HELLO WORLD".ToSnakeCase();
// -> hello_world

string result5 = "HelloWorld".ToSnakeCase();
// -> hello_world
```

## HtmlEscape
Converters the characters `&amp;, &lt;, &gt;, &quot;, and &#39;` in string to their corresponding HTML entities.
`Return` the HTML-encoded string, or an empty string if the input is null.
```csharp
string input1 = "Hello &amp; welcome";
string escaped1 = input1.HtmlEscape();
// -> Hello &amp; welcome

string input2 = "<div>Example</div>";
string escaped2 = input2.HtmlEscape();
// -> &lt;div&gt;Example&lt;/div&gt;
```

## HtmlUnEscape
The inverse of `HtmlEscape(string)` this method converts the HTML entities &amp;, &lt;, &gt;, &quot;, and &#39; in string to their corresponding characters.
`Returns` the unescaped string.
```csharp
string input1 = "Hello <![CDATA[&amp;]]> welcome";
string escaped1 = input1.HtmlEscape();
// -> Hello &amp; welcome

string input2 = "&lt;div&gt;Example&lt;/div&gt;";
string escaped2 = input2.HtmlEscape();
// -> <div>Example</div>
```

## ReverseString
`Return`Reverses a string.
```csharp
string original = "Hello, World!";
string reversed = original.ReverseString();
//-> !dlroW ,olleH
```

## ToChar
Converts the specified value to a Unicode character `char`.
`Return` The Unicode character representation of the value.
```csharp
int numericValue = 65; // ASCII value for 'A'
char result = numericValue.ToChar();
//-> A

public enum SampleEnum
{
   A = 65,
   b = 66,
   c = 67
}
char result = SampleEnum.A.ToChar();
//-> A
```
