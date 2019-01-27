/*
    The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    Find the sum of all the primes below two million.
    https://projecteuler.net/problem=10
*/

using System;
using System.Collections;

namespace ProjectEulerSolutions.Problems {
    class Problem010 {

        /// <summary>
        /// Calculates the Sieve of Eratosthenes which allows for testing primality of a set of numbers at once
        /// </summary>
        /// <remarks>
        /// Algorithm from here:
        /// https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#Algorithm_and_variants
        /// This method can use a bit of memory, so be careful with using at high numbers
        /// </remarks>
        /// <param name="below">Values from 0 to "below" will be tested for primality</param>
        /// <returns>
        /// A bit array where value of index i of the array corresponds to primality of value i
        /// A value of true means i is prime
        /// </returns>
        public static BitArray SieveOfEratosthenes(int below) {
            BitArray sieve = new BitArray(below, true); // BitArray used to conserve memory usage

            // 0 and 1 not considered prime
            sieve[0] = false;
            sieve[1] = false;

            for (int i = 2; i < Math.Sqrt(below); i++) {
                if (sieve[i]) {
                    for (int j = (int)Math.Pow(i, 2); j < below; j += i) {
                        sieve[j] = false;
                    }
                }
            }

            return sieve;
        }

        /// <summary>
        /// Sums all primes below the parameter "below"
        /// </summary>
        /// <remarks>First prime number is considered to be 2</remarks>
        public static ulong SumOfPrimesBelow(int below) {
            if (below < 0) return 0;

            BitArray sieve = SieveOfEratosthenes(below);
            ulong sum = 0;

            for (int i = 0; i < sieve.Length; i++) {
                if (sieve[i]) sum += (ulong)i;
            }

            return sum;
        }

        public static ulong Solution() {
            return SumOfPrimesBelow(2000000);
        }
    }
}
