using System;

namespace ProjectEulerSolutions {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Problem 1 Solution: " + Problems.Problem001.Solution());
            Console.WriteLine("Problem 2 Solution: " + Problems.Problem002.Solution());
            Console.WriteLine("Problem 3 Solution: " + Problems.Problem003.Solution());
            Console.WriteLine("Problem 4 Solution: " + Problems.Problem004.Solution());
            Console.WriteLine("Problem 5 Solution: " + Problems.Problem005.Solution());
            Console.Write("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
