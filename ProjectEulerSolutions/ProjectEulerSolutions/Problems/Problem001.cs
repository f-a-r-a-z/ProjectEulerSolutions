/*
    Find the sum of all the multiples of 3 or 5 below 1000.
    https://projecteuler.net/problem=1
*/

namespace ProjectEulerSolutions.Problems {
    class Problem001 {
        public static int SumOfMultiplesUnder(int multipleOf, int under) {
            int sum = 0;

            for (int i = multipleOf; i < under; i += multipleOf) {
                sum += i;
            }

            return sum;
        }

        public static int Solution() {
            int under = 1000;
            return SumOfMultiplesUnder(5, under) + SumOfMultiplesUnder(3, under) - SumOfMultiplesUnder(3 * 5, under);
        }
    }
}
