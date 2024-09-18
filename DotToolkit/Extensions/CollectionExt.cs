namespace DotToolkit.Extensions;

public static class CollectionExt
{
    /// <summary>
    /// Fills the specified collection with a given value up to the specified quantity.
    /// If the collection is not empty and <paramref name="canOverwrite"/> is true, it will be cleared before adding new elements.
    /// </summary>
    /// <typeparam name="TCollection">The type of the collection. It must implement <see cref="ICollection{TValue}"/>.</typeparam>
    /// <typeparam name="TValue">The type of the value to add to the collection. It represents the elements to be added to the collection.</typeparam>
    /// <param name="collection">The collection to be filled. It must be a collection that implements <see cref="ICollection{TValue}"/>.</param>
    /// <param name="quantity">The number of elements to add to the collection. Must be greater than zero.</param>
    /// <param name="value">The value to add to the collection. This value will be added multiple times based on <paramref name="quantity"/>.</param>
    /// <param name="canOverwrite">A boolean flag indicating whether to clear the collection before adding new elements. If true, the collection will be cleared; if false, existing elements will be preserved.</param>
    /// <returns>The filled collection. Returns the same collection instance after adding the specified number of elements.</returns>
    /// <example><code>
    /// var numbers = new List<int>().Fill(4,4);
    /// numbers.Fill(5,5);
    /// //-> 4,4,4,4,5,5,5,5,5
    /// </code></example>
    public static TCollection Fill<TCollection, TValue>(this TCollection collection, int quantity, TValue value, bool canOverwrite = false) where TCollection : ICollection<TValue>
    {
        if (collection is null) return collection;
        if (quantity <= 0) return collection;
        if (canOverwrite) collection.Clear();
        for (int i = 0; i < quantity; i++)
            collection.Add(value);
        return collection;
    }
    /// <summary>
    /// Selects a random element from the specified collection.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the collection.</typeparam>
    /// <param name="collection">The collection from which to select a random element. It must not be null or empty.</param>
    /// <returns>A randomly selected element from the collection.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="collection"/> is empty.</exception>
    /// <example><code>
    /// var numbers = new List<int> { 1, 2, 3, 4, 5 };
    /// var randomNumber = numbers.RandomChoice();
    /// //-> 2
    /// 
    /// var wordSet = new HashSet<string> { "dog", "cat", "fish" };
    /// var randomWordFromSet = wordSet.RandomChoice();
    /// //-> fish
    /// </code></example>
    public static T RandomChoice<T>(this ICollection<T> collection)
    {
        if (collection is null) throw new ArgumentNullException(nameof(collection));
        if (!collection.Any()) throw new ArgumentException("The source collection is empty.", nameof(collection));
        var random = new Random();
        var index = random.Next(collection.Count);
        return collection.ElementAt(index);
    }
}
