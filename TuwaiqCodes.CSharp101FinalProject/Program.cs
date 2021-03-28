using System;
using System.Collections.Generic;

namespace TuwaiqCodes.CSharp101FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrades = new Dictionary<string, double>();

            var enterMore = true;

            // Retrieving students data from the user 
            while(enterMore)
            {
                Console.WriteLine("Please enter student name : ");
                string studentName = Console.ReadLine();

                Console.WriteLine("Please enter {0}'s grade : ", studentName);
                double studentGrade = double.Parse(Console.ReadLine());

                studentsGrades.Add(studentName, studentGrade);

                Console.WriteLine("Do you want to enter another student grade? [y/n]");
                enterMore = Console.ReadLine() == "y";
            }

            // list students info
            foreach(var studentGrade in studentsGrades)
            {
                Console.WriteLine("[{0}] has grade of [{1}] - ({2})"
                    , studentGrade.Key
                    , studentGrade.Value
                    , (studentGrade.Value >= 60 ? "Passed" : "Failed"));
            }
        }
    }
}
