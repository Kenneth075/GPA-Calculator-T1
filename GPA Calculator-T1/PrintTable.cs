using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_T1
{
    internal class PrintTable
    {
        //public string total;
        //public double totalCourseUnitRegistered, totalCourseUnitPassed, totalWeightPoint, gpa;
        public void Table(string total, double totalCourseUnitRegistered, double totalCourseUnitPassed, double totalWeightPoint, double gpa)
        {
            // table display
            Console.WriteLine("|--------------------|---------------|-----------|---------------|---------------|-----------|");
            Console.WriteLine("|    COURSE & CODE   |   COURSE UNIT |   GRADE   |   GRADE-UNIT  |   WEIGHT Pt.  |   REMARK  |");
            Console.WriteLine("|--------------------|---------------|-----------|---------------|---------------|-----------|");
            Console.Write($"{total}");
            Console.WriteLine("|--------------------|---------------|-----------|---------------|---------------|-----------|");
            Console.WriteLine();
            Console.WriteLine($"Tootal Course Unit Registerd is {totalCourseUnitRegistered}");
            Console.WriteLine($"Tootal Course Unit Passed is {totalCourseUnitPassed}");
            Console.WriteLine($"Tootal Weight Point is {totalWeightPoint}");
            Console.WriteLine($"Your gpa is {gpa:F2} to 2 decimal places.");

        }

    }
}
