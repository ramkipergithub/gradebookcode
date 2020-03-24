using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
            Console.WriteLine($" This is from the Static class: {this.name}");
        }

        public void AddGrade(double grade)
        {           
            grades.Add(grade);            
        }
        
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                result += grade;
            }
            result = result / grades.Count;
            Console.WriteLine($"Lowest grade is: {lowGrade}");
            Console.WriteLine($"Highest grade is: {highGrade}");
            Console.WriteLine($"Total grade is: {result:N1}");
        }

        
        private List<double> grades;
        private string name;
    }
}