using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePalindrome
{
    class Program
    {
        // Stores Prime Numbers
        static List<int> PrimeNumbers = new List<int>();
        static List<string> primePalindrome = new List<string>();

        static void Main(string[] args)
        {
            // Collects number from user
            Console.Write("Enter a number to see all the time leading up to it: ");
            int num = Convert.ToInt32(Console.ReadLine()); 

            // Gets prime numbers based on number provided by user
            getPrimeNumbers(num);
            // Prints list of prime numbers found
            printPrimeNumbers();
            // Calculate list of prime palindrome
            CalculatePrimePalindrome();
            // Prints list of prime palindrome
            PrintPalindromeList();
            // Prints out largest possible prime palindrome
            Console.WriteLine("\nThe largest prime palindrome is: {0}", primePalindrome.Last()); 

            Console.ReadKey();
        }

        private static void PrintPalindromeList()
        {
            Console.WriteLine("\nThese are the list of prime palindromes");
            foreach(string n in primePalindrome)
            {
                Console.Write("{0} ",n);
            }
        }

        private static void CalculatePrimePalindrome()
        {
            foreach (int n in PrimeNumbers)
            {
                if (isPrimePalindrome(Convert.ToString(n)))
                {
                    primePalindrome.Add(Convert.ToString(n));
                }
            }
        }

        private static bool isPrimePalindrome(string v)
        {
            if (v.First() == v.Last())
            {
                return true;
            }
            return false;
        }

        private static void getPrimeNumbers(int n)
        {
            int counter = 0;

            for(int i = 1; i <= n; i++)
            {
                int numsToCheck = (int)Math.Sqrt(i);
                counter = 0;

                for (int j = 1; j <= numsToCheck; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;

                        if (i % i == 0)
                            counter++;
                    }

                }

                if (counter > 0 && counter < 3 && i != 1)
                {
                    PrimeNumbers.Add(i);
                } 

            }
        }

        private static void printPrimeNumbers()
        {
            Console.WriteLine("\nHere are the list of prime numbers...");
            foreach (int num in PrimeNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
