using System;

namespace librarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepo bookRepo = new BookRepo();
            MagazineRepo magazinesRepo = new MagazineRepo();
            
           
            string str = "";
            Console.WriteLine("Available commands:" + "\n   add" + "\n   delete" + "\n   edit"
                            + "\n   show" + "\n   search" + "\n   -exit" + "\n   -help");
            while (str != "-exit") 
            {
                Console.WriteLine("Enter command (-help for reference):");
                switch (str = Console.ReadLine())
                {
                    case ("-help"):
                        Console.WriteLine("Available commands:" + "\n   add" + "\n   delete" + "\n   edit"
                           +"\n   show" + "\n   search" + "\n   -exit" + "\n   -help");
                        break;
                    case ("-exit"):
                        break;
                    case ("add"):
                        Console.WriteLine("What do you want to add?" + "\n   1)book" + "\n   2)mag");
                        switch (Console.ReadLine())
                        {
                            case ("book"):
                                bookRepo.Add();
                                break;
                            case ("mag"):
                                magazinesRepo.Add();
                                break;
                        }
                        break;
                    case ("delete"):
                        Console.WriteLine("What do you want to delete?" + "\n   1)book" + "\n   2)mag");
                        switch (Console.ReadLine())
                        {
                            case ("book"):
                                bookRepo.Delete();
                                break;
                            case ("mag"):
                                magazinesRepo.Delete();
                                break;
                        }
                       break;
                    case ("edit"):
                        Console.WriteLine("What do you want to edit?" + "\n   1)book" + "\n   2)mag");
                        switch (Console.ReadLine())
                        {
                            case ("book"):
                                bookRepo.Edit();
                                break;
                            case ("mag"):
                                magazinesRepo.Edit();
                                break;
                        }
                        break;
                   
                    case ("search"):
                        Console.WriteLine("Enter the name:");
                        string name = Console.ReadLine();
                        if (bookRepo.Print(name) + magazinesRepo.Print(name) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No matches found.");
                            Console.ResetColor();
                        }
                        break;
                    case ("show"):
                        bookRepo.Print();
                        magazinesRepo.Print();
                        break;
                    default:
                        Console.WriteLine("Enter -help to see the list of available commands");
                        break;
                }
            }            
        }

    }    
}
