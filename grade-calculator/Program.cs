/*
Jacob Duryea
IGME 201
11/2/2024 (due 10/13/2024)
*/

namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Jacob";
            int[] grades = {100, 92, 87, 200, -20, 52, 82, 75, 67, 88};
            Console.WriteLine("Welcome, " + studentName + "!");
            Console.WriteLine("Here are your grades:");
            int average = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if (90 <= grades[i] && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW!!! A perfect score!");
                    }
                }
                else if (80 <= grades[i] && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is a B!");
                }
                else if (70 <= grades[i] && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (65 <= grades[i] && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (0 <= grades[i] && grades[i] <= 64)
                {
                    Console.WriteLine("This grade is an F...");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0 - 100. How did you even get this grade...?");
                }
            }

            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }
            average = average / grades.Length;
            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("All grades have been displayed for " + studentName);
        }
    }
}
