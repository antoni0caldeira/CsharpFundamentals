using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            double soma = 0;

            double[] numbers = new double[x];
            x = 5;
            numbers[0]=21.1;
            numbers[1]=21.1;
            numbers[2]=21.1;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var item in numbers)
            {
                soma += item;
                Console.WriteLine(soma);
            }
            

        }
    }
}
