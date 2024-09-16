namespace DotToolkit.Extensions;

public static class NumberExt
{
    /// <summary>
    /// Check if the number is NaN.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    /// <example><code>
    /// double value = doble.NaN;
    /// var result = value.IsNaN()
    /// // -> true
    /// </code></example>
    public static bool IsNaN(this double number) => double.IsNaN(number);
    /// <summary>
    /// Check if the number is NaN.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    /// <example><code>
    /// float value = float.NaN;
    /// var result = value.IsNaN()
    /// // -> true
    /// </code></example>
    public static bool IsNaN(this float number) => float.IsNaN(number);
}
