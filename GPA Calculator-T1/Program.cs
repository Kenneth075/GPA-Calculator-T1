using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GPA_Calculator_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string length = "";

            do
            {

                Console.WriteLine("Enter number of Courses Offered. Number of Courses most be in digit");
                length = Console.ReadLine();
                if (!Regex.IsMatch(length, @"\d+"))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correct format");
                }

            }
            while (!Regex.IsMatch(length, @"\d+"));  //This line of code make sure the user input only a digit.

            string courseCode;
            int courseUnit;
            char grade;
            int gradeUnit;
            int weightPoint;
            string remark;
            int courseScore;
            string total = "";
            int totalCourseUnitRegistered = 0;
            int totalCourseUnitPassed = 0;
            int totalWeightPoint = 0;
            string getCourseScore;
            string getcourseUnit;


            int counter = 1;
            for (int i = 0; i < int.Parse(length); i++)
            {
                do
                {

                    Console.WriteLine("Enter your Course code");
                    courseCode = Console.ReadLine();

                    if (!Regex.IsMatch(courseCode, @"^[A-z]{3}(\d{3})$"))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the correct format of couse code, example: Mat101");

                    }
                }
                while (!Regex.IsMatch(courseCode, @"^[A-z]{3}(\d{3})$"));   //This line of code will allow the user to only input three alphebert and three digits.e.g Mat101.

                do
                {

                    Console.WriteLine("Enter your course score");
                    getCourseScore = Console.ReadLine();

                    if (!Regex.IsMatch(getCourseScore, @"\d+"))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the correct score format.Score most be a number");
                    }
                }
                while (!Regex.IsMatch(getCourseScore, @"\d+") || int.Parse(getCourseScore) < 0 || int.Parse(getCourseScore) > 100); //This will not allow the user input score <0 or >100. 

                courseScore = int.Parse(getCourseScore);

                do
                {
                    Console.WriteLine("Enter course unit");
                    getcourseUnit = Console.ReadLine();

                    if (!Regex.IsMatch(getcourseUnit, @"\d+"))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the correct format. Course Unit must be a digit");
                    }

                } while (!Regex.IsMatch(getcourseUnit, @"\d+"));

                courseUnit = int.Parse(getcourseUnit);

                if (courseScore >= 70 && courseScore <= 100)
                {
                    grade = 'A';
                    gradeUnit = 5;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Excellent";
                }
                else if (courseScore >= 60 && courseScore <= 69)
                {
                    grade = 'B';
                    gradeUnit = 4;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Very Good";
                }
                else if (courseScore >= 50 && courseScore <= 59)
                {
                    grade = 'C';
                    gradeUnit = 3;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Good";
                }
                else if (courseScore >= 45 && courseScore <= 49)
                {
                    grade = 'D';
                    gradeUnit = 2;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Fair";
                }
                else if (courseScore >= 40 && courseScore <= 44)
                {
                    grade = 'E';
                    gradeUnit = 1;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Pass";
                }
                else if (courseScore >= 0 && courseScore <= 39)
                {
                    grade = 'F';
                    gradeUnit = 0;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Fail";
                }
                else
                {
                    Console.WriteLine("invalid");
                    break;
                }
                total = total + $"| {courseCode,-18} | {courseUnit,-13} | {grade,-9} | {gradeUnit,-13} | {weightPoint,-13} | {remark,-9} |\n";
                counter++;
                totalCourseUnitRegistered += courseUnit;
                if (grade != 'F')
                {
                    totalCourseUnitPassed += courseUnit;
                }
                totalWeightPoint += weightPoint;
            }
            double gpa = totalWeightPoint / totalCourseUnitRegistered;

            PrintTable printTable = new PrintTable();
            printTable.Table(total, totalCourseUnitRegistered, totalCourseUnitPassed, totalWeightPoint, gpa);

            Console.ReadKey();



        }
    }

}