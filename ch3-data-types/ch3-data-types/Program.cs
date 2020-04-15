using System;

namespace ch3_data_types {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's play with some data types and math!");

            double d1 = 55.77;
            double d2 = 11.34;

            double diff = d1 - d2;
            Console.WriteLine(diff);

            // compound assignment operators
            int n1 = 5;
            n1 += 7;
            n1 -= 2;
            n1 *= 3;
            Console.WriteLine(n1);

            // unary operators
            n1++;
            Console.WriteLine(n1);

            // random #s
            Random random = new Random();
            int rand1 = random.Next();
            Console.WriteLine("rand1 = " + rand1);
            int rand10 = random.Next(10);
            Console.WriteLine("rand10 = " + rand10);
            for (int i = 0; i < 100; i++) {
                rand10 = random.Next(10);
                Console.WriteLine("rand10 = " + rand10);
            }
            // random die
            int rand6 = random.Next(6) + 1;

            // format a doulble as a currency
            double price1 = 199.5788888888888888888;
            Console.WriteLine(price1.ToString("C2"));

            // format a double as a percent - 3 decimal places
            double rate1 = .03577777777777;
            Console.WriteLine(rate1.ToString("P3"));
        }
    }
}
