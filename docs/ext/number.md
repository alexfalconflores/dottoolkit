# Extensions
`Number Category`
> ```csharp
> using DotToolkit.Extensions;
> ```

## IsNaN (double)
`Return` Check if the number is NaN.
```csharp
double value = doble.NaN;
var result = value.IsNaN()
// -> true
```


## IsNaN (float)
`Return` Check if the number is NaN.
```csharp
float value = float.NaN;
var result = value.IsNaN()
// -> true
```

## ToByte
Converts the specified value to an 8-bit unsigned integer `byte`.
`Return` The 8-bit unsigned integer representation of the value.
```csharp
int value = 123;
byte result = value.ToByte();
//-> 123
```

## ToSByte
Converts the specified value to an 8-bit signed integer `sbyte`.
`Return` The 8-bit signed integer representation of the value.
```csharp
int value = -123;
sbyte result = value.ToSByte();
sbyte result = value.ToSByte();
//-> -123
```

## ToShort
Converts the specified value to a 16-bit signed integer `short`.
`Return` The 16-bit signed integer representation of the value.
```csharp
int value = 12345;
short result = value.ToShort();
//-> 12345
```

## ToUShort
Converts the specified value to a 16-bit unsigned integer `ushort`.
`Return` The 16-bit unsigned integer representation of the value.
```csharp
int value = 12345;
ushort result = value.ToUShort();
//-> 12345
```

## ToInt
Converts the specified value to a 32-bit signed integer `int`.
`Return` The 32-bit signed integer representation of the value.
```csharp
double value = 123.45;
int result = value.ToInt();
//-> 123
```

## ToUInt
Converts the specified value to a 32-bit unsigned integer `uint`.
`Return` The 32-bit unsigned integer representation of the value.
```csharp
double value = 123.45;
uint result = value.ToUInt();
//->123
```

## ToLong
Converts the specified value to a 64-bit signed integer `long`.
`Return` The 64-bit signed integer representation of the value.
```csharp
int value = 12345;
long result = value.ToLong();
// -> 12345
```

## ToULong
Converts the specified value to a 64-bit unsigned integer `ulong`.
`Return` The 64-bit unsigned integer representation of the value.
```csharp
int value = 12345;
ulong result = value.ToULong();
//-> 12345
```

## ToFloat
Converts the specified value to a single-precision floating point number `float`.
`Return` The single-precision floating point representation of the value.
```csharp
int value = 123;
float result = value.ToFloat();
//-> 123.0
```

## ToDecimal
Converts the specified value to a decimal number `decimal`.
`Return` The decimal number representation of the value.
```csharp
double value = 123.45;
decimal result = value.ToDecimal();
//->123.45
```

## ToDouble
Converts the specified value to a double-precision floating point number `double`.
`Return` The double-precision floating point representation of the value.
```csharp
int value = 123;
double result = value.ToDouble();
//->123.0
```