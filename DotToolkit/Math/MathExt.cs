using System.Collections.Generic;

namespace DotToolkit.Math;

public static class MathExt
{
    /// <summary>
    /// Get
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Check if a number is even
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsEven(this int number) => number % 2 == 0;
    /// <summary>
    /// Return a sequence of even numbers up to the given number.
    /// <para>Output: { 0, 2, 4, 6, 8, 10}</para>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Evens(this int number)
    {
        for (int i = 0; i <= number; i += 2)
            yield return i;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsOdd(this int number) => number % 2 != 0;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Odds(this int number)
    {
        for (int i = 1; i <= number; i += 2)
            yield return i;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <param name="divider"></param>
    /// <returns></returns>
    public static bool IsDivisibleBy(this int number, int divider) => divider != 0 && number % divider == 0;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <param name="multiple"></param>
    /// <returns></returns>
    public static bool IsMultipleOf(this int number, int multiple) => multiple != 0 && number % multiple == 0;
    /// <summary>
    /// Check if the number is prime.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false; // 0,1 and negative numbers are not prime.
        if (number == 2) return true; // 2 is the only even prime number
        if (number % 2 == 0) return false; // Avoid all even numbers greater than 2
        int limit = (int)System.Math.Sqrt(number);
        for (int i = 3; i <= limit; i+=2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns></returns>
    public static IEnumerable<int> Primes(this int quantity)
    {
        //SieveOfEratosthenes
        if (quantity < 2)
            yield break; // There ar no prime numbers less than 2
        // Create a list of booleans, initialized to true
        bool[] isPrime = new bool[quantity + 1];
        for (int i = 2; i < quantity; i++)
            isPrime[i] = true;
        // Implementing the Eratosthenes Sieve
        for (int i = 2; i * i <= quantity; i++)
            if (isPrime[i])
                for (int j = i * i; j <= quantity; j += i)
                    isPrime[j] = false;
        // Generate prime numbers
        for (int i = 2; i<=quantity; i++)
            if(isPrime[i])
                yield return i;
    }
}
