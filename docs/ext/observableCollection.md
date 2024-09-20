# Extensions
`ObservableCollection Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## RemoveAll (Predicate match)
Removes all elements from the `ObservableCollection` that match the conditions defined by the specified `Predicate`.
`Return` The number of elements removed from the `ObservableCollection`.
```csharp
var people = new ObservableCollection<Person>{
    new Person { Name = "Alice", Age = 17 },
    new Person { Name = "Bob", Age = 22 },
    new Person { Name = "Charlie", Age = 16 }
}
int removedCount = people.RemoveAll(p => p.Age < 18);
// -> 2
```

## RemoveAll (Predicate match, Action onRemoved)
Removes all elements from the `ObservableCollection` that `match` the conditions defined by the specified `predicate`, and performs a specified action on each removed element.
`Return` The number of elements removed from the `ObservableCollection`.
```csharp
var people = new ObservableCollection<Person>{
    new Person { Name = "Alice", Age = 17 },
    new Person { Name = "Bob", Age = 22 },
    new Person { Name = "Charlie", Age = 16 }
}
int removedCount = people.RemoveAll(p => p.Age &lt; 18, p => {
    Console.WriteLine($"Removed: {p.Name}, {p.Age} years old.");
});
//-> 2
```

## ToObservableCollection
Converts an `IEnumerable` to an `ObservableCollection`.
`Return` An `ObservableCollection` containing the elements from the source collection.

```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 }.ToObservableCollection();

var wordSet = new HashSet<string> { "dog", "cat", "fish" }.ToObservableCollection();

var array = new int[] { 1, 2, 3, 4, 5 }.ToObservableCollection();
```
