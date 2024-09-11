using BenchmarkDotNet.Attributes;

namespace Console_Test;

public class Prime
{
    [Params(30, 99, 999, 9_999, 99_999, 999_999, 9_999_999)]
    public int Number;

    [Benchmark]
    public List<int> SieveOfEratosthenes()
    {
        return Number.SieveOfEratosthenes().ToList();
    }

    [Benchmark]
    public List<int> SieveOfEuler()
    {
        return Number.SieveOfEuler().ToList();
    }

    [Benchmark]
    public List<int> SieveOfAtkin()
    {
        return Number.SieveOfAtkin().ToList();
    }

    [Benchmark]
    public List<int> SegmentedSieve()
    {
        return Number.SegmentedSieve().ToList();
    }

    [Benchmark]
    public List<int> Primes()
    {
        return Number.Primes().ToList();
    }
}

static file class Test
{
    public static IEnumerable<int> SieveOfEratosthenes(this int quantity)
    {
        if (quantity < 2)
            yield break; // There ar no prime numbers less than 2
        // Create a list of booleans, initialized to true
        bool[] isPrime = new bool[quantity + 1];
        for (int i = 2; i < quantity; i++)
            isPrime[i] = true;
        //
        for (int i = 2; i * i <= quantity; i++)
            if (isPrime[i])
                for (int j = i * i; j <= quantity; j += i)
                    isPrime[j] = false;
        //
        for (int i = 2; i <= quantity; i++)
            if (isPrime[i])
                yield return i;
    }
    public static IEnumerable<int> SieveOfEuler(this int quantity)
    {
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

    public static IEnumerable<int> SegmentedSieve(this int high)
    {
        int low = 0;
        // Step 1: Use a simple sieve to find all primes up to √high
        int limit = (int)Math.Sqrt(high);
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
            int start = Math.Max(prime * prime, (low + prime - 1) / prime * prime);

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


    public static IEnumerable<int> Primes(this int quantity) => Enumerable.Range(2, quantity - 1).Where(i => i.IsPrime());
    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false; // 0,1 and negative numbers are not prime.
        if (number == 2) return true; // 2 is the only even prime number
        if (number % 2 == 0) return false; // Avoid all even numbers greater than 2
        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}