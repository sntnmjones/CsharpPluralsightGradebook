using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

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

        public double GetGPA() 
        {
            var sum = 0.0;
            foreach(var grade in grades)
            {
                sum += grade;
            }
            return sum/grades.Count;
        }
    }
}