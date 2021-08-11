using System;
using System.Collections.Generic;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> MyInts = new List<int>() { 3, 25, 108, 756, 1, 29, 1000, 63, 421, 1028 };

                Console.WriteLine("Please type a number to divide into diferent values on this list:\n");
                int userInput = Convert.ToInt32(Console.ReadLine());
                
                foreach (int num in MyInts)
                {
                    int result = num / userInput;
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide bt 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use only numbers");
            }
            finally
            {
                Console.WriteLine("The programme is complete");
            }

            Console.WriteLine("\n\n\nThis message is the proof");
        }
    }
}
