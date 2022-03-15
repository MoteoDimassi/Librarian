using System;

namespace librarian
{
    internal class Magazine: PrintedLiterature
    {
        int periodicity;
        int number;
        
        public int Number
        {
            get { return number; }
            internal set
            {
                while (value < 1)
                {
                    Console.WriteLine("Magazines starts from the first number. Make shure you entered the correct number!");
                    value = Functions.CheckNumber(Console.ReadLine());
                }
                number = value;
            }
        }
        public int Periodicity
        {
            get { return periodicity; }
            internal set
            {
                while (value < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Periodicity must be more than zero!");
                    Console.ResetColor();
                    value = Functions.CheckNumber(Console.ReadLine());
                }
                periodicity = value;
            }
        }

        internal void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Name: {Name}; Number: {Number}; Periodicite: {Periodicity}; Publishing hous: {PublishingHouse}; Amount: {Amount}; Year: {Year}");
            Console.ResetColor();
        }
                
    }
}
