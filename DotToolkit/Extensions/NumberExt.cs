namespace DotToolkit.Extensions;

public static class NumberExt
{
    /// <summary>
    /// Check if the number is NaN.
    /// <example><code>
    /// double value = doble.NaN;
    /// var result = value.IsNaN()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNaN(this double number) => double.IsNaN(number);
    /// <summary>
    /// Check if the number is NaN.
    /// <example><code>
    /// float value = float.NaN;
    /// var result = value.IsNaN()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNaN(this float number) => float.IsNaN(number);
    /// <summary>
    /// Converts the specified value to an 8-bit unsigned integer (<see cref="byte"/>).
    /// <example><code>
    /// int value = 123;
    /// byte result = value.ToByte();
    /// //-> 123
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/></param>
    /// <returns>The 8-bit unsigned integer representation of the value.</returns>
    public static byte ToByte<T>(this T number) where T : IConvertible => Convert.ToByte(number);
    /// <summary>
    /// Converts the specified value to an 8-bit signed integer (<see cref="sbyte"/>).
    /// <example><code>
    /// int value = -123;
    /// sbyte result = value.ToSByte();
    /// sbyte result = value.ToSByte();
    /// //-> -123
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 8-bit signed integer representation of the value.</returns>
    public static sbyte ToSByte<T>(this T number) where T : IConvertible => Convert.ToSByte(number);
    /// <summary>
    /// Converts the specified value to a 16-bit signed integer (<see cref="short"/>).
    /// <example><code>
    /// int value = 12345;
    /// short result = value.ToShort();
    /// //-> 12345
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 16-bit signed integer representation of the value.</returns>
    public static short ToShort<T>(this T number) where T : IConvertible => Convert.ToInt16(number);
    /// <summary>
    /// Converts the specified value to a 16-bit unsigned integer (<see cref="ushort"/>).
    /// <example><code>
    /// int value = 12345;
    /// ushort result = value.ToUShort();
    /// //-> 12345
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 16-bit unsigned integer representation of the value.</returns>
    public static ushort ToUShort<T>(this T number) where T : IConvertible => Convert.ToUInt16(number);
    /// <summary>
    /// Converts the specified value to a 32-bit signed integer (<see cref="int"/>).
    /// <example><code>
    /// double value = 123.45;
    /// int result = value.ToInt();
    /// //-> 123
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 32-bit signed integer representation of the value.</returns>
    public static int ToInt<T>(this T number) where T : IConvertible => Convert.ToInt32(number);
    /// <summary>
    /// Converts the specified value to a 32-bit unsigned integer (<see cref="uint"/>).
    /// <example><code>
    /// double value = 123.45;
    /// uint result = value.ToUInt();
    /// //->123
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 32-bit unsigned integer representation of the value.</returns>
    public static uint ToUInt<T>(this T number) where T : IConvertible => Convert.ToUInt32(number);
    /// <summary>
    /// Converts the specified value to a 64-bit signed integer (<see cref="long"/>).
    /// <example><code>
    /// int value = 12345;
    /// long result = value.ToLong();
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 64-bit signed integer representation of the value.</returns>
    public static long ToLong<T>(this T number) where T : IConvertible => Convert.ToInt64(number);
    /// <summary>
    /// Converts the specified value to a 64-bit unsigned integer (<see cref="ulong"/>).
    /// <example><code>
    /// int value = 12345;
    /// ulong result = value.ToULong();
    /// //-> 12345
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The 64-bit unsigned integer representation of the value.</returns>
    public static ulong ToULong<T>(this T number) where T : IConvertible => Convert.ToUInt64(number);
    /// <summary>
    /// Converts the specified value to a single-precision floating point number (<see cref="float"/>).
    /// <example><code>
    /// int value = 123;
    /// float result = value.ToFloat();
    /// //-> 123.0
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The single-precision floating point representation of the value.</returns>
    public static float ToFloat<T>(this T number) where T : IConvertible => Convert.ToSingle(number);
    /// <summary>
    /// Converts the specified value to a decimal number (<see cref="decimal"/>).
    /// <example><code>
    /// double value = 123.45;
    /// decimal result = value.ToDecimal();
    /// //->123.45
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The decimal number representation of the value.</returns>
    public static decimal ToDecimal<T>(this T number) where T : IConvertible => Convert.ToDecimal(number);
    /// <summary>
    /// Converts the specified value to a double-precision floating point number (<see cref="double"/>).
    /// <example><code>
    /// int value = 123;
    /// double result = value.ToDouble();
    /// //->123.0
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number">The value to be converted, which must implement <see cref="IConvertible"/>.</param>
    /// <returns>The double-precision floating point representation of the value.</returns>
    public static double ToDouble<T>(this T number) where T : IConvertible => Convert.ToDouble(number);
}
