using System;

namespace D2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerical grade you expect to get in ISM 4300?");

            try
            {
                String input = Console.ReadLine();

                int grade = int.Parse(input);

                //A+ output
                if ((grade <= 100) && (grade >= 98))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in an A+");
                }

                //A output
                else if ((grade < 98) && (grade >= 92))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in an A");

                }

                //A- output
                else if ((grade < 92) && (grade >= 90))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in an A-");
                }

                //B+ output
                else if ((grade < 90) && (grade >= 88))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a B+");
                }

                //B output
                else if ((grade < 88) && (grade >= 82))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a B");
                }

                //B- output
                else if ((grade < 82) && (grade >= 80))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a B-");
                }

                //C+ output
                else if ((grade < 80) && (grade >= 78))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a C+");
                }

                //C output
                else if ((grade < 78) && (grade >= 72))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a C");
                }

                //C- output
                else if ((grade < 72) && (grade >= 70))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a C-");
                }

                //D+ output
                else if ((grade < 70) && (grade >= 68))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a D+");
                }

                //D output
                else if ((grade < 68) && (grade >= 62))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a D");
                }

                //D- output
                else if ((grade < 62) && (grade >= 60))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a D-");
                }

                //F output
                else if ((grade < 60) && (grade >= 0))
                {
                    Console.WriteLine("A grade of " + grade + ", will result in a F");
                }
            }

            catch
            {
                Console.WriteLine("The value that you have entered is invalid. Please resart the program and try again.");
            }
        }
    }
}
