using System.Collections.ObjectModel;

namespace DotToolkit.Extensions;

public static class ObservableCollectionExt
{
    /// <summary>
    /// Removes all elements from the <see cref="ObservableCollection{T}"/> that match the conditions defined by the specified <see cref="Predicate{T}"/>.
    /// <example><code>
    /// var people = new ObservableCollection&lt;Person&gt;{
    ///     new Person { Name = "Alice", Age = 17 },
    ///     new Person { Name = "Bob", Age = 22 },
    ///     new Person { Name = "Charlie", Age = 16 }
    /// }
    /// int removedCount = people.RemoveAll(p => p.Age &lt; 18);
    /// Console.WriteLine($"Number of people removed: {removedCount}");
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The <see cref="ObservableCollection{T}"/> from which elements will be removed.</param>
    /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the elements to remove.</param>
    /// <returns>The number of elements removed from the <see cref="ObservableCollection{T}"/></returns>
    /// <exception cref="ArgumentNullException">match is <see langword="null"/></exception>
    /// <remarks>
    /// This method iterates through the collection in reverse order to safely remove elements while avoiding issues with modifying the collection during iteration.
    /// The collection is locked to ensure thread safety while removing elements.
    /// </remarks>
    public static int RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match)
    {
        if (collection is null or { Count: 0 }) return 0;
        if (match is null) throw new ArgumentNullException(nameof(match), "The predicate cannot be null");

        int removedCount = 0;

        lock (collection)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (match(collection[i]))
                {
                    collection.RemoveAt(i);
                    removedCount++;
                }
            }
        }
        return removedCount;
    }
    /// <summary>
    /// Removes all elements from the <see cref="ObservableCollection{T}"/> that match the conditions defined by the specified predicate,
    /// and performs a specified action on each removed element.
    /// <example><code>
    /// var people = new ObservableCollection&lt;Person&gt;{
    ///     new Person { Name = "Alice", Age = 17 },
    ///     new Person { Name = "Bob", Age = 22 },
    ///     new Person { Name = "Charlie", Age = 16 }
    /// }
    /// int removedCount = people.RemoveAll(p => p.Age &lt; 18, p => {
    ///     Console.WriteLine($"Removed: {p.Name}, {p.Age} years old.");
    /// });
    /// Console.WriteLine($"Number of people removed: {removedCount}");
    /// </code></example>
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The <see cref="ObservableCollection{T}"/> from which elements will be removed.</param>
    /// <param name="match">The <see cref="Predicate{T}"/> that defines the conditions of the elements to remove.</param>
    /// <param name="onRemoved">The <see cref="Action{T}"/> to perform on each element that is removed from the collection.</param>
    /// <returns>The number of elements removed from the <see cref="ObservableCollection{T}"/>.</returns>
    /// <exception cref="ArgumentNullException">match is <see langword="null"/> or onRemoved is <see langword="null"/></exception>
    /// <remarks>
    /// This method iterates through the collection in reverse order to safely remove elements while avoiding issues with modifying
    /// the collection during iteration. The collection is locked to ensure thread safety while removing elements.
    /// </remarks>
    public static int RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match, Action<T> onRemoved)
    {
        if (collection is null or { Count: 0 }) return 0;
        if (match is null) throw new ArgumentNullException(nameof(match), "The predicate cannot be null");
        if (onRemoved is null) throw new ArgumentNullException(nameof(onRemoved), "The action cannot be null");

        int removedCount = 0;
        lock (collection)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (match(collection[i]))
                {
                    onRemoved?.Invoke(collection[i]);
                    collection.RemoveAt(i);
                    removedCount++;
                }
            }
        }
        return removedCount;
    }
}