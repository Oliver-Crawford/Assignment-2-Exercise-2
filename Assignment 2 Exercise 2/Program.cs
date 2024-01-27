using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write an application which lets user input an array of N elements of integer.
              Then application the arrayand the position of the first smallest integer. */
            Console.WriteLine("How long do you want the array to be");
            int arraylength = sanitizeIntInput();
            int[] array = new int[arraylength];
            int smallestValue = int.MaxValue;
            int smallestIndex = 0;
            for(int i = 0; i < arraylength; i++)
            {
                int arrayInt = sanitizeIntInput();
                array[i] = arrayInt;
            }
            Console.Write("The Array: ");
            foreach(int i in array)
            {
                if (smallestValue > i)
                {
                    smallestValue = i;
                }
                Console.Write(i);
            }
            foreach(int i in array)
            {
                if(i == smallestValue)
                {
                    smallestIndex = i;
                    break;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"The first smallest value is {smallestValue} and it's index is {smallestIndex}");

            Console.ReadLine();
        }
        static int sanitizeIntInput()
        {
            bool isInt = false;
            string input;
            int inputInt = 0;
            while (!isInt)
            {
                input = Console.ReadLine();
                isInt = int.TryParse(input, out inputInt);
                if (!isInt)
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
            return inputInt;
        }
    }
}
