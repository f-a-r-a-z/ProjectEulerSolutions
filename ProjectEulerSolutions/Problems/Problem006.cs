/*
    The sum of the squares of the first ten natural numbers is,
                12 + 22 + ... + 102 = 385

    The square of the sum of the first ten natural numbers is,
                (1 + 2 + ... + 10)^2 = 552 = 3025

    Hence the difference between the sum of the squares of the first ten natural numbers
    and the square of the sum is 3025 − 385 = 2640.

    Find the difference between the sum of the squares of the first one hundred natural numbers
    and the square of the sum.
    https://projecteuler.net/problem=6
*/

using System;

namespace ProjectEulerSolutions.Problems {
    class Problem006 {

        // Finds the sum of the squares of numbers from 1 to last
        public static int SumOfSquares(int last) {
            int sum = 0;

            for (int i = 1; i <= last; i++) {
                sum += (int)Math.Pow(i, 2);
            }

            return sum;
        }

        // Finds the sum of numbers from 1 to last and returns the square of it
        public static int SquareOfSum(int last) {
            int sum = 0;

            for (int i = 1; i <= last; i++) {
                sum += i;
            }

            return (int)Math.Pow(sum, 2);
        }

        public static int Solution() {
            return SquareOfSum(100) - SumOfSquares(100);
        }
    }
}
