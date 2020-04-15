using System;

namespace ch2_grade_converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Grade Converter App!");
            string choice = "y";

            while (choice.Contains("y") || choice.Contains("Y")) {
                Console.Write("Numeric Grade?: ");
                int numericGrade = Convert.ToInt32(Console.ReadLine());
                string letterGrade = "";
                if (numericGrade >= 88) {
                    letterGrade = "A";
                }
                else if (numericGrade >= 80) { 
                    letterGrade = "B";
                }
                else if (numericGrade >= 67) {
                    letterGrade = "C";
                }
                else if (numericGrade >= 60) {
                    letterGrade = "D";
                }
                else {
                    letterGrade = "F";
                }
                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine();

                Console.Write("Continue?: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Bye");
        }
    }
}
