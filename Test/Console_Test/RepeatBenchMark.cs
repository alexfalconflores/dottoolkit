using BenchmarkDotNet.Attributes;
using System.Text;

namespace Console_Test;

public class RepeatBenchMark
{
    [Params(5,99,999,9_999,99_999,999_999,9_999_999)]
    public int Number;
    [Params("Otorrinolaringologia")]
    public string Value;
    //[Benchmark]
    //public string Repeat()
    //{
    //    return Value.Repeat(Number);
    //}

    [Benchmark]
    public string RepeatBuilder()
    {
        return Value.Repeat_Builder(Number);
    }
}

static file class Test
{
    public static string Repeat(this string input, int numberRepeat = 1)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        string result = "";
        for (int i = 0; i < numberRepeat; i++)
            result += input;
        return result;
    }

    public static string Repeat_Builder(this string input, int numberRepeat = 1)
    {
        if (numberRepeat <= 0 || input is null) return string.Empty;
        var builder = new StringBuilder(input.Length * numberRepeat);
        for (int i = 0; i < numberRepeat; i++) builder.Append(input);
        return builder.ToString();
    }
}