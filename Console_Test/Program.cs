//using BenchmarkDotNet.Running;
//using Console_Test;
using DotToolkit.Math;
string str = string.Empty;
//List<int> res = 999_999.Primes().ToList();
//List<int> res = 999_999.SieveOfAtkin().ToList();
List<int> res = 999_999.SegmentedSieve().ToList();
foreach (var item in res)
    str += item + ", ";
Console.WriteLine(str);
//Console.WriteLine(20.IsPrime());

//BenchmarkRunner.Run<Fibo>();

//BenchmarkRunner.Run<Prime>();