using System;

namespace DotToolkit.Extensions;

public static class ArrayExt
{
    /// <summary>
    /// Sorts the elements of an array in ascending order.
    /// <example><code>
    /// var numbers = new int[] { 5, 3, 8, 1 };
    /// var result = numbers.Sorted();
    /// //-> 1, 3, 5, 8
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted. Must not be null.</param>
    /// <returns>The sorted array.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="array"/> is null.</exception>
    public static T[] Sorted<T>(this T[] array)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));
        Array.Sort(array);
        return array;
    }
    /// <summary>
    /// Sorts the elements of an array using a specified comparer.
    /// <example><code>
    /// var numbers = new int[] { 5, 3, 8, 1 };
    /// 
    /// var asc = numbers.Sorted(Comparer&lt;int&gt;.Create((x, y) => x.CompareTo(y))).Join(",");
    /// // -> 1,3,5,8
    /// 
    /// var desc = numbers.Sorted(Comparer&lt;int&gt;.Create((x, y) => y.CompareTo(x))).Join(",");
    /// // -> 8,5,3,1
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted. Must not be null.</param>
    /// <param name="comparer">An object that implements <see cref="IComparer{T}"/> to compare elements.</param>
    /// <returns>The sorted array.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="array"/> is null.</exception>
    public static T[] Sorted<T>(this T[] array, IComparer<T> comparer = null)
    {
        if (array is null) throw new ArgumentException(nameof(array));
        Array.Sort(array, comparer);
        return array;
    }
    /// <summary>
    /// Sorts the elements of an array using a specified comparison delegate.
    /// <example><code>
    /// var numbers = new int[] { 5, 3, 8, 1 };
    /// 
    /// var asc = numbers.Sorted((x, y) => x.CompareTo(y)).Join(",");
    /// // -> 1,3,5,8
    /// 
    /// var desc = numbers.Sorted((x, y) => y.CompareTo(x)).Join(",");
    /// // -> 8,5,3,1
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted. Must not be null.</param>
    /// <param name="comparison">A delegate that compares two elements.</param>
    /// <returns>The sorted array.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="array"/> is null.</exception>
    public static T[] Sorted<T>(this T[] array, Comparison<T> comparison = null)
    {
        if (array is null) throw new ArgumentException(nameof(array));
        Array.Sort(array, comparison);
        return array;
    }
    /// <summary>
    /// Sorts a range of elements in an array.
    /// <example><code>
    /// var numbers = new int[] { 5, 3, 8, 1, 6 };
    /// var res = numbers.Sorted(1, 3).Join(",");
    /// // -> 5,1,3,8,6
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted. Must not be null.</param>
    /// <param name="index">The zero-based starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <returns>The sorted array.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="array"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="index"/> or <paramref name="length"/> are out of range.</exception>
    public static T[] Sorted<T>(this T[] array, int index, int length)
    {
        if (array is null) throw new ArgumentException(nameof(array));
        Array.Sort(array, index, length);
        return array;
    }
    /// <summary>
    /// Sorts a range of elements in an array using a specified comparer.
    /// <example><code>
    /// var numbers = new int[] { 5, 3, 8, 1, 6 };
    /// var desc = numbers.Sorted(1, 3, Comparer<int>.Create((x, y) => y.CompareTo(x))).Join(",");
    /// // -> 5,8,3,1,6
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted. Must not be null.</param>
    /// <param name="index">The zero-based starting index of the range to sort.</param>
    /// <param name="length">The number of elements in the range to sort.</param>
    /// <param name="comparer">An object that implements <see cref="IComparer{T}"/> to compare elements.</param>
    /// <returns>The sorted array.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="array"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="index"/> or <paramref name="length"/> are out of range.</exception>
    public static T[] Sorted<T>(this T[] array, int index, int length, IComparer<T> comparer = null)
    {
        if (array is null) throw new ArgumentException(nameof(array));
        Array.Sort(array, index, length, comparer);
        return array;
    }
}
