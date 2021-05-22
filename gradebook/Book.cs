using System;
using System.Collections.Generic;
using System.Linq;

namespace gradebook
{
    internal class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {
            double lowgrade = double.MaxValue;
            double highgrade = double.MinValue;
            double avg;

            foreach (var item in grades)
            {
                lowgrade = Math.Min(item, lowgrade);
                highgrade = Math.Max(item, highgrade);
            }
            avg = Queryable.Average(grades.AsQueryable());

            System.Console.WriteLine($"baixo: {lowgrade} alto: {highgrade} a média: {avg}");
        }

        List<double>  grades;
        string name;
    }
}