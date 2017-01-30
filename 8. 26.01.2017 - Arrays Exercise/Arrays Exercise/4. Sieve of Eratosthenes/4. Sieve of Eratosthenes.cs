namespace _4.Sieve_of_Eratosthenes
{
    using System;

    /// Sieve of Eratosthenes: Find all prime numbers in range
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Eratosthenes(n);
        }

        public static void Eratosthenes(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int p = 2; p < primes.Length; p++)
            {
                if (primes[p] == true)
                {
                    Console.Write(p + " ");

                    for (int j = 2; j < primes.Length; j++)
                    {
                        if (j * p >= 0 && j * p <= n)
                        {
                            primes[j * p] = false;
                        }
                    }
                }
            }
        }
    }
}
