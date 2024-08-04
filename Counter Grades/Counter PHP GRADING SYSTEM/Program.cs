using System;

namespace titi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Grade Counter Program");
            Console.WriteLine("Make By Saiki");
            Console.WriteLine("---------------------");

            Console.Write("Enter the number of subjects: ");
            int numSubjects = Convert.ToInt32(Console.ReadLine());

            int totalScore = 0;
            int highestScore = 0;
            int lowestScore = 100;

            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"Enter grade for subject {i + 1}: ");
                int score = Convert.ToInt32(Console.ReadLine());

                // Validate input
                while (score < 0 || score > 100)
                {
                    Console.Write("Invalid input. Please enter a score between 0 and 100: ");
                    score = Convert.ToInt32(Console.ReadLine());
                }

                totalScore += score;

                if (score > highestScore)
                {
                    highestScore = score;
                }

                if (score < lowestScore)
                {
                    lowestScore = score;
                }
            }

            double average = (double)totalScore / numSubjects;

            Console.WriteLine($"Your average grade is: {average:F2}");
            Console.WriteLine($"Your highest grade is: {highestScore}");
            Console.WriteLine($"Your lowest grade is: {lowestScore}");

            // Determine the equivalent grade based on the Philippines grading system
            string equivalentGrade = GetEquivalentGrade(average);

            Console.WriteLine($"Your equivalent grade is: {equivalentGrade}");

            // Determine the student's standing
            string standing = GetStanding(average);

            Console.WriteLine($"Your standing is: {standing}");

            // Ask the user if they want to repeat the process
            Console.Write("Do you want to repeat the process? (yes/no): ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thank you for using the grade counter program!");
            }
        }

        static string GetEquivalentGrade(double average)
        {
            if (average >= 90)
            {
                return "A (Excellent)";
            }
            else if (average >= 85)
            {
                return "B+ (Very Good)";
            }
            else if (average >= 80)
            {
                return "B (Good)";
            }
            else if (average >= 75)
            {
                return "C+ (Fair)";
            }
            else if (average >= 70)
            {
                return "C (Passing)";
            }
            else if (average >= 65)
            {
                return "D (Borderline)";
            }
            else
            {
                return "F (Failing)";
            }
        }

        static string GetStanding(double average)
        {
            if (average >= 90)
            {
                return "With Highest Honors";
            }
            else if (average >= 85)
            {
                return "With High Honors";
            }
            else if (average >= 80)
            {
                return "With Honors";
            }
            else if (average >= 75)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }
    }
}