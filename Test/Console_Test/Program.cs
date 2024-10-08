﻿using BenchmarkDotNet.Running;
using Console_Test;
using Console_Test.enums;
using Console_Test.model;
using DotToolkit.Extensions;
using DotToolkit.Math;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
//using System.Numerics;
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

//Complex complex = new(1, 1.2);
//Console.WriteLine(5.IsComplex());
//Console.WriteLine(complex.IsComplex());
//Console.WriteLine(complex.Real.IsComplex());
//Console.WriteLine(complex.Imaginary.IsComplex());

//Console.WriteLine(complex.Imaginary);
//BigInteger bigInteger = (BigInteger)1.1;
//Console.WriteLine(bigInteger.IsNatural());
//Console.WriteLine(0.IsNatural());
//Console.WriteLine(0.IsNatural(false));
//Console.WriteLine(5.2m.IsNatural());
//Console.WriteLine(5.IsNatural());
//Console.WriteLine((-5).IsNatural());

//BenchmarkRunner.Run<Fibo>();

//BenchmarkRunner.Run<Prime>();

//string str1 = null;
//string str2 = "";
//string str3 = "   "; // Only white-space characters
//string str4 = "Hello, World!";

//Console.WriteLine(str1.IsNullOrWhiteSpace());
//Console.WriteLine(str2.IsNullOrWhiteSpace());
//Console.WriteLine(str3.IsNullOrWhiteSpace());
//Console.WriteLine(str4.IsNullOrWhiteSpace());

//List<string> fruits = new() { "Apple", "Banana", "Cherry" };
//string result = fruits.Join(", ");
//Console.WriteLine(result); // Output: "Apple, Banana, Cherry"

//List<string> emptyList = new List<string>();
//string result2 = emptyList.Join(", ");
//Console.WriteLine(result2); // Output: ""

//List<string> singleItem = new List<string> { "Orange" };
//string result3 = singleItem.Join(", ");
//Console.WriteLine(result3); // Output: "Orange"

//List<string> names = new List<string> { "John", "Jane" };
//string result4 = names.Join(null);
//Console.WriteLine(result4); // Output: "JohnJane" (sin separador)

//List<string>? nullList = null;
//string result5 = nullList.Join(", ");
//Console.WriteLine(result5); // Output: ""

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//string result6 = numbers.Join(" - ");
//Console.WriteLine(result6); // Output: "1 - 2 - 3 - 4 - 5"

//var people = new List<Person>
//{
//    new Person { Name = "Alice" },
//    new Person { Name = "Bob" },
//    new Person { Name = "Charlie" }
//};

//string result7 = people.Join(", ");
//Console.WriteLine(result7); // Output: "Alice, Bob, Charlie"

//object[] values = { "Apple", 42, 3.14, true };
//string result = values.Join(", ");
//Console.WriteLine(result); // Output: "Apple, 42, 3.14, True"

//object[] values2 = { "Apple", "Banana", "Cherry" };
//string result2 = values.Join(null);
//Console.WriteLine(result2); // Output: "AppleBananaCherry"

//object[] values3 = { };
//string result3 = values.Join(", ");
//Console.WriteLine(result3); // Output: ""

//object[]? values4 = null;
//string result4 = values.Join(", ");
//Console.WriteLine(result); // Output: ""

//string[] values = { "Apple", "Banana", "Cherry" };
//string result = values.Join(", ");
//Console.WriteLine(result); // Output: "Apple, Banana, Cherry"

//string[] values2 = { "Apple", "Banana", "Cherry" };
//string result2 = values2.Join(null);
//Console.WriteLine(result2); // Output: "AppleBananaCherry"

//string[] values3 = { };
//string result3 = values3.Join(", ");
//Console.WriteLine(result3); // Output: ""

//string[]? values4 = null;
//string result4 = values4.Join(", ");
//Console.WriteLine(result4); // Output: ""


//var words = new List<string> { "Hello", "World", "Foo", "Bar" };
//string result = words.Join(", ");
//Console.WriteLine(result);

//var emptyList = new List<string>();
//string result2 = emptyList.Join(", ");
//Console.WriteLine(result2);

//List<string>? nullList = null;
//string result3 = nullList.Join(", ");
//Console.WriteLine(result3);

//var wordsWithNullSeparator = new List<string> { "One", "Two", "Three" };
//string result4 = wordsWithNullSeparator.Join(null);
//Console.WriteLine(result4);

//string[] words = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
//// Concatenate from index 1 with count 3
//string result = words.Join(", ", 1, 3);
//Console.WriteLine(result);

//// Concatenate all elements
//string resultAll = words.Join(", ", 0, words.Length);
//Console.WriteLine(resultAll);

//// Concatenate with a null separator
//string resultNoSeparator = words.Join(null, 0, 5);
//Console.WriteLine(resultNoSeparator);

//// Attempting to include more elements than available
//string resultWithTooMany = words.Join(", ", 2, 10);
//Console.WriteLine(resultWithTooMany);

//using BenchmarkDotNet.Running;
//using Console_Test;

