using BenchmarkDotNet.Attributes;

namespace Console_Test;

public class Fibo
{
    [Params(10000)]
    public int Number;

    //[Benchmark]
    //public long Fibonachi_Recursive()
    //{
    //    return Number.Fibonachi_Recursive();
    //}

    [Benchmark]
    public ulong Fibonachi_Iterative()
    {
        return Number.Fibonachi_Iterative();
    }

    //[Benchmark]
    //public List<ulong> Fibonachi_Iterative()
    //{
    //    return Number.Fibonachi_Iterative();
    //}
}

static file class Test
{
    public static long Fibonachi_Recursive(this int number)
    {
        if (number == 0) return 0;
        if (number < 2) return 1;
        return Fibonachi_Recursive(number - 1) + Fibonachi_Recursive(number - 2);
    }

    public static ulong Fibonachi_Iterative(this int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        ulong a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }

    //public static long Negafibonacci(int n)
    //{
    //    // Asegúrate de que n sea negativo
    //    n = Math.Abs(n);

    //    // Fórmula: F(-n) = (-1)^(n + 1) * F(n)
    //    long fib = Fibonacci(n);
    //    return (n % 2 == 0) ? -fib : fib;
    //}


    //public static List<ulong> Fibonachi_Iterative(this int number)
    //{
    //    if (number < 0) throw new ArgumentOutOfRangeException(nameof(number), "number must be greater than or equal to 0.");
    //    List<ulong> list = [0, 1];
    //    if (number <= 1) return list.GetRange(0, (number + 1));
    //    for (int i = 2; i < number; i++) list.Add(list[i - 1] + list[i - 2]);
    //    return list;
    //}
}