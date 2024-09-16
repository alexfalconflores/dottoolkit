using BenchmarkDotNet.Attributes;
using System.Text;

namespace Console_Test;

public class ReverseBenchMark
{
    [Params("Otorrinolaringologia", "Alex", "a", "AlexStefanoFalconFlores")]
    public string Value;

    [Benchmark]
    public string Reverse()
    {
        return string.Concat(Value.Reverse());
    }
    [Benchmark]
    public string ReverseString()
    {
        return Value.ReverseString();
    }

    [Benchmark]
    public string Reverse_Builder()
    {
        return Value.Reverse_Builder();
    }
}

static file class Test
{
    public static string ReverseString(this string input)
    {
        var reversed = input.Reverse();
        return string.Concat(reversed);
    }
    public static string Reverse_Builder(this string input)
    {
        if (input is null) return string.Empty;
        var length = input.Length;
        var builder = new StringBuilder(length);
        for (int i = length - 1; i >= 0; i--) builder.Append(input[i]);
        return builder.ToString();
    }
}