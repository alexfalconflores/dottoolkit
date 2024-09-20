# Extensions
`Collection Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## Fill
Fills the specified collection with a given value up to the specified quantity. If the collection is not empty and `canOverwrite` is `true`, it will be cleared before adding new elements.
`Return` The filled collection. Returns the same collection instance after adding the specified number of elements.
```csharp
var numbers = new List<int>().Fill(4,4);
numbers.Fill(5,5);
//-> 4,4,4,4,5,5,5,5,5
```

## RandomChoice
Selects a random element from the specified collection.
`Return` A randomly selected element from the collection.
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var randomNumber = numbers.RandomChoice();
//-> 2

var wordSet = new HashSet<string> { "dog", "cat", "fish" };
var randomWordFromSet = wordSet.RandomChoice();
//-> fish
```
