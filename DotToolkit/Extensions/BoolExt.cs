namespace DotToolkit.Extensions;

public static class BoolExt
{
    /// <summary>
    /// Converts the specified value to a boolean (bool).
    /// <example><code>
    /// int intValue = 1;
    /// bool result = intValue.ToBool();
    /// //-> true
    /// 
    /// string stringValue = "false";
    /// bool resultString = stringValue.ToBool();
    /// //-> false
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>bool: The boolean representation of the value. If the value is non-zero, 
    /// it returns true; otherwise, false. For strings, it will return true for values like "True", 
    /// "true", "1", etc., and false for "False", "false", "0", etc.</returns>
    public static bool ToBool<T>(this T value) where T : IConvertible => Convert.ToBoolean(value);
}
