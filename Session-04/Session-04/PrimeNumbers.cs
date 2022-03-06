using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 // verbose session
{
    class PrimeNumbers
    {
        public PrimeNumbers() { }
        //function to check if a given number is prime
        static bool isPrime(int n)
        {
            //since 0 and 1 is not prime return false.
            if (n == 1 || n == 0) return false;

            //Run a loop from 2 to n-1
            for (int i = 2; i < n; i++)
            {
                // if the number is divisible by i, then n is not a prime number.
                if (n % i == 0) return false;
            }
            //otherwise, n is prime number.
            return true;
        }

        public static void PrintPrime(String[] args)
        {
            int number;
            Console.WriteLine("Give me a Number and i will give you back all prime numbers to your number.");
            number = Convert.ToInt32(Console.ReadLine());

            //check for every number from 1 to number
            for (int i = 1; i <= number; i++)
            {
                //check if current number is prime
                if ( isPrime(i) )
                {
                    Console.Write(i + " ");
                }
            }

        }
    }

}

