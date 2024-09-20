# Extensions
`Array Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## Sorted
Sorts the elements of an array.
`Return` The sorted array.
```csharp
var numbers = new int[] { 5, 3, 8, 1 };
var result = numbers.Sorted();
//-> 1, 3, 5, 8
```

## Sorted (`IComparer comparer`)
Sorts the elements of an array using a specified comparer.
`Return` The sorted array.
```csharp
var numbers = new int[] { 5, 3, 8, 1 };

var asc = numbers.Sorted(Comparer<int>.Create((x, y) => x.CompareTo(y))).Join(",");
// -> 1,3,5,8

var desc = numbers.Sorted(Comparer<int>.Create((x, y) => y.CompareTo(x))).Join(",");
// -> 8,5,3,1
```

## Sorted (`Comparison comparison`)
Sorts the elements of an array using a specified comparison delegate.
`Return` The sorted array.
```csharp
var numbers = new int[] { 5, 3, 8, 1 };

var asc = numbers.Sorted((x, y) => x.CompareTo(y)).Join(",");
// -> 1,3,5,8

var desc = numbers.Sorted((x, y) => y.CompareTo(x)).Join(",");
// -> 8,5,3,1
```

## Sorted (`int index, int length`)
Sorts a range of elements in an array.
`Return` The sorted array.
```csharp
var numbers = new int[] { 5, 3, 8, 1, 6 };
var res = numbers.Sorted(1, 3).Join(",");
// -> 5,1,3,8,6
```

## Sorted 
Sorts a range of elements in an array using a specified comparer.
`Return` The sorted array.
```csharp
var numbers = new int[] { 5, 3, 8, 1, 6 };
var desc = numbers.Sorted(1, 3, Comparer<int>.Create((x, y) => y.CompareTo(x))).Join(",");
// -> 5,8,3,1,6
```
