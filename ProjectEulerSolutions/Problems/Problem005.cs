/*
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    https://projecteuler.net/problem=5
*/

namespace ProjectEulerSolutions.Problems {
    class Problem005 {
        public static int Solution() {
            int curr = 20;

            for (; ;) {
                for (int i = 2; i <= 20; i++) {
                    if (curr % i != 0) break;
                    if (i == 20) return curr;
                }

                curr += 20;
            }
        }
    }
}
