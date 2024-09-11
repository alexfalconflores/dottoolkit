# Math
> ```csharp
> using DotToolkit.Math;
> ```

## Fibonacci
Calculates the Fibonacci number at the position specified by `n`.
```csharp
int position = 10;
ulong fibonacciNumber = position.Fibonacci();
// -> 55
```

## IsEven
`Return` Check if a number is even.
```csharp
int number = 4;
bool isEven = number.IsEven();
// -> true;
```

## Evens
`Return` a sequence of even numbers from 0 to the value specified by `number`.
```csharp
List<int> res = 10.Evens().ToList();
foreach (var item in res)
    Console.WriteLine(item);
// { 0, 2, 4, 6, 8, 10}
```

## IsOdd
`Return` Check if the specified number is odd.
```csharp
var res = 5.IsOdd();
// -> true
```

## Odds
`Return` a sequence of odd numbers from `0` to the value specified by `number`.
```csharp
List<int> res = 10.Odds().ToList();
foreach (var item in res)
    Console.WriteLine(item);
// { 1, 3, 5, 7, 9 }
```

## IsDivisibleBy
Check if a number is divisible by another number. `Return` `true` if the number is divisible by the divisor, otherwise `false`. If the `divider` is `0` it returns `false` thus avoiding an exception.
```csharp
var res = 10.IsDivisibleBy(2);
// -> true

var res = 10.IsDivisibleBy(0);
// -> false
```

## IsMultipleOf
Check if a number is a multiple of another number. `Returns` `true` if the `number` is multiple of `multiple`, otherwise `false`. If the `multiple` is `0` it returns `false` thus avoiding an exception.
```csharp
var res = 12.IsMultipleOf(3);
// -> true

var res = 12.IsMultipleOf(0);
// -> false
```

## IsPrime
Check if the number is prime. Return `true` if `number` is a prime number; otherwise, `false`.
```csharp
var res = 29.IsPrime();
// -> true

var res = 20.IsPrime();
// -> false
```

## Primes
Generates a sequence of prime numbers less than or equal to the specified value using the `Sieve of Euler algorithm`. `Return` a sequence of prime numbers.
```csharp
var res = 999_999.Primes().ToList();
// -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
```

## Primes - SieveOfAtkin
Generates a sequence of prime numbers less than or equal to the specified value using the `Sieve of Atkin algorithm`. `Return` a sequence of prime numbers.
```csharp
var res = 999_999.Primes().ToList();
// -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
```

## Primes - SegmentedSieve
Generates a sequence of prime numbers less than or equal to the specified value using the `Segmented Sieve algorithm`. `Return` a sequence of prime numbers.
```csharp
var res = 999_999.Primes().ToList();
// -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
```