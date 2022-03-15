using System;

namespace librarian
{
    internal class PrintedLiterature
    {
        int amount;
        int year;
        string name;
        string publishingHouse;
        /// <summary>
        /// Название литераты
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            internal set 
            { 
                name = value; 
            } 
        }
        /// <summary>
        /// Название издательства
        /// </summary>
        public string PublishingHouse 
        { 
            get 
            { 
                return publishingHouse; 
            } 
            internal set 
            { 
                publishingHouse = value; 
            } 
        }
        /// <summary>
        /// количество одинаковых копий литературы
        /// </summary>
        public int Amount 
        { 
            get 
            { 
                return amount; 
            } 
            internal set 
            { 
                amount = value; 
            } 
        }
        /// <summary>
        /// Год издания
        /// </summary>
        public int Year
        {
            get 
            { 
                return year; 
            }
            internal set
            {
                while (value < 1200 || value > 2022)
                {
                    if (value < 1200)
                    {
                        Console.WriteLine("Таких старых книг не сохранилось до наших дней. Введите в диапазоне от 1200 до 2022");

                    }
                    else
                    {
                        Console.WriteLine(" Этот год только наступит. Тукщий год 2022");
                    }
                    value = Functions.CheckNumber(Console.ReadLine());
                }
                year = value;
            }
        }
        
    }
}
