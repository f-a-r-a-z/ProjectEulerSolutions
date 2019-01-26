/*
    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

                        a^2 + b^2 = c^2

    For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

    There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    Find the product abc.
    https://projecteuler.net/problem=9
*/

using System;

namespace ProjectEulerSolutions.Problems {
    class Problem009 {

        /// <summary>
        /// Given three integers a, b and c; where a < b < c
        /// return whether or not they are a Pythagorean triplet
        /// </summary>
        /// <returns>A boolean denoting whether the parameters are a Pythagorean triplet</returns>
        public static bool IsPythagorean(int a, int b, int c) {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        public static int Solution() {
            int sum = 1000; // What the triplet should sum to
            int c;

            for (int a = 1; a < sum - 2; a++) {
                for (int b = a + 1; b < sum - 1; b++) {
                    // a + b + c = sum, c = sum - a - b
                    c = sum - a - b;
                    if (IsPythagorean(a, b, c)) return a*b*c;
                }
            }

            return 0;
        }
    }
}
