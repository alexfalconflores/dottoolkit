﻿namespace Console_Test.model;

public class Person
{
    public string Name { get; set; }
    public override string ToString() => Name;
}

public class Person2
{
    public string Name { set; get; }
    public int Age { set; get; }
}