//BenchmarkRunner.Run<RepeatBenchMark>();

//string repeated = "Hello".Repeat(3);
//Console.WriteLine(repeated);

//string repeatedSingle = "World".Repeat();
//Console.WriteLine(repeatedSingle);

//string repeatedNegative = "Test".Repeat(-1);
//Console.WriteLine(repeatedNegative);

//string result1 = "___-__HELLO_WORLD_____".ToSnakeCase();
//Console.WriteLine(result1);

//string result2 = ((string?)null).ToSnakeCase();
//Console.WriteLine(result2);

//string result3 = "".ToSnakeCase();
//Console.WriteLine(result3);

//string result4 = "HELLO WORLD".ToSnakeCase();
//Console.WriteLine(result4);

//string result5 = "helloWorld".ToSnakeCase();
//Console.WriteLine(result5);

//string input1 = "Hello &amp; welcome";
//string escaped1 = input1.HtmlUnEscape();
//Console.WriteLine(escaped1);
//// escaped1 será "Hello &amp; welcome"

//string input2 = "&lt;div&gt;Example&lt;/div&gt;";
//string escaped2 = input2.HtmlUnEscape();
//Console.WriteLine(escaped2);
////escaped2 será "&lt;div&gt;Example&lt;/div&gt;"

//BenchmarkRunner.Run<ReverseBenchMark>();
//string original = "Hello, World!";
//string reversed = original.ReverseString();
//Console.WriteLine(reversed);  // Output: !dlroW ,olleH

//Console.WriteLine(20.Factorial());
//Console.WriteLine(50.FactorialBigInteger());

//var people = new ObservableCollection<Person2>
//{
//    new Person2 { Name = "Alice", Age = 17 },
//    new Person2 { Name = "Bob", Age = 22 },
//    new Person2 { Name = "Charlie", Age = 16 }
//};
////bool removedCount =  people.Remove(people[0]);
//int removedCount = people.RemoveAll(p => p.Age < 18, p =>
//{
//    Console.WriteLine($"Removed: {p.Name}, {p.Age} years old.");
//});

//Console.WriteLine($"Number of people removed: {removedCount}");

//foreach (var person in people)
//{
//    Console.WriteLine($"{person.Name}, {person.Age} years old");
//}

//var numbers = new List<int>().Fill(4, 4);
//numbers.Fill(5, 5);
//Console.WriteLine(numbers.Join(","));

//var numbers = new List<int> { 1, 2, 3, 4, 5 }.ToObservableCollection();
//var randomNumber = numbers.RandomChoice();
//Console.WriteLine($"Número aleatorio seleccionado de la lista: {randomNumber}");

//var wordSet = new HashSet<string> { "dog", "cat", "fish" }.ToObservableCollection();
//var randomWordFromSet = wordSet.RandomChoice();
//Console.WriteLine($"Palabra aleatoria seleccionada del conjunto: {randomWordFromSet}");

//var array = new int[] { 1, 2, 3, 4, 5 }.ToObservableCollection();
//var random = wordSet.RandomChoice();
//Console.WriteLine(random);

//int intValue = 1;
//bool result = intValue.ToBool(); // Output: true
//Console.WriteLine(result);

//string stringValue = "false";
//bool resultString = stringValue.ToBool(); // Output: false
//Console.WriteLine(resultString);

//List<string> names = ["John", "Alex", "Zara"];
//Console.WriteLine(names.Sorted().Join(","));

//List<int> numbers = [2, 6, 9, 10, 0, 1, 20, 30, 8, 7];
//Console.WriteLine(numbers.Sorted().Join(","));

//List<string> fruits = ["banana", "apple", "cherry"];
//Console.WriteLine(fruits.Sorted(StringComparer.OrdinalIgnoreCase).Join(","));

//int[] numbers2 = [2, 6, 9, 10, 0, 1, 20, 30, 8, 7];
//Console.WriteLine(numbers2.Sorted().Join(","));

//var people = new List<Person2>()
//{
//    new Person2(){Name="Alice",Age=30},
//    new Person2(){Name="Bob", Age=25},
//    new Person2(){Name="Charlie", Age=35}
//}
//.Sorted((p1, p2) => p1.Age.CompareTo(p2.Age))
//.Join(",", p => $"{p.Name} : {p.Age}");

//Console.WriteLine(people);

//var numbers3 = new List<int> { 5, 3, 8, 1, 2 };
//Console.WriteLine(numbers3.Sorted(1, 3).Join(", "));

//var obser = new int[] { 1, 2, 3, 4, 5 }.ToObservableCollection();
////obser.Sorted

//Dictionary<int, int> keyValuePairs = [];
//keyValuePairs.Add(1, 2);
//keyValuePairs.Add(2, 3);
//keyValuePairs.Add(3, 4);


var numbers = new int[] { 5, 3, 8, 1, 6 };
Console.WriteLine(numbers.Sorted(1, 3, Comparer<int>.Create((x, y) => y.CompareTo(x))).Join(","));