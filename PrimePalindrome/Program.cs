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
        static List<int> primePalindrome = new List<int>();

        static void Main(string[] args)
        {
            Menu();
            

            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine(@"Pres ""1"" to find the prime numbers and prime palindrome up to a certain number");
            Console.WriteLine(@"Pres ""2"" to find a certain number of prime numbers and prime palindrome");
            // Collects number from user
            int num = Convert.ToInt32(Console.ReadLine());


            if (num == 1)
            {
                Console.Clear();
                Console.Write("Enter a number to see all the time leading up to it: ");
                num = Convert.ToInt32(Console.ReadLine());
                // Gets prime numbers based on number provided by user
                getPrimeNumbers(num);
                // Prints list of prime numbers found
                printPrimeNumbers();
                // Prints out sum of all prime number found
                Console.WriteLine("The sum of all prime numbers is: {0}", PrimeNumbers.Sum());
                // Calculate list of prime palindrome
                CalculatePrimePalindrome();
                // Prints list of prime palindrome
                PrintPalindromeList();
                // Prints out largest possible prime palindrome
                Console.WriteLine("\nThe largest prime palindrome is: {0}", primePalindrome.Last());
                Console.WriteLine("The sum of all palindrome numbers is: {0}", primePalindrome.Sum());
            } else if (num == 2)
            {
                Console.Clear();
                Console.Write("Enter a number of prime numbers you wish to see: ");
                num = Convert.ToInt32(Console.ReadLine());
                getNPrimeNumbers(num);
                CalculatePrimePalindrome();
                // Prints out sum of all prime number found
                Console.WriteLine("The sum of first {0} prime numbers is: {1}",num , PrimeNumbers.Sum());
                Console.WriteLine("The sum of the palindromes in the first {0} is: {1}", num, primePalindrome.Sum());
            }
  
        }

        private static void getNPrimeNumbers(int n)
        {
            int i = 0, counter, tempNum = 0;
            while(PrimeNumbers.Count < n)
            {
                counter = 0;
                i++;
                tempNum = (int)Math.Sqrt(i);

                // Loop to the result of square root of number
                for (int j = 1; j <= tempNum; j++)
                {
                    // If any number in the loop is equal to the number determined by outter loop this runs
                    if (i % j == 0)
                    {
                        counter++;
                        // This is prime rule 
                        if (i % i == 0)
                            counter++;
                    }

                }

                // If counter is > 2 which means its divisible by more than 2 numbers 
                // and i is not 1 which is a prime rule this runs
                if (counter > 0 && counter < 3 && i != 1)
                {
                    // Adds value to the prime number list
                    PrimeNumbers.Add(i);
                }
            }

            Console.WriteLine("\nWent through {0} numbers to find {1} prime numbers.\n", i, PrimeNumbers.Count());
        }

        // Prints list of calculated palindromes
        private static void PrintPalindromeList()
        {
            Console.WriteLine("\nThese are the list of prime palindromes");
            foreach(int n in primePalindrome)
            {
                Console.Write("{0} ",n);
            }
        }
        // Finds the prime palindrome fromt he list of prime numbers
        private static void CalculatePrimePalindrome()
        {
            // Loops through all prime numbers in list
            foreach (int n in PrimeNumbers)
            {
                // If number is a prime palindrome add it to list
                if (isPrimePalindrome(Convert.ToString(n)))
                {
                    primePalindrome.Add(n);
                }
            }
        }
        // Checks if the prime number is a prime palindrome
        private static bool isPrimePalindrome(string v)
        {
            // If the first index is equall to last index return true
            if (v.First() == v.Last())
            {
                return true;
            }
            return false;
        }
        // Gets the list of prime number form number provided by user
        private static void getPrimeNumbers(int n)
        {
            int counter;

            // Loop to run through the numbers and find if it is prime
            for(int i = 1; i <= n; i++)
            {
                // Gets the square root of each number
                int numsToCheck = (int)Math.Sqrt(i);
                // Reset counter to 0
                counter = 0;

                // Loop to the result of square root of number
                for (int j = 1; j <= numsToCheck; j++)
                {
                    // If any number in the loop is equal to the number determined by outter loop this runs
                    if (i % j == 0)
                    {
                        counter++;
                        // This is prime rule 
                        if (i % i == 0)
                            counter++;
                    }

                }

                // If counter is > 2 which means its divisible by more than 2 numbers 
                // and i is not 1 which is a prime rule this runs
                if (counter > 0 && counter < 3 && i != 1)
                {
                    // Adds value to the prime number list
                    PrimeNumbers.Add(i);
                } 

            }
        }
        // Prints out all prime numbers in list
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
