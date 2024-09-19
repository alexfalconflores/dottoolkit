using System.Numerics;

namespace DotToolkit.Math;

public static class MathExt
{
    //typeof(Int128), typeof(UInt128) only available in .NET 7.0 or higher
    //  int256 https://github.com/NethermindEth/int256
    private readonly static HashSet<Type> INTEGERS = [typeof(Byte), typeof(SByte), typeof(Int16), typeof(UInt16), typeof(Int32), typeof(UInt32), typeof(Int64), typeof(UInt64), typeof(BigInteger)];
    private readonly static HashSet<Type> DECIMAL = [typeof(Single), typeof(Double), typeof(Decimal)];

    /// <summary>
    /// Calculates the Fibonacci number at the position specified by <paramref name="n"/>
    /// <example><code>
    /// int position = 10;
    /// ulong fibonacciNumber = position.Fibonacci();
    /// // -> 55
    /// </code></example>
    /// </summary>
    /// <param name="n">The index of the Fibonacci sequence to be calculated. It must be a non-negative integer.</param>
    /// <returns>The Fibonacci number corresponding to the <paramref name="n"/>.</returns>
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
    /// Check if the specified number is odd.
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
        if (limit > 3) yield return 3;

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
    /// <summary>
    /// Check if the number is between two numbers.
    /// <example><code>
    /// var res = 5.IsBetween(-5, 4)
    /// // -> false
    /// 
    /// var res = (-5).IsBetween(-5, 4)
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <returns></returns>
    public static bool IsBetween<T>(this T number, T minValue, T maxValue) where T : struct, IComparable<T>
    {
        if (minValue.CompareTo(maxValue) > 0)
            (minValue, maxValue) = (maxValue, minValue);
        return number.CompareTo(minValue) >= 0 && number.CompareTo(maxValue) <= 0;
    }
    /// <summary>
    /// Check if the number is positive. Zero is considered positive or negative.
    /// <example><code>
    /// var res = 5.IsPositive()
    /// // -> true
    /// 
    /// var res = 5.5.IsPositive()
    /// // -> true
    /// 
    /// var res = (-5).IsPositive()
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPositive<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default;
        return number.CompareTo(zero) >= 0;
    }
    /// <summary>
    /// Check if the number is negative. Zero is considered positive or negative.
    /// </summary>
    /// <example><code>
    /// var res = 5.IsNegative()
    /// // -> false
    /// 
    /// var res = (-5.5).IsNegative()
    /// // -> true
    /// 
    /// var res = (-5).IsNegative()
    /// // -> true
    /// </code></example>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsNegative<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default;
        return number.CompareTo(zero) <= 0;
    }
    /// <summary>
    /// Check if the number is zero.
    /// <example><code>
    /// var res = 5.IsZero()
    /// // -> false
    /// 
    /// var res = (-5.5).IsZero()
    /// // -> false
    /// 
    /// var res = 0.IsZero()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsZero<T>(this T number) where T : struct, IComparable<T>
    {
        T zero = default;
        return number.CompareTo(zero) == 0;
    }
    /// <summary>
    /// Check if the number is integer.
    /// (Byte(byte) => 8bits, SByte(sbyte) => 8bits, Int16(short) => 16bits, UInt16(ushort) => 16bits, Int32(int) => 32bits, UInt32(uint) => 32bits,
    /// Int64(long) => 64bits, UInt64(ulong) => 64bits, BigInteger).
    /// <example><code>
    /// var res = 5.IsInteger()
    /// // -> true
    /// 
    /// var res = (-5.5).IsInteger()
    /// // -> false
    /// 
    /// var res = 0.IsInteger()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsInteger<T>(this T _) where T : struct, IComparable<T> => INTEGERS.Contains(typeof(T));
    /// <summary>
    /// Check if the number is decimal. (Single(float) => 32bits, Double(double) => 64bits, Decimal(decimal) => 128bits.
    /// <example><code>
    /// var res = 5.IsDecimal()
    /// // -> false
    /// 
    /// var res = (-5.5).IsDecimal()
    /// // -> true
    /// 
    /// var res = 5.5.IsDecimal()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsDecimal<T>(this T _) where T : struct, IComparable<T> => DECIMAL.Contains(typeof(T));
    /// <summary>
    ///  Check if the number is an integer of arbitrary precision.
    /// <example><code>
    /// var res = (-5.5).IsBigInteger()
    /// // -> false
    /// 
    /// var res = 5.IsBigInteger()
    /// // -> true
    /// 
    /// var res = ((BigInteger)5).IsBigInteger()
    /// // -> true
    /// 
    /// var res = ((BigInteger)5.5).IsBigInteger()
    /// // -> true
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <returns></returns>
    public static bool IsBigInteger<T>(this T _) where T : struct, IComparable<T> => typeof(T) == typeof(BigInteger);
    /// <summary>
    /// Check if the number represents a complex number, which has a real part and an imaginary part.
    /// <example><code>
    /// var res = 5.IsComplex()
    /// // -> false
    /// 
    /// Complex complex = new Complex(1, 1.2);
    /// var res = complex.IsComplex()
    /// // -> true
    /// 
    /// var res = complex.Real.IsComplex()
    /// // -> false
    /// 
    /// var res = complex.Imaginary.IsComplex()
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <returns></returns>
    public static bool IsComplex<T>(this T _) where T : struct, IComparable<T> => typeof(T) == typeof(Complex);
    /// <summary>
    /// Check if the number represents a complex number, which has a real part and an imaginary part.
    /// <example><code>
    /// var res = 5.IsComplex()
    /// // -> false
    /// 
    /// Complex complex = new Complex(1, 1.2);
    /// var res = complex.IsComplex()
    /// // -> true
    /// 
    /// var res = complex.Real.IsComplex()
    /// // -> false
    /// 
    /// var res = complex.Imaginary.IsComplex()
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_"></param>
    /// <returns></returns>
    public static bool IsComplex(this object number) => number is Complex;
    /// <summary>
    /// Check if the number is natural. Zero is considered natural default, but you can change it.
    /// <example><code>
    /// BigInteger bigInteger = (BigInteger)1.1;
    /// var res = bigInteger.IsNatural();
    /// //-> true
    /// 
    /// var res = 0.IsNatural();
    /// // -> true
    /// 
    /// var res = 0.IsNatural(false);
    /// // -> false
    /// 
    /// var res = 5.2m.IsNatural();
    /// // -> false
    /// 
    /// var res = 5.IsNatural();
    /// // -> true
    /// 
    /// var res = (-5).IsNatural();
    /// // -> false
    /// </code></example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <param name="includeZero"></param>
    /// <returns></returns>
    public static bool IsNatural<T>(this T number, bool includeZero = true) where T : struct, IComparable<T>
    {
        T zero = default;
        return INTEGERS.Contains(typeof(T)) && number.CompareTo(zero) >= (includeZero ? 0 : 1);
    }
    /// <summary>
    /// Calculates the factorial of a non-negative integer.
    /// <example><code>
    /// ulong fac = 20.Factorial();
    /// // -> 2432902008176640000
    /// </code></example>
    /// </summary>
    /// <param name="number">The non-negative integer for which to calculate the factorial.</param>
    /// <returns>Returns the factorial of the provided number as an unsigned long integer.</returns>
    /// <exception cref="ArgumentException">Thrown when the input number is negative.</exception>
    /// <remarks>
    /// The result is limited by the maximum value of <see cref="ulong"/>, which is 
    /// <c>18,446,744,073,709,551,615</c>. Factorials of numbers greater than 20 will exceed this limit 
    /// and cause an overflow, leading to incorrect results.
    /// </remarks>
    public static ulong Factorial(this int number)
    {
        if (number < 0)
            throw new ArgumentException("The number must be non-negative.");
        if (number == 0 || number == 1)
            return 1;
        ulong result = 1;
        for (int i = 2; i <= number; i++)
            result *= (ulong)i;
        return result;
    }
    /// <summary>
    /// Calculates the factorial of a non-negative integer using a parallel approach. 
    /// The calculation is optimized to run on multiple processor cores.
    /// <example><code>
    /// BigInteger res = 50.FactorialBigInteger();
    /// //->30414093201713378043612608166064768844377641568960512000000000000
    /// </code></example>
    /// </summary>
    /// <param name="number">The non-negative integer whose factorial is to be calculated.</param>
    /// <returns>The factorial of the given number as a <see cref="BigInteger"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when the input number is negative.</exception>
    /// <remarks>
    /// This method uses <see cref="Parallel.For"/> to divide the calculation by the number of available processors.
    /// Each processor calculates a part of the factorial, and then the partial results are combined.
    /// </remarks>
    public static BigInteger FactorialBigInteger(this int number)
    {
        if(number < 0)
            throw new ArgumentException("The number must be non-negative.");
        if(number == 0 || number == 1)
            return 1;
        int processorCount = Environment.ProcessorCount;
        var chunks = new BigInteger[processorCount];
        Parallel.For(0, processorCount, i =>
        {
            BigInteger chunkResult = 1;
            for (int j = i + 2; j <= number; j += processorCount)
                chunkResult *= j;
            chunks[i] = chunkResult;
        });
        BigInteger result = 1;
        foreach (var chunk in chunks)
            result *= chunk;
        return result;
    }
}