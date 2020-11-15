using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {1.1, 2.0, 3.0, 4.0};
            var sum = 0.0;
            foreach(var grade in grades)
            {
                sum += grade;
            }
            System.Console.WriteLine($"Avg: {(sum/grades.Count):N1}");

            if (args.Length > 0) 
            {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
