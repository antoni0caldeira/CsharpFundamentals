using System;

namespace gradebook{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tava difícil");
            Book book = new Book("Livro");
            book.addGrade(20.4);
            book.addGrade(85.4);
            book.addGrade(66.4);
            book.addGrade(89.4);
            book.ShowStats();
        }
    }
}
