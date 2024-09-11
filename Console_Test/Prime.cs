using BenchmarkDotNet.Attributes;

namespace Console_Test;

public class Prime
{
    [Params(30, 99, 999, 9_999, 99_999, 999_999)]
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