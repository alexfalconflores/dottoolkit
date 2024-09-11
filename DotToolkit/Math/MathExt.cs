using System.Collections.Generic;

namespace DotToolkit.Math;

public static class MathExt
{
    /// <summary>
    /// Calculates the Fibonacci numberat the position specified by <paramref name="n"/>
    /// </summary>
    /// <param name="n">The index of the Fibonacci sequence to be calculated. It must be a non-negative integer.</param>
    /// <returns>The Fibonacci number corresponding to the <paramref name="n"/>.</returns>
    /// <example><code>
    /// int position = 10;
    /// ulong fibonacciNumber = postion.Fibonacci();
    /// // -> 55
    /// </code></example>
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
    /// <example><code>
    /// int number = 4;
    /// bool isEven = number.IsEven();
    /// // -> true;
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsEven(this int number) => number % 2 == 0;
    /// <summary>
    /// Return a sequence of even numbers from 0 to the value specified by <paramref name="number"/>.
    /// <example><code>
    /// List<int> res = 10.Evens().ToList();
    /// foreach (var item in res)
    ///     Console.WriteLine(item);
    /// // { 0, 2, 4, 6, 8, 10}
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Evens(this int number)
    {
        for (int i = 0; i <= number; i += 2)
            yield return i;
    }
    /// <summary>
    /// Check if the specified numebr is odd.
    /// <example><code>
    /// var res = 5.IsOdd();
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsOdd(this int number) => number % 2 != 0;
    /// <summary>
    /// Return a sequence of odd numbers from 0 to the value specified by <paramref name="number"/>.
    /// <example><code>
    /// List<int> res = 10.Odds().ToList();
    /// foreach (var item in res)
    ///     Console.WriteLine(item);
    /// // { 1, 3, 5, 7, 9 }
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> Odds(this int number)
    {
        for (int i = 1; i <= number; i += 2)
            yield return i;
    }
    /// <summary>
    /// Check if a number is divisible by another number.
    /// <example><code>
    /// var res = 10.IsDivisibleBy(2);
    /// // -> true
    /// 
    /// var res = 10.IsDivisibleBy(0);
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <param name="divider"></param>
    /// <returns>Returns <c>true</c> if the number is divisible by the divisor, otherwise <c>false</c>.
    /// If the <paramref name="divider"/> is 0 it returns <c>false</c> thus avoiding an exception.</returns>
    public static bool IsDivisibleBy(this int number, int divider) => divider != 0 && number % divider == 0;
    /// <summary>
    /// Check if a number is a multiple of another number.
    /// <example><code>
    /// var res = 12.IsMultipleOf(3);
    /// // -> true
    /// 
    /// var res = 12.IsMultipleOf(0);
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <param name="multiple"></param>
    /// <returns>Returns <c>true</c> if the <paramref name="number"/> is multiple of <paramref name="multiple"/>, otherwise <c>false</c>.
    /// If the <paramref name="multiple"/> is 0 it returns <c>false</c> thus avoiding an exception.</returns>
    public static bool IsMultipleOf(this int number, int multiple) => multiple != 0 && number % multiple == 0;
    /// <summary>
    /// Check if the number is prime.
    /// <example><code>
    /// var res = 29.IsPrime();
    /// // -> true
    /// 
    /// var res = 20.IsPrime();
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <param name="number"></param>
    /// <returns><c>true</c> if <paramref name=“number”/> is a prime number; otherwise, <c>false</c>.</returns>
    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false; // 0,1 and negative numbers are not prime.
        if (number == 2) return true; // 2 is the only even prime number
        if (number % 2 == 0) return false; // Avoid all even numbers greater than 2
        int limit = (int)System.Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    /// <summary>
    /// Generates a sequence of prime numbers less than or equal to the specified value using the Sieve of Euler algorithm.
    /// <example><code>
    /// var res = 999_999.Primes().ToList();
    /// // -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
    /// </code></example>
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns>A sequence of prime numbers.</returns>
    public static IEnumerable<int> Primes(this int quantity)
    {
        //SieveOfEuler
        if (quantity < 2)
            yield break; // There ar no prime numbers less than 2
        // Create a list of booleans, initialized to true
        bool[] isPrime = new bool[quantity + 1];
        for (int i = 2; i < quantity; i++)
            isPrime[i] = true;
        //
        for (int i = 2; i <= quantity; i++)
        {
            if (isPrime[i])
            {
                yield return i; // i es primo
                for (int j = i * 2; j <= quantity; j += i)
                    isPrime[j] = false;
            }
        }
    }
    /// <summary>
    /// Generates a sequence of prime numbers less than or equal to the specified value using the Sieve of Atkin algorithm.
    /// <example><code>
    /// var res = 999_999.SieveOfAtkin().ToList();
    /// // -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
    /// </code></example>
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns>A sequence of prime numbers.</returns>
    public static IEnumerable<int> SieveOfAtkin(this int limit)
    {
        // Initialize the sieve array with false values
        bool[] isPrime = new bool[limit + 1];

        //Base cases for small numbers
        if (limit > 2) yield return 2;
        if(limit > 3) yield return 3;

        // Step 1: Mark numbers using the Atkin rules
        for (int x = 1; x * x <= limit; x++)
        {
            for (int y = 1; y * y <= limit; y++)
            {
                int n = 4 * x * x + y * y;
                if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                    isPrime[n] = !isPrime[n];

                n = 3 * x * x + y * y;
                if (n <= limit && n % 12 == 7)
                    isPrime[n] = !isPrime[n];

                n = 3 * x * x - y * y;
                if (x > y && n <= limit && n % 12 == 11)
                    isPrime[n] = !isPrime[n];
            }
        }

        // Step 2: Mark multiples of squares as non-prime
        for (int i = 5; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i * i)
                    isPrime[j] = false;
            }
        }

        // Step 3: Collect all primes
        for (int i = 5; i <= limit; i++)
        {
            if (isPrime[i])
                yield return i;
        }
    }
    /// <summary>
    /// Generates a sequence of prime numbers less than or equal to the specified value using the Segmented Sieve algorithm.
    /// <example><code>
    /// var res = 999_999.SieveOfAtkin().ToList();
    /// // -> 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,....,999953, 999959, 999961, 999979, 999983
    /// </code></example>
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns>A sequence of prime numbers.</returns>
    public static IEnumerable<int> SegmentedSieve(this int high)
    {
        int low = 0;
        // Step 1: Use a simple sieve to find all primes up to √high
        int limit = (int)System.Math.Sqrt(high);
        List<int> primes = [];

        // Simple sieve of Eratosthenes to find small primes up to √high
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                    isPrime[j] = false;
            }
        }

        // Collect the primes found in the range [2, √high]
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
                primes.Add(i);
        }

        // Step 2: Segment the range [low, high] and mark non-primes using the small primes
        bool[] segment = new bool[high - low + 1];
        for (int i = 0; i < segment.Length; i++)
            segment[i] = true;

        // For each prime, mark its multiples in the segment as non-prime
        foreach (int prime in primes)
        {
            // Find the first multiple of prime in the segment [low, high]
            int start = System.Math.Max(prime * prime, (low + prime - 1) / prime * prime);

            // Mark all multiples of prime in the segment as non-prime
            for (int j = start; j <= high; j += prime)
                segment[j - low] = false;
        }

        // Step 3: Return the primes in the segment
        for (int i = low; i <= high; i++)
        {
            if (segment[i - low] && i > 1) // Exclude 1, as it's not prime
                yield return i;
        }
    }
}
