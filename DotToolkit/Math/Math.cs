namespace DotToolkit.Math;

public static class Math
{
    public static ulong Fibonacci(this int n)
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
}
