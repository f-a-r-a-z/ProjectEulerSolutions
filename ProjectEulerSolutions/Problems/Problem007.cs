/*
    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    What is the 10 001st prime number?
    https://projecteuler.net/problem=7
*/

namespace ProjectEulerSolutions.Problems {
    class Problem007 {

        // Returns the n-th prime value, where the 1st prime is 2
        public static int NthPrime(int n) {
            if (n <= 1) return 2;

            int currN = 2;
            int currPrime = 3;

            while (currN < n) {
                currPrime += 2; // Even numbers can't be prime
                if (Problem003.IsPrime((ulong)currPrime)) currN++;
            }

            return currPrime;
        }

        public static int Solution() {
            return NthPrime(10001);
        }
    }
}
