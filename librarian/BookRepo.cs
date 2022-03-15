using System;
using System.Collections.Generic;

namespace librarian
{
    internal class BookRepo
    {
        static List<Book> books = new List<Book>();
        internal void Add()
        {
            Book book = new Book();
            Console.Write("\nEnter the name: ");
            book.Name = Console.ReadLine();
            Console.Write("\nEnter the author: ");
            book.Author = Console.ReadLine();
            Console.Write("\nEnter the genre: ");
            book.Genre = Console.ReadLine();
            Console.Write("\nEnter the publishing hous: ");
            book.PublishingHouse = Console.ReadLine();
            Console.Write("\nEnter the amount: ");
            book.Amount = Functions.CheckNumber(Console.ReadLine());
            Console.Write("\nEnter the year: ");
            book.Year = Functions.CheckNumber(Console.ReadLine());
            books.Add(book);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The book is added successfully!");
            Console.ResetColor();
        }
        internal void Delete()
        {
            if (books.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is emty.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine("Enter the name of book you want to delete:");
            Print();
            string str = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (var book in books)
            {
                if (book.Name == str)
                {
                    numbers.Add(books.IndexOf(book));
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No matches found.");
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                books.RemoveAt(numbers[i] - i);
            }
            Print();
        }

        internal void Edit()
        {
            if (books.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List of books is emty.");
                Console.ResetColor();
                return;
            }
            List<int> numbers = new List<int>();
            while (numbers.Count == 0)
            {
                Console.WriteLine("Enter the name of book you want to edit ('cancel' to exit):");
                Print();
                string str = Console.ReadLine();
                if (str == "cancel")
                {
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var book in books)
                {
                    if (book.Name.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        numbers.Add(books.IndexOf(book));
                        Console.WriteLine("id:" + books.IndexOf(book) + " " + book.Name);
                    }
                }
                Console.ResetColor();
                if (numbers.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No matches found");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Enter id of book you want to edit:");
            int number = Functions.CheckNumber(Console.ReadLine());
            while (!numbers.Contains(number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no books whith such id");
                Console.ResetColor();
                Console.WriteLine("Enter id of books you want to edit:");
                number = Functions.CheckNumber(Console.ReadLine());
            }
            Edit(books[number]);

            books[number].Print();
        }

        void Edit(Book book)
        {
            string str = "";
            Console.WriteLine("Which parameter do you want to change?");
            Console.WriteLine("   name" + "\n   author" + "\n   genre" + "\n   publishing" + "\n   amount" + "\n   year" + "\n   cancel");
            while (str != "cancel")
            {
                switch (str = Console.ReadLine())
                {
                    case ("name"):
                        Console.WriteLine("Enter a new name:");
                        book.Name = Console.ReadLine();
                        break;
                    case ("author"):
                        Console.Write("\nEnter a new author: ");
                        book.Author = Console.ReadLine();
                        break;
                    case ("genre"):
                        Console.Write("\nEnter a new genre: ");
                        book.Genre = Console.ReadLine();
                        break;
                    case ("publishing"):
                        Console.WriteLine("Enter the new publishing:");
                        book.PublishingHouse = Console.ReadLine();
                        break;
                    case ("amount"):
                        Console.WriteLine("Enter the new amount:");
                        book.Amount = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("year"):
                        Console.WriteLine("Enter the new amount:");
                        book.Year = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("cancel"):
                        break;
                    default:
                        Console.WriteLine("Available commands:" + "\n   name" + "\n   author" + "\n   genre" + "\n   publishing" + "\n   amount" + "\n   year" + "\n   cancel");
                        break;
                }
                Console.WriteLine("Which parameter do you want to change?");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The book is edited successfully!");
            Console.ResetColor();
        }
        internal void Print()
        {
            if (books.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List of books is emty.");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.WriteLine("List of books:");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var book in books)
            {
      
                Console.WriteLine(books.IndexOf(book) + 1 + ") "+ $"Name: {book.Name}; Aythor: {book.Author}; Genre: {book.Genre}; Publishing hous: {book.PublishingHouse}; Amount: {book.Amount}; Year: {book.Year}");
            }
            Console.ResetColor();
        }
        internal int Print(string str)
        {
            int count = 0;
            foreach (var book in books)
            {
                if (book.Name.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0)//Поиск по подстроке без учёта регистра
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(books.IndexOf(book) + 1 + ") ");
                    book.Print();
                    count++;
                }
            }
            return count;
        }

       
    }
}
