using ReadersNamespace;
using StudentsNamespace;
using System;

namespace StudentsNamespace
{
    public class Student
    {
        public string FullName;
        public string GroupNumber;
        private int Age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {FullName}, Group: {GroupNumber}, Age: {Age}");
        }
    }
}

namespace ReadersNamespace
{
    public class Reader
    {
        private string FullName;
        public int LibraryCardNumber;
        public string Faculty;
        private DateTime DateOfBirth;
        public string PhoneNumber;

        public void takeBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} взял {numberOfBooks} книги(книгу).");
        }

        public void takeBook(params string[] bookNames)
        {
            Console.Write($"{FullName} взял книги: ");
            foreach (var book in bookNames)
            {
                Console.Write(book + ", ");
            }
            Console.WriteLine();
        }

        public void returnBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} вернул {numberOfBooks} книги(книгу).");
        }

        public void returnBook(params string[] bookNames)
        {
            Console.Write($"{FullName} вернул книги: ");
            foreach (var book in bookNames)
            {
                Console.Write(book + ", ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[3];
        students[0] = new Student { FullName = "Иванов И. И.", GroupNumber = "101" };
        students[1] = new Student { FullName = "Петров П. П.", GroupNumber = "102" };
        students[2] = new Student { FullName = "Сидоров С. С.", GroupNumber = "103" };

        Reader[] readers = new Reader[3];
        readers[0] = new Reader { LibraryCardNumber = 12345, Faculty = "Информационные технологии" };
        readers[1] = new Reader { LibraryCardNumber = 54321, Faculty = "Экономика" };
        readers[2] = new Reader { LibraryCardNumber = 98765, Faculty = "Медицина" };

        readers[0].takeBook("Приключения", "Роман");
        readers[1].takeBook(2);
    }
}