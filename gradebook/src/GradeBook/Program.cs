using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;

            List<double>  grades = new List<double>();
            grades.Add(21.1);
            grades.Add(1.1);
            grades.Add(211.1);
            grades.Add(210.1);

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
            foreach (var item in grades)
            {
                soma += item;
                Console.WriteLine(soma);
            }
            System.Console.WriteLine($"Média:  {soma / grades.Count:N4}");

        }
    }
}
