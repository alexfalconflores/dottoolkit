using System.Collections;
using System.Collections.Generic;

namespace DotToolkit.Math;

public static class Math
{
    /// <summary>
    /// Get
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static ulong Fibonacci(this int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        ulong a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
    /// <summary>
    /// Check if a number is even
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsEven(this int number) => number % 2 == 0;
    /// <summary>
    /// Return a sequence of even numbers up to the given number.
    /// <para>Output: { 0, 2, 4, 6, 8, 10}</para>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Evens(this int number)
    {
        for (int i = 0; i <= number; i += 2)
            yield return i;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsOdd(this int number) => number % 2 != 0;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Odds(this int number)
    {
        for (int i = 1; i <= number; i += 2)
            yield return i;
    }
}
