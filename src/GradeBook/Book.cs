using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;
        private double highGrade;
        private double GPA;
        private double lowGrade;

        public Book()
        {
            this.grades = new List<double>();
        }

        public Book(List<double> grades, string name) 
        {
            this.grades = grades;
            this.name = name;
        }

        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }

        public List<double> GetGrades()
        {
            return this.grades;
        }

        public void PrintStatistics()
        {
            CalculateStatistics();
            System.Console.WriteLine($"High Grade: {highGrade}\nLow Grade: {lowGrade}\nGPA: {GPA}");
        }

        private void CalculateStatistics() 
        {
            var sum = 0.0;
            lowGrade = double.MaxValue;
            highGrade = double.MinValue;

            foreach(var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                sum += grade;
            }

            GPA = sum/grades.Count;
        }
    }
}