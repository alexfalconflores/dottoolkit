# Extensions
`List Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## Sorted
Sorts the elements in the entire `List` in the default order and returns the sorted list.
`Return` The sorted `List`.
```csharp
List<string>names = ["John", "Alex", "Zara"]; // C#12 Syntax
var result = names.Sorted().Join(",")
//-> Alex,John,Zara

var numbers = new List<int>{ 5, 3, 8, 1, 2 }; // &lt;= C# 11 Syntax
var result = numbers.Sorted().Join(",")
//-> 0,1,2,6,7,8,9,10,20,30
```

## Sorted (`IComparer comparer`)
Sorts the elements in the entire `List` using the specified comparer and returns the sorted list.
`Return` The sorted `List`.
```csharp
var fruits = new List<string>{ "banana", "apple", "cherry" };
var result = fruits.Sorted(StringComparer.OrdinalIgnoreCase).Join(",")
//-> apple,banana,cherry
```

## Sorted (`Comparison comparison`)
Sorts the elements in the entire `List` using the specified comparison function and returns the sorted list.
`Return` The sorted `List`.
```csharp
var people = new List<Person>(){
    new Person(){Name="Alice", Age=30}
    new Person(){Name="Bob", Age=25}
    new Person(){Name="Charlie", Age=35}
}.Sorted((p1, p2) => p1.Age.CompareTo(p2.Age))
.Join(",", p => $"{p.Name} : {p.Age}");
//-> Bob : 25,Alice : 30,Charlie : 35
```

## Sorted (`int index, int count, IComparer comparer`)
Sorts a range of elements in the `List`, using the specified comparer and returns the sorted list.
`Return` The `List` with the specified range sorted.
```csharp
var numbers = new List<int> { 5, 3, 8, 1, 2 };
var sortedRange = numbers.Sorted(1, 3).Join(", ");
// -> 5, 1, 3, 8, 2
```
