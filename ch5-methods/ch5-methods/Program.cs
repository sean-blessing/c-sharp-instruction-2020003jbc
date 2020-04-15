using System;

namespace ch5_methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Write some methods!");

            int nbr = GetInt("Enter a whole number: ");

            Console.WriteLine("Number entered = " + nbr);

            Console.WriteLine("sum 3 numbers = " + sum(1, 2, 3));
            Console.WriteLine("sum 2 numbers = " + sum(1, 2));
            // declaring a value for an optional parameter
            Console.WriteLine(sum(1,2, n4:5));

        }

        private static int GetInt(string prompt) {
            int nbr=0;
            bool success = false;
            while (!success) {
                // prompt the user for input
                Console.Write(prompt);
                try {
                    // accept the input as a string
                    string nbrStr = Console.ReadLine();
                    // convert that string to an int
                    nbr = int.Parse(nbrStr);
                    success = true;
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid # value.");
                    //Console.WriteLine(e.StackTrace);
                }
            }
            return nbr;
        }

        private static int sum(int n1, int n2, int n3=0, int n4=0) {
            int sum = n1 + n2 + n3+ n4;

            return sum;
        }
    }

}
