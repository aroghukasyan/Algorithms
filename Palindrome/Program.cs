using System;
using System.Linq;

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
                // there is you can testing method1 and method2
                if (IsPalindrome2(str)) 
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
        public static bool IsPalindrome2(string str)
        {
            int half = str.Length / 2;
            string part1 = str.Substring(0, half);
            string part2;
              if(str.Length % 2 == 0) {
                part2 = str.Substring(half, half);
            } else {
                part2 = str.Substring(half + 1, half);
            }
            int j = half;
            for (int i = 0; i < half; i++ )
            {
                if (part1[i] != part2[j-1]) return false;
                j--;
            }
            return true;
            //Console.WriteLine(part1);
            //Console.WriteLine(part2);
        }
    }
}
