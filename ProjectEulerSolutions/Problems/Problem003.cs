/*
    What is the largest prime factor of the number 600851475143?
    https://projecteuler.net/problem=3
*/

using System;

namespace ProjectEulerSolutions.Problems {
    class Problem003 {

        // Checks whether a value (n) is prime or not
        public static bool IsPrime(ulong n) {
            if (n <= 2) return true;
            for (ulong i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) return false;
            }

            return true;
        }

        // Returns the largest factor of a number (n) that is prime
        public static ulong LargestPrimeFactor(ulong n) {
            ulong max = 1;

            for (ulong i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    if (IsPrime(i)) max = Math.Max(max, i);
                    if (IsPrime(n / i)) max = Math.Max(max, n / i);
                }
            }

            return max;
        }

        public static ulong Solution() {
            return LargestPrimeFactor(600851475143);
        }
    }
}
