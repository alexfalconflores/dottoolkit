//using BenchmarkDotNet.Running;
//using Console_Test;
using DotToolkit.Math;
using System.Numerics;
//string str = string.Empty;
//List<int> res = 999_999.Primes().ToList();
//List<int> res = 999_999.SieveOfAtkin().ToList();
//List<int> res = 999_999.SegmentedSieve().ToList();
//foreach (var item in res)
//    str += item + ", ";
//Console.WriteLine(str);

//Console.WriteLine(20.IsPrime());

//Console.WriteLine(5.IsBetween(-5, 4));
//Console.WriteLine((-5).IsBetween(-5, 4));
//Console.WriteLine(5.IsPositive());
//Console.WriteLine(5.5.IsPositive());
//Console.WriteLine((-5).IsPositive());

//Console.WriteLine(5.IsNegative());
//Console.WriteLine((-5.5).IsNegative());
//Console.WriteLine((-5).IsNegative());

//Console.WriteLine(5.IsZero());
//Console.WriteLine((-5.5).IsZero());
//Console.WriteLine(0.IsZero());

//Console.WriteLine(5.IsInteger());
//Console.WriteLine((-5.5).IsInteger());
//Console.WriteLine(0.IsInteger());

//Console.WriteLine(5.IsDecimal());
//Console.WriteLine(5.5.IsDecimal());
//Console.WriteLine((-5.5).IsDecimal());

//Console.WriteLine((-5.5).IsBigInteger());
//Console.WriteLine(5.IsBigInteger());
//Console.WriteLine(((BigInteger)5).IsBigInteger());
//Console.WriteLine(((BigInteger)5.5).IsBigInteger());

Complex complex = new(1, 1.2);
Console.WriteLine(5.IsComplex());
Console.WriteLine(complex.IsComplex());
Console.WriteLine(complex.Real.IsComplex());
Console.WriteLine(complex.Imaginary.IsComplex());

//BigInteger bigInteger = (BigInteger)1.1;
//Console.WriteLine(complex.Imaginary);
//Console.WriteLine(bigInteger.IsNatural());
//Console.WriteLine(0.IsNatural());
//Console.WriteLine(0.IsNatural(false));
//Console.WriteLine(5.2m.IsNatural());
//Console.WriteLine(5.IsNatural());
//Console.WriteLine((-5).IsNatural());

//BenchmarkRunner.Run<Fibo>();

//BenchmarkRunner.Run<Prime>();