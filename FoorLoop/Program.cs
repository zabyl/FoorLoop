using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // sum of all odd numbers from 1 to 99
            int oddNum = 1;
            int maxOddNum = 99;
            int sumOfOdds = 0;

            for (int i = oddNum; i < maxOddNum + 1; i += 2)
            {
                sumOfOdds += i;
            }
            Console.WriteLine("Sum of odds from 1 to 99: " + sumOfOdds);


            // sum of all even numbers from 2 to 100
            int evenNum = 2;
            int maxEvenNum = 100;
            int sumOfEvens = 0;

            for (int i = evenNum; i < maxEvenNum + 1; i += 2)
            {
                sumOfEvens += i;
            }
            Console.WriteLine("Sum of evens from 2 to 100: " + sumOfEvens);


            //sum of all numbers from 1 to 100
            int firstNum = 1;
            int maxNum = 100;
            int sumOfAll = 0;

            for (int i = firstNum; i < maxNum+1; i++)
            {
                sumOfAll += i;
            }
            Console.WriteLine("Sum of all numbers from 1 to 100: " + sumOfAll);

            Console.ReadLine();
        }
    }
}
