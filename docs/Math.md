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

## IsBetween
`Return` Check if the number is between two numbers.
```csharp
var res = 5.IsBetween(-5, 4)
// -> false

var res = (-5).IsBetween(-5, 4)
// -> true
```

## IsPositive
`Return` Check if the number is positive. Zero is considered positive or negative.
```csharp
var res = 5.IsPositive()
// -> true

var res = 5.5.IsPositive()
// -> true

var res = (-5).IsPositive()
// -> false
```

## IsNegative
`Return` Check if the number is negative. Zero is considered positive or negative.
```csharp
var res = 5.IsNegative()
// -> false

var res = (-5.5).IsNegative()
// -> true

var res = (-5).IsNegative()
// -> true
```

## IsZero
`Return` Check if the number is zero.
```csharp
var res = 5.IsZero()
// -> false

var res = (-5.5).IsZero()
// -> false

var res = 0.IsZero()
// -> true
```

## IsInteger
`Return` Check if the number is integer. 
> Byte(byte) => 8bits, SByte(sbyte) => 8bits, Int16(short) => 16bits, UInt16(ushort) => 16bits, Int32(int) => 32bits, UInt32(uint) => 32bits, Int64(long) => 64bits, UInt64(ulong) => 64bits, BigInteger.

```csharp
var res = 5.IsInteger()
// -> true

var res = (-5.5).IsInteger()
// -> false

var res = 0.IsInteger()
// -> true
```


## IsDecimal
`Return` Check if the number is decimal. 
> Single(float) => 32bits, Double(double) => 64bits, Decimal(decimal) => 128bits.

```csharp
var res = 5.IsDecimal()
// -> false

var res = (-5.5).IsDecimal()
// -> true

var res = 5.5.IsDecimal()
// -> true
```

## IsBigInteger
`Return` Check if the number is an integer of arbitrary precision.
```csharp
var res = (-5.5).IsBigInteger()
// -> false

var res = 5.IsBigInteger()
// -> true

var res = ((BigInteger)5).IsBigInteger()
// -> true

var res = ((BigInteger)5.5).IsBigInteger()
// -> true
```

## IsComplex
`Return` Check if the number represents a complex number, which has a real part and an imaginary part.
```csharp
var res = 5.IsComplex()
// -> false

Complex complex = new Complex(1, 1.2);
var res = complex.IsComplex()
// -> true

var res = complex.Real.IsComplex()
// -> false

var res = complex.Imaginary.IsComplex()
// -> false
```

## IsNatural
`Return` Check if the number is natural. Zero is considered natural default, but you can change it.
```csharp
BigInteger bigInteger = (BigInteger)1.1;
var res = bigInteger.IsNatural();
//-> true

var res = 0.IsNatural();
// -> true

var res = 0.IsNatural(false);
// -> false

var res = 5.2m.IsNatural();
// -> false

var res = 5.IsNatural();
// -> true

var res = (-5).IsNatural();
// -> false
```

## Factorial
> New

Calculates the factorial of a non-negative integer. `Return` The result is limited by the maximum value of `ulong`, which is `18,446,744,073,709,551,615`. Factorials of numbers greater than 20 will exceed this limit and cause an overflow, leading to incorrect results.
```csharp
ulong fac = 20.Factorial();
// -> 2432902008176640000
```

## FactorialBigInteger
> New

Calculates the factorial of a non-negative integer using a parallel approach. 
The calculation is optimized to run on multiple processor cores.
`Return` The factorial of the given number as a BigInteger.
```csharp
BigInteger res = 50.FactorialBigInteger();
//->30414093201713378043612608166064768844377641568960512000000000000
```
