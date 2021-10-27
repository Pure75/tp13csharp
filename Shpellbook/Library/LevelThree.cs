using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class LevelThree
    {
        /// <summary>
        ///     Generates all primes numbers up to n included
        /// </summary>
        public static List<int> UsualPrimesGenerator(int n)
        {
            if (n < 0)
                return new List<int>();
            
            var numbers = Enumerable.Range(2, n).ToList();
            numbers.RemoveAll(x =>
            {
                for (var i = 2; i < x; i++)
                    if (x % i == 0 && x != i)
                        return true;

                return false;
            });

            return numbers;
        }


        /// <summary>
        ///     Remove integers divisible by n in the list
        /// </summary>
        /// <param name="n">the base multiple</param>
        /// <param name="primes">the list to remove from</param>
        public static void RemoveNotPrimes(int n, List<int> primes)
        {
            lock (primes)
            {
                primes.RemoveAll(x => x % n == 0 && x != n);                   
            }
        }

        public static List<int> MagicPrimesGenerator(int n, int nbTasks)
        {
            List<int> prime = new List<int>();
            if (nbTasks <= 0) throw new ArgumentException("n <= 0");
            if (n < 2) return prime;
            prime = Enumerable.Range(2, n - 1).ToList(); 
            ThreadPool.SetMaxThreads(nbTasks, nbTasks);
            Task task = Task.Run(() => RemoveNotPrimes(2, prime));
            for (int i = 3; i < Math.Sqrt(n); i++)
            {
                new Task(() => RemoveNotPrimes(i,prime)).RunSynchronously();
            }
            return prime;
        }
    }
}