using System;
using System.Collections.Generic;

namespace ch_list {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Lists in C#");

            List<string> names = new List<string>();
            names.Add("Trevor");
            names.Add("Dennis");
            names.Add("Eric");
            names.Add("Jeff");

            names.Remove("Dennis");

            foreach(string s in names) {
                Console.WriteLine(s);
            }

        }
    }
}
