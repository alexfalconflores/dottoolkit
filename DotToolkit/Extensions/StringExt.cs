using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DotToolkit.Extensions;

#nullable enable
public static class StringExt
{
    /// <summary>
    /// Indicates whether the specified string is <see langword="null"/> or an <see cref="System.String.Empty"/> string.
    /// <example><code>
    /// string str1 = null;
    /// string str2 = "";
    /// string str3 = "Hello, World!";
    ///
    /// bool result1 = str1.IsNullOrEmpty(); // true
    /// bool result2 = str2.IsNullOrEmpty(); // true
    /// bool result3 = str3.IsNullOrEmpty(); // false
    /// </code></example>
    /// </summary>
    /// <param name="value">The <see cref="string"/> to test.</param>
    /// <returns><see langword="true"/> if the value parameter is <see langword="null"/> or an empty string (""); otherwise, <see langword="false"/>.</returns>
    public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
    /// <summary>
    /// Indicates whether a specified string is <see langword="null"/>, empty, or consists only of white-space
    /// characters.
    ///<example><code>
    /// string str1 = null;
    /// string str2 = "";
    /// string str3 = "   "; // Only white-space characters
    /// string str4 = "Hello, World!";
    ///
    /// bool result1 = str1.IsNullOrWhiteSpace(); // true
    /// bool result2 = str2.IsNullOrWhiteSpace(); // true
    /// bool result3 = str3.IsNullOrWhiteSpace(); // true
    /// bool result4 = str4.IsNullOrWhiteSpace(); // false
    ///</code></example>
    /// </summary>
    /// <param name="text">The <see langword="string"/> to test.</param>
    /// <returns>
    /// <see langword="true"/> if the value parameter is <see langword="null"/> or <see cref="System.String.Empty"/>, or if value consists
    /// exclusively of white-space characters.
    ///</returns>
    public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    /// <summary>
    /// Concatenates the members of a collection, using the specified separator between each member.    
    /// <example>
    /// <code>
    /// var fruits = new List&lt;string&gt; { "Apple", "Banana", "Cherry" };
    /// string result = fruits.Join(", ");
    /// // Output: "Apple, Banana, Cherry"
    ///
    /// var emptyList = new List&lt;string&gt;();
    /// string result = emptyList.Join(", ");
    /// // Output: ""
    ///
    /// var singleItem = new List&lt;string&gt; { "Orange" };
    /// string result = singleItem.Join(", ");
    /// // Output: "Orange"
    ///
    /// var names = new List&lt;string&gt; { "John", "Jane" };
    /// string result = names.Join(null);
    /// // Output: "JohnJane" (without separator)
    ///
    /// List&lt;string&gt;? nullList = null;
    /// string result = nullList.Join(", ");
    /// // Output: ""
    ///
    /// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
    /// string result = numbers.Join(" - ");
    /// // Output: "1 - 2 - 3 - 4 - 5"
    ///
    /// public class Person
    /// {
    ///     public string Name { get; set; }
    ///     public override string ToString() => Name;
    /// }
    /// var people = new List&lt;Person&gt;
    /// {
    ///     new Person { Name = "Alice" },
    ///     new Person { Name = "Bob" },
    ///     new Person { Name = "Charlie" }
    /// };
    /// string result = people.Join(", ");
    /// // Output: "Alice, Bob, Charlie"
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="T">The type of the members of values.</typeparam>
    /// <param name="collection">A collection that contains the objects to concatenate. 
    ///  only if values has more than one element.</param>
    /// <param name="separator">The string to use as a separator.separator is included in the returned string</param>
    /// <returns>A string that consists of the members of values delimited by the separator string.
    /// If the collection has no members or is <see langword="null"/>, the method returns <see cref="System.String.Empty"/>.
    /// </returns>
    public static string Join<T>(this IEnumerable<T> collection, string? separator)
    {
        if (collection is null || !collection.Any()) return string.Empty;
        return string.Join(separator ?? string.Empty, collection);
    }
    /// <summary>
    /// Concatenates the members of a collection of strings, using the specified separator between each member.
    /// <example><code>
    /// var words = new List&lt;string&gt; { "Hello", "World", "Foo", "Bar" };
    /// string result = words.Join(", ");
    /// //-> Hello, World, Foo, Bar
    /// 
    /// var emptyList = new List&lt;string&gt;();
    /// string result2 = emptyList.Join(", ");
    /// // -> ""
    /// 
    /// List&lt;string&gt;? nullList = null;
    /// string result3 = nullList.Join(", ");
    /// // -> ""
    /// 
    /// var wordsWithNullSeparator = new List&lt;string&gt; { "One", "Two", "Three" };
    /// string result4 = wordsWithNullSeparator.Join(null);
    /// // -> OneTwoThree
    /// </code></example>
    /// </summary>
    /// <param name="collection">A collection of strings to concatenate. If the collection is <see langword="null"/> or empty, the method returns <see cref="System.String.Empty"/>.</param>
    /// <param name="separator">The string to use as a separator. If <see langword="null"/>, an empty string is used as the separator.</param>
    /// <returns>A string that consists of the members of the collection delimited by the separator string. If the collection is <see langword="null"/> or empty, the method returns <see cref="String.Empty"/>.</returns>
    public static string Join(this IEnumerable<string> collection, string? separator)
    {
        if (collection is null || !collection.Any()) return string.Empty;
        return string.Join(separator ?? string.Empty, collection);
    }
    /// <summary>
    /// Concatenates the members of a collection, using the specified separator between each member.
    /// <example><code>
    /// object[] values = { "Apple", 42, 3.14, true };
    /// string result = values.Join(", ");
    /// // -> "Apple, 42, 3.14, True"
    /// 
    /// object[] values = { "Apple", "Banana", "Cherry" };
    /// string result2 = values.Join(null);
    /// // -> "AppleBananaCherry"
    /// 
    /// object[] values3 = { };
    /// string result3 = values.Join(", ");
    /// // -> ""
    /// 
    /// object[]? values4 = null;
    /// string result4 = values.Join(", ");
    /// // -> ""
    /// </code></example>
    /// </summary>
    /// <param name="values">The array of objects to concatenate.</param>
    /// <param name="separator">The string to use as a separator.separator is included in the returned string
    /// only if values has more than one element.</param>
    /// <returns>A string that consists of the members of values delimited by the separator string.
    /// If the collection has no members or is <see langword="null"/>, the method returns <see cref="System.String.Empty"/>.
    /// </returns>
    public static string Join(this object[]? values, string? separator)
    {
        if (values is null or { Length: 0 }) return string.Empty;
        return string.Join(separator ?? string.Empty, values);
    }
    /// <summary>
    /// Concatenates the members of a collection, using the specified separator between each member.
    /// <example><code>
    /// string[] values = { "Apple", "Banana", "Cherry" };
    /// string result = values.Join(", ");
    /// // -> "Apple, Banana, Cherry"
    /// 
    /// string[] values2 = { "Apple", "Banana", "Cherry" };
    /// string result2 = values2.Join(null);
    /// // -> "AppleBananaCherry"
    /// 
    /// string[] values3 = { };
    /// string result3 = values3.Join(", ");
    /// // -> ""
    /// 
    /// string[]? values4 = null;
    /// string result4 = values4.Join(", ");
    /// // -> ""
    /// </code></example>
    /// </summary>
    /// <param name="values">The array of strings to concatenate.</param>
    /// <param name="separator">The string to use as a separator.separator is included in the returned string
    /// only if values has more than one element.</param>
    /// <returns>A string that consists of the members of values delimited by the separator string.
    /// If the collection has no members or is <see langword="null"/>, the method returns <see cref="System.String.Empty"/>.
    /// </returns>
    public static string Join(this string[]? values, string? separator)
    {
        if (values is null or { Length: 0 }) return string.Empty;
        return string.Join(separator, values);
    }
    /// <summary>
    /// Concatenates a range of elements from an array of strings, using the specified separator between each member.
    /// <example><code>
    /// string[] words = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
    /// // Concatenate from index 1 with count 3
    /// string result = words.Join(", ", 1, 3);
    /// //-> Banana, Cherry, Date
    /// 
    /// // Concatenate all elements
    /// string resultAll = words.Join(", ", 0, words.Length);
    /// // -> Apple, Banana, Cherry, Date, Elderberry
    /// 
    /// // Concatenate with a null separator
    /// string resultNoSeparator = words.Join(null, 0, 5);
    /// // -> AppleBananaCherryDateElderberry
    /// 
    /// // Attempting to include more elements than available
    /// string resultWithTooMany = words.Join(", ", 2, 10);
    /// // -> System.ArgumentOutOfRangeException: 'startIndex ('2') must be less than or equal to '-5'. (Parameter 'startIndex') Actual value was 2.'
    /// </code></example>
    /// </summary>
    /// <param name="values">The array of strings to concatenate. If <see langword="null"/>, an empty string is returned.</param>
    /// <param name="separator">The string to use as a separator. If <see langword="null"/>, no separator is used between elements.</param>
    /// <param name="startIndex">The zero-based index of the first element in the range to include in the concatenation.</param>
    /// <param name="count">The number of elements to include in the concatenation. If the range exceeds the bounds of the array, only available elements are included.</param>
    /// <returns>A string that consists of the strings in value delimited by the separator string. -or- <see cref="String.Empty"/> if count is zero, value has no elements, or separator and all the elements of value are <see cref="String.Empty"/>.</returns>
    /// <exception cref="ArgumentNullException"/>
    /// <exception cref="ArgumentOutOfRangeException"/>
    /// <exception cref="OutOfMemoryException"/>
    public static string Join(this string[]? values, string? separator, int startIndex, int count)
    {
        if (values is null) return string.Empty;
        return string.Join(separator, values, startIndex, count);
    }
    /// <summary>
    /// Repeats the specified string a given number of times.
    /// <example><code>
    /// string repeated = "Hello".Repeat(3);
    /// // -> "HelloHelloHello"
    /// 
    /// string repeatedSingle = "World".Repeat();
    /// // -> "World"
    /// 
    /// string repeatedNegative = "Test".Repeat(-1);
    /// // -> ""
    /// </code></example>
    /// </summary>
    /// <param name="input">The string to repeat. If <see langword="null"/>, an empty string is returned.</param>
    /// <param name="numberRepeat">The number of times to repeat the string. If less than or equal to zero, an empty string is returned.</param>
    /// <returns>
    /// A string that consists of the input string repeated the specified number of times. If <paramref name="numberRepeat"/> is less than or equal to zero, or <paramref name="input"/> is <see langword="null"/>, an empty string is returned.
    /// </returns>
    public static string Repeat(this string input, int numberRepeat = 1)
    {
        if (numberRepeat <= 0 || input is null) return string.Empty;
        var builder = new StringBuilder(input.Length * numberRepeat);
        for (int i = 0; i < numberRepeat; i++) builder.Append(input);
        return builder.ToString();
    }
    private static readonly Regex SplitRegex = new(@"[^A-Za-z0-9]+", RegexOptions.Compiled);
    private static readonly Regex CamelCaseRegex = new(@"([a-z])([A-Z])", RegexOptions.Compiled);
    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Camel_case">camelCase</see>.
    /// <example><code>
    /// string result1 = "HELLO_WORLD".ToCamelCase();
    /// // -> helloWorld
    /// 
    /// string result2 = ((string?)null).ToCamelCase();
    /// // -> ""
    /// 
    /// string result3 = "".ToCamelCase();
    /// // -> ""
    /// 
    /// string result4 = "HELLO WORLD".ToCamelCase();
    /// // -> helloWorld
    /// 
    /// string result5 = "HelloWorld".ToCamelCase();
    /// // -> helloworld
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Camel_case">camelCase</see> string.</returns>
    public static string ToCamelCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        var builder = new StringBuilder();
        var words = SplitRegex.Split(input.ToLowerInvariant()).Where(word => !string.IsNullOrEmpty(word)).ToArray();
        if (words.Length == 0) return string.Empty;
        builder.Append(words[0]);
        for (int i = 1; i < words.Length; i++)
        {
            var word = words[i];
            builder.Append(char.ToUpperInvariant(word[0]) + word[1..]);
        };
        return builder.ToString();
    }
    /// <summary>
    /// Converts string to <see href="">PascalCase</see>.
    /// <example><code>
    /// string result1 = "HELLO_WORLD".ToCamelCase();
    /// // -> HelloWorld
    /// 
    /// string result2 = ((string?)null).ToCamelCase();
    /// // -> ""
    /// 
    /// string result3 = "".ToCamelCase();
    /// // -> ""
    /// 
    /// string result4 = "HELLO WORLD".ToCamelCase();
    /// // -> HelloWorld
    /// 
    /// string result5 = "HelloWorld".ToCamelCase();
    /// // -> Helloworld
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="">PascalCase</see> string.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string ToPascalCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        var builder = new StringBuilder();
        var words = SplitRegex.Split(input.ToLowerInvariant()).Where(word => !string.IsNullOrEmpty(word)).ToArray();
        if (words.Length == 0) return string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            builder.Append(char.ToUpperInvariant(word[0]) + word[1..]);
        }
        return builder.ToString();
    }
    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Letter_case#Special_case_styles">kebab-case</see>.
    /// <example><code>
    /// string result1 = "___-__HELLO_WORLD_____".ToKebabCase();
    /// // -> hello-world
    /// 
    /// string result2 = ((string?)null).ToKebabCase();
    /// // -> ""
    /// 
    /// string result3 = "".ToKebabCase();
    /// // -> ""
    /// 
    /// string result4 = "HELLO WORLD".ToKebabCase();
    /// // -> hello-world
    /// 
    /// string result5 = "HelloWorld".ToKebabCase();
    /// // -> hello-world
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Letter_case#Special_case_styles">kebab-case</see> string.</returns>
    public static string ToKebabCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        input = CamelCaseRegex.Replace(input, "$1-$2").ToLowerInvariant();
        string[] words = SplitRegex.Split(input).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        return string.Join("-", words);
    }
    /// <summary>
    /// Converts string to <see href="https://en.wikipedia.org/wiki/Snake_case">snake_case</see>.
    /// <example><code>
    /// string result1 = "___-__HELLO_WORLD_____".ToSnakeCase();
    /// // -> hello_world
    /// 
    /// string result2 = ((string?)null).ToSnakeCase();
    /// // -> ""
    /// 
    /// string result3 = "".ToSnakeCase();
    /// // -> ""
    /// 
    /// string result4 = "HELLO WORLD".ToSnakeCase();
    /// // -> hello_world
    /// 
    /// string result5 = "HelloWorld".ToSnakeCase();
    /// // -> hello_world
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Returns the <see href="https://en.wikipedia.org/wiki/Snake_case">snake_case</see> string</returns>
    public static string ToSnakeCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;
        input = CamelCaseRegex.Replace(input, "$1-$2").ToLowerInvariant();
        string[] words = SplitRegex.Split(input).Where(words => !string.IsNullOrEmpty(words)).ToArray();
        return string.Join("_", words);
    }
    /// <summary>
    /// Converters the characters &amp;, &lt;, &gt;, &quot;, and &#39; in string to their corresponding HTML entities 
    /// <example><code>
    /// string input1 = "Hello &amp; welcome";
    /// string escaped1 = input1.HtmlEscape();
    /// // -> Hello <![CDATA[&amp;]]> welcome
    /// 
    /// string input2 = "&lt;div&gt;Example&lt;/div&gt;";
    /// /// string escaped2 = input2.HtmlEscape();
    /// -> <![CDATA[&lt;]]>div<![CDATA[&gt;]]>Example<![CDATA[&lt;]]>/div<![CDATA[&gt;]]>
    /// </code></example>
    /// </summary>
    /// <param name="input">The string to be HTML-encoded.</param>
    /// <returns>Returns the HTML-encoded string, or an empty string if the input is null.</returns>
    public static string HtmlEscape(this string input)
    {
        if (input is null) return string.Empty;
        return WebUtility.HtmlEncode(input);
    }
    /// <summary>
    /// The inverse of <see cref="HtmlEscape(string)"/>; this method converts the HTML entities &amp;, &lt;, &gt;, &quot;, and &#39; in string to their corresponding characters."/>
    /// <example><code>
    /// string input1 = "Hello <![CDATA[&amp;]]> welcome";
    /// string escaped1 = input1.HtmlEscape();
    /// // -> Hello &amp; welcome
    /// 
    /// string input2 = "<![CDATA[&lt;]]>div<![CDATA[&gt;]]>Example<![CDATA[&lt;]]>/div<![CDATA[&gt;]]>";
    /// /// string escaped2 = input2.HtmlEscape();
    /// -> &lt;div&gt;Example&lt;/div&gt;
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns> Returns the unescaped string.</returns>
    public static string HtmlUnEscape(this string input)
    {
        if (input is null) return string.Empty;
        return WebUtility.HtmlDecode(input);
    }
    /// <summary>
    /// Reverses a string.
    /// <example><code>
    /// string original = "Hello, World!";
    /// string reversed = original.ReverseString();
    /// //-> !dlroW ,olleH
    /// </code></example>
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ReverseString(this string input)
    {
        if (input is null) return string.Empty;
        var length = input.Length;
        var builder = new StringBuilder(length);
        for(int i = length - 1; i>=0;i--)builder.Append(input[i]);
        return builder.ToString();
    }
    /// <summary>
    /// Converts the specified value to a Unicode character (<see cref="char"/>).
    /// <example><code>
    /// int numericValue = 65; // ASCII value for 'A'
    /// char result = numericValue.ToChar();
    /// //-> A
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The Unicode character representation of the value.</returns>
    public static char ToChar<T>(this T value) where T : IConvertible => Convert.ToChar(value);
}