namespace DotToolkit.Extensions;

public static class ListExt
{
    /// <summary>
    /// Sorts the elements in the entire <see cref="List{T}"/> in the default order and returns the sorted list.
    /// <example><code>
    /// List&lt;string&gt;names = ["John", "Alex", "Zara"]; // C#12 Syntax
    /// var result = names.Sorted().Join(",")
    /// //-> Alex,John,Zara
    /// 
    /// var numbers = new List&lt;int&gt;{ 5, 3, 8, 1, 2 }; // &lt;= C# 11 Syntax
    /// var result = numbers.Sorted().Join(",")
    /// //-> 0,1,2,6,7,8,9,10,20,30
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="collection">The list to sort. Must not be null.</param>
    /// <returns>The sorted <see cref="List{T}"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="collection"/> is null.</exception>
    public static List<T> Sorted<T>(this List<T> collection)
    {
        if (collection is null) throw new ArgumentException(nameof(collection));
        collection.Sort();
        return collection;
    }
    /// <summary>
    /// Sorts the elements in the entire <see cref="List{T}"/> using the specified comparer and returns the sorted list.
    /// <example><code>
    /// var fruits = new List&lt;string&gt;{ "banana", "apple", "cherry" };
    /// var result = fruits.Sorted(StringComparer.OrdinalIgnoreCase).Join(",")
    /// //-> apple,banana,cherry
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="collection">The list to sort. Must not be null.</param>
    /// <param name="comparer">The comparer to use for sorting, or null to use the default comparer.</param>
    /// <returns>The sorted <see cref="List{T}"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="collection"/> is null.</exception>
    public static List<T> Sorted<T>(this List<T> collection, IComparer<T> comparer = null)
    {
        if (collection is null) throw new ArgumentException(nameof(collection));
        collection.Sort(comparer);
        return collection;
    }
    /// <summary>
    /// Sorts the elements in the entire <see cref="List{T}"/> using the specified comparison function and returns the sorted list.
    /// <example><code>
    /// var people = new List&lt;Person&gt;(){
    ///     new Person(){Name="Alice", Age=30}
    ///     new Person(){Name="Bob", Age=25}
    ///     new Person(){Name="Charlie", Age=35}
    /// }.Sorted((p1, p2) => p1.Age.CompareTo(p2.Age))
    /// .Join(",", p => $"{p.Name} : {p.Age}");
    /// //-> Bob : 25,Alice : 30,Charlie : 35
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="collection">The list to sort. Must not be null.</param>
    /// <param name="comparison">The comparison function to use for sorting, or null to use the default comparer.</param>
    /// <returns>The sorted <see cref="List{T}"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="collection"/> is null.</exception>
    public static List<T> Sorted<T>(this List<T> collection, Comparison<T> comparison = null)
    {
        if (collection is null) throw new ArgumentException(nameof(collection));
        collection.Sort(comparison);
        return collection;
    }
    /// <summary>
    /// Sorts a range of elements in the <see cref="List{T}"/>, using the specified comparer and returns the sorted list.
    /// <example><code>
    /// var numbers = new List&lt;int&gt; { 5, 3, 8, 1, 2 };
    /// var sortedRange = numbers.Sorted(1, 3).Join(", ");
    /// // -> 5, 1, 3, 8, 2
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="collection">The list to sort. Must not be null.</param>
    /// <param name="index">The zero-based starting index of the range to sort.</param>
    /// <param name="count">The number of elements to sort.</param>
    /// <param name="comparer">The comparer to use for sorting, or null to use the default comparer.</param>
    /// <returns>The <see cref="List{T}"/> with the specified range sorted.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="collection"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="index"/> or <paramref name="count"/> is outside the valid range of the list.
    /// </exception>
    public static List<T> Sorted<T>(this List<T> collection, int index, int count, IComparer<T> comparer = null)
    {
        if (collection is null) throw new ArgumentException(nameof(collection));
        collection.Sort(index, count, comparer);
        return collection;
    }
}
