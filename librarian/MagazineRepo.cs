using System;
using System.Collections.Generic;

namespace librarian
{
    internal class MagazineRepo
    {
        static List<Magazine> magazines = new List<Magazine>();
        internal void Add()
        {
            Magazine magazine = new Magazine();
            Console.Write("\nEnter the name: ");
            magazine.Name = Console.ReadLine();
            Console.Write("\nEnter the periodicity of releases: ");
            magazine.Periodicity = Functions.CheckNumber(Console.ReadLine());
            Console.Write("\nEnter the amount: ");
            magazine.Amount = Functions.CheckNumber(Console.ReadLine());
            Console.Write("\nEnter the publishing hous: ");
            magazine.PublishingHouse = Console.ReadLine();
            Console.Write("\nEnter the number: ");
            magazine.Number = Functions.CheckNumber(Console.ReadLine());
            Console.Write("\nEnter the year: ");
            magazine.Year = Functions.CheckNumber(Console.ReadLine());
            magazines.Add(magazine);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The magazine is added successfully!");
            Console.ResetColor();
        }
        internal void Delete()
        {
            if (magazines.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List is empty.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine("Enter the name of magazine you want to delete:");
            Print();
            string str = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (var magazine in magazines)
            {
                if (magazine.Name == str)
                {
                    numbers.Add(magazines.IndexOf(magazine));
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No matches found.");
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                magazines.RemoveAt(numbers[i] - i);
            }
            Print();
        }        

        internal void Edit()
        {
            if (magazines.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List of magazines is emty.");
                Console.ResetColor();
                return;
            }
            List<int> numbers = new List<int>();
        while (numbers.Count == 0)
            {
                Console.WriteLine("Enter the name of magazine you want to edit ('cancel' to exit):");
                Print();
                string str = Console.ReadLine();
                if (str == "cancel")
                {
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var magazine in magazines)
                {
                    if (magazine.Name.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        numbers.Add(magazines.IndexOf(magazine));
                        Console.WriteLine("id:" + magazines.IndexOf(magazine) + " " + magazine.Name);
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
                Console.WriteLine("Enter id of magazine you want to edit:");
                int number = Functions.CheckNumber(Console.ReadLine());
            while (!numbers.Contains(number)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no magazines whith such id");
                Console.ResetColor();
                Console.WriteLine("Enter id of magazine you want to edit:");
                number = Functions.CheckNumber(Console.ReadLine());
            }
            Edit(magazines[number]);

            magazines[number].Print();
        }

        void Edit(Magazine mag)
        {
            string str = "";
            Console.WriteLine("Which parameter do you want to change?");
            Console.WriteLine("   name" + "\n   number" + "\n   pereodicity" + "\n   publishing" + "\n   amount" + "\n   year" + "\n   cancel");
            while (str != "cancel")
            {
                switch (str = Console.ReadLine())
                {
                    case ("name"):
                        Console.WriteLine("Enter the new name:");
                        mag.Name = Console.ReadLine();
                        break;
                    case ("number"):
                        Console.WriteLine("Enter the new number: ");
                        mag.Number = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("periodicity"):
                        Console.WriteLine("Enter the new periodicity:");
                        mag.Periodicity = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("publishing"):
                        Console.WriteLine("Enter the new publishing:");
                        mag.PublishingHouse = Console.ReadLine();
                        break;
                    case ("amount"):
                        Console.WriteLine("Enter the new amount:");
                        mag.Amount = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("year"):
                        Console.WriteLine("Enter the new amount:");
                        mag.Year = Functions.CheckNumber(Console.ReadLine());
                        break;
                    case ("cancel"):
                        break;
                    default:
                        Console.WriteLine("Available commands:" + "\n   name" + "\n   number" + "\n   pereodicity" + "\n   publishing" + "\n   amount" + "\n   year" + "\n   cancel");
                        break;
                }
                Console.WriteLine("Which parameter do you want to change?");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The magazine is edited successfully!");
            Console.ResetColor();
        }

        internal void Print()
        {
            if (magazines.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List of magazines is emty.");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.WriteLine("List of magazines:");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var magazine in magazines)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(magazines.IndexOf(magazine) + 1 + ") ");
                magazine.Print();
            }
            Console.ResetColor();
        }
        internal int Print(string str)
        {
            int count = 0;

            foreach (var magazine in magazines)
            {
                if (magazine.Name.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0 )//Поиск по подстроке без учёта регистра
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(magazines.IndexOf(magazine) + 1 + ") ");
                    magazine.Print();
                    count++;
                }
            }
            return count;
        }
       
        
    }
}
