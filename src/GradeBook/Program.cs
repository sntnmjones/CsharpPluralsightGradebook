using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradebook = new Book(new List<double>() {1.1, 2.0, 3.0, 4.0}, "The gradebook");
            gradebook.PrintStatistics();
        }
    }
}
