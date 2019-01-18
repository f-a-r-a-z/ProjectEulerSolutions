/*
    Find the largest palindrome made from the product of two 3-digit numbers.
    https://projecteuler.net/problem=4
*/
using System;

namespace ProjectEulerSolutions.Problems {
    class Problem004 {

        // Returns an array of a numbers digits
        public static int[] GetDigits(int n) {
            string strN = n.ToString();

            int[] digits = new int[strN.Length];

            for (int i = 0; i < strN.Length; i++) {
                digits[i] = strN[i];
            }

            return digits;
        }

        // Checks if a number is a palindrome (e.g 10201)
        public static bool IsPalindrome(int n) {
            int[] digits = GetDigits(n);
            
            for (int i = 0; i < digits.Length / 2; i++) {
                if (digits[i] != digits[digits.Length - 1 - i]) return false;
            }

            return true;
        }

        public static int Solution() {
            int max = 0;

            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    if (IsPalindrome(i*j)) {
                        max = Math.Max(max, i * j);
                    }
                }
            }

            return max;
        }
    }
}
