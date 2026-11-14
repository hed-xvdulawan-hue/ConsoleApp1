// DSA Activity 5.2 - Dulawan, Xyra Venylle


using System;
using System.Collections.Generic;

namespace DSAActivity5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PALINDROME PROGRAM");
            Console.WriteLine("Enter 0 to exit.\n");

            while (true)
            {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                if (word == null)      
                    break;

                word = word.Trim();

                if (word == "0")        
                    break;

                if (word.Length == 0)
                {
                    Console.WriteLine("Please enter a word.\n");
                    continue;
                }

                if (IsPalindrome(word))
                    Console.WriteLine("It is PALINDROME\n");
                else
                    Console.WriteLine("It is NOT PALINDROME\n");
            }

            Console.WriteLine("Thank you for using the program");
        }
        static bool IsPalindrome(string word)
        {
            string text = word.ToLower();
            Stack<char> letters = new Stack<char>();

            foreach (char c in text)
                letters.Push(c);

            foreach (char c in text)
            {
                if (letters.Pop() != c)
                    return false;
            }

            return true;
        }
    }
}
