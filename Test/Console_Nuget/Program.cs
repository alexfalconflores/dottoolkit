using Console_Nuget.Model;
using DotToolkit.Extensions;
using DotToolkit.Math;
using Tiempo;

//Console.WriteLine(20.IsPrime());


//var date = new DateTime(2024, 8, 31, 10, 0, 0, 0, 0);
//var nextWednesday = date.NextDay(DayOfWeek.Wednesday);
//var day = date.AddDays(2);
//var week = date.AddDays(2 * 7).AddDays(1);
//var dayOfWeek = date.DayOfWeek;
//var dayOfWeek2 = day.DayOfWeek;
//var dayOfWeek3 = week.DayOfWeek;
//Console.WriteLine(date);
//Console.WriteLine(dayOfWeek);
//Console.WriteLine(nextWednesday);
//Console.WriteLine(nextWednesday.DayOfWeek);

//Console.WriteLine(dayOfWeek2);

//Console.WriteLine(dayOfWeek3);

var people = new List<Person>()
{
    new(){Name="Alice",Age=30},
    new(){Name="Bob", Age=25},
    new(){Name="Charlie", Age=35}
}
.Sorted((p1, p2) => p1.Age.CompareTo(p2.Age))
.Join(",", p => $"{p.Name} : {p.Age}");

Console.WriteLine(people);