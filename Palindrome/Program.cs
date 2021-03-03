using System;

namespace Palindrome_02_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            while (true)
            {
                Console.Write("Enter your text for cheking: ");
                str = Console.ReadLine();
                if (IsPalindrome(str))
                {
                    Console.WriteLine("Text is Palindrom.");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Text is'nt Palindrom.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }
        public static bool IsPalindrome(string str)
        {
            int length = str.Length;
            int i = 0;
            while (true)
            {
                length--;
                if (i >= length)
                    break;
                if (str[i] != str[length])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
