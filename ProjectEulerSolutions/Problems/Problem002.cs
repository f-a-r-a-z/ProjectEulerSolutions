﻿/*
    Each new term in the Fibonacci sequence is generated by adding the previous two terms.
    By starting with 1 and 2, the first 10 terms will be:

    1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

    By considering the terms in the Fibonacci sequence whose values do not exceed four million,
    find the sum of the even-valued terms.
    https://projecteuler.net/problem=2
*/

namespace ProjectEulerSolutions.Problems {
    class Problem002 {

        // Finds the sum of all even values in the Fibonacci Series under maxValue
        public static int EvenFibonacciSum(int maxValue) {
            int sum = 0;
            int left = 1;
            int right = 2;
            int temp;

            while (right < maxValue) {
                if (right % 2 == 0) sum += right;
                temp = left + right;
                left = right;
                right = temp;
            }

            return sum;
        }

        public static int Solution() {
            return EvenFibonacciSum(4000000);
        }
    }
}
