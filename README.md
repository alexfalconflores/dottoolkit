![DotToolkit Cover](assets/dottoolkit-cover.svg)

# DotToolkit

[![NuGet](https://img.shields.io/nuget/dt/DotToolkit.svg)](https://www.nuget.org/stats/packages/DotToolkit?groupby=Version) 
[![NuGet](https://img.shields.io/nuget/vpre/DotToolkit.svg)](https://www.nuget.org/packages/DotToolkit/)
<a href="https://www.nuget.org/packages/DotToolkit">
    <img src="https://raw.githubusercontent.com/alexfalconflores/alexfalconflores/main/img/nuget-banner.svg" height=20 alt="Go to Nuget"/>
</a>


## Installation 📦
This project is available as a [NuGet package](https://www.nuget.org/packages/DotToolkit). You can install it using the NuGet Package Console window:
```bash
dotnet add package DotToolkit --version 1.3.0
```

## Documentation 📖
- [Math](docs/Math.md)
    - [Fibonacci](docs/Math.md#fibonacci)
    - [IsEven](docs/Math.md#iseven)
    - [Evens](docs/Math.md#evens)
    - [IsOdd](docs/Math.md#isodd)
    - [Odds](docs/Math.md#odds)
    - [IsDivisibleBy](docs/Math.md#isdivisibleby)
    - [IsMultipleOf](docs/Math.md#ismultipleof)
    - [IsPrime](docs/Math.md#isprime)
    - [Primes](docs/Math.md#primes)
    - [Primes - SieveOfAtkin](docs/Math.md#primes---sieveofatkin)
    - [Primes - SegmentedSieve](docs/Math.md#primes---segmentedsieve)
    - [IsBetween](docs/Math.md#isbetween)
    - [IsPositive](docs/Math.md#ispositive)
    - [IsNegative](docs/Math.md#isnegative)
    - [IsZero](docs/Math.md#iszero)
    - [IsInteger](docs/Math.md#isinteger)
    - [IsDecimal](docs/Math.md#isdecimal)
    - [IsBigInteger](docs/Math.md#isbetween)
    - [IsComplex](docs/Math.md#iscomplex)
    - [IsNatural](docs/Math.md#isnatural)
    - [Factorial](docs/Math.md#factorial) `new`
    - [FactorialBigInterger](docs/Math.md#factorialbiginteger) `new`
- [Extensions](docs/Extensions.md) `new`
    - [String Category](docs/ext/string.md)
      - [IsNullOrEmpty](docs/ext/string.md#isnullorempty)
      - [IsNullOrWhiteSpace](docs/ext/string.md#isnullorwhitespace)
      - [Join](docs/ext/string.md#join-string-separator)
      - [Join(formatFunc)](docs/ext/string.md#join-string-separator-funct-string-formatfunc)
      - [Repeat](docs/ext/string.md#repeat)
      - [ToCamelCase](docs/ext/string.md#tocamelcase)
      - [ToPascalCase](docs/ext/string.md#topascalcase)
      - [ToKebabCase](docs/ext/string.md#tokebabcase)
      - [ToSnakeCase](docs/ext/string.md#tosnakecase)
      - [HtmlEscape](docs/ext/string.md#htmlescape)
      - [HtmlUnEscape](docs/ext/string.md#htmlunescape)
      - [ReverseString](docs/ext/string.md#reversestring)
      - [ToChar](docs/ext/string.md#tochar)
    - [Number Category](docs/ext/number.md)
      - [IsNaN(double)](docs/ext/number.md#isnan-double)
      - [IsNaN(float)](docs/ext/number.md#isnan-float)
      - [ToByte](docs/ext/number.md#tobyte)
      - [ToSByte](docs/ext/number.md#tosbyte)
      - [ToShort](docs/ext/number.md#toshort)
      - [ToUShort](docs/ext/number.md#toushort)
      - [ToInt](docs/ext/number.md#toint)
      - [ToUInt](docs/ext/number.md#touint)
      - [ToLong](docs/ext/number.md#tolong)
      - [ToULong](docs/ext/number.md#toulong)
      - [ToFloat](docs/ext/number.md#tofloat)
      - [ToDecimal](docs/ext/number.md#todecimal)
      - [ToDouble](docs/ext/number.md#todouble)
    - [Bool Category](docs/ext/bool.md)
      - [ToBool](docs/ext/bool.md#tobool)
    - [ObservableCollection Category](docs/ext/observableCollection.md)
      - [RemoveAll(Prediceate match)](docs/ext/observableCollection.md#removeall-predicate-match)
      - [RemoveAll(Prediceate match, Action onRemoved)](docs/ext/observableCollection.md#removeall-predicate-match-action-onremoved)
      - [ToObservableCollection](docs/ext/observableCollection.md#toobservablecollection)
    - [Collection Category](docs/ext/collection.md)
      - [Fill](docs/ext/collection.md#fill)
      - [RandomChoice](docs/ext/collection.md#randomchoice)
    - [Collection Category](docs/ext/collection.md)
      - [Fill](docs/ext/collection.md#fill)
      - [RandomChoice](docs/ext/collection.md#randomchoice)
    - [List Category](docs/ext/list.md)
      - [Sorted](docs/ext/list.md)
    - [Array Category](docs/ext/array.md)
      - [Sorted](docs/ext/array.md#sorted)
    

## Library Dependencies 📚
- PolySharp
