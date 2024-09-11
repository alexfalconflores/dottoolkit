//using BenchmarkDotNet.Running;
//using Console_Test;
using DotToolkit.Math;
string str = string.Empty;
List<int> res = 999_999.Primes().ToList();
foreach (var item in res)
    str += item + ", ";
Console.WriteLine(str);
//Console.WriteLine(20.IsPrime());

//BenchmarkRunner.Run<Fibo>();

//BenchmarkRunner.Run<Prime>();