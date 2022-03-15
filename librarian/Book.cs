using System;

namespace librarian
{
    internal class Book: PrintedLiterature
    {
        string author;
        string genre;
       
        /// <summary>
        /// Автор литературы
        /// </summary>
        public string Author 
        { 
            get 
            { 
                return author; 
            } 
            internal set 
            { 
                author = value; 
            } 
        }
        /// <summary>
        /// Жанр литературы
        /// </summary>
        public string Genre 
        { 
            get
            { 
                return genre; 
            } 
            internal set 
            { 
                genre = value; 
            } 
        }
        
        /// <summary>
        /// Выводит данные об объекте на экран
        /// </summary>
        internal void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Name: {Name}; Aythor: {Author}; Genre: {Genre}; Publishing hous: {PublishingHouse}; Amount: {Amount}; Year: {Year}");
            Console.ResetColor();
        }

        
    }
}
