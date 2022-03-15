using System;

namespace librarian
{
    static class Functions
    {
        /// <summary>
        /// Возвращает целое число больше нуля
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static int CheckNumber(string str)
        {
            int n;
            while (!int.TryParse(str, out n) || n < 0)
            {
                Console.WriteLine("Enter the number more than zero!");
                str = Console.ReadLine();
            }
            return n;
        }

        
    }
}
