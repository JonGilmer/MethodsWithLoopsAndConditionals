using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Print1K_toNeg1K();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.Print1K_by3s();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.EqualOrNot();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.EvenOrOdd();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.PositiveOrNegative();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.VoterAge();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.WithinRange();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            Program.MultiplicationTable();
            Console.Write("Press any key to exit ");
            Console.WriteLine("");
        }







        //This method prints off every number, descending from 1000 - (-1000).
        public static void Print1K_toNeg1K()
        {
            for (int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }



        //This method prints off every number between 0 and 1000 in increments of 3.
        public static void Print1K_by3s()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }



        //This method checks to see if 2 given numbers are equal or not.
        public static void EqualOrNot()
        {
            Console.WriteLine("Welcome! Please Enter 2 Numbers to see if they are equal or not.");
            Console.WriteLine("");

            Console.Write("First Number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Second Number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"These 2 numbers, {num1} and {num2}, are equal.");
            }
            else
            {
                Console.WriteLine($"These 2 numbers, {num1} and {num2}, are NOT equal.");
            }
        }



        //This method checks to see if a number you input is even or odd.
        public static void EvenOrOdd()
        {
            Console.WriteLine("Welcome! Let's see if your number is even or odd.");
            Console.WriteLine("");
            Console.Write("Please enter your number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"Your number, {num1}, is even.");
            }
            else
            {
                Console.WriteLine($"Your number, {num1}, is odd.");
            }
        }



        //This method checks to see if a number you input is positive or negative.
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Welcome! Let's see if your number is positive or negative.");
            Console.WriteLine("");
            Console.Write("Please enter your number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine($"Your number, {num1} is positive.");
            }
            else if (num1 < 0)
            {
                Console.WriteLine($"Your number, {num1} is negative.");
            }
            else
                Console.WriteLine($"Your number, {num1} must be zero!");

        }



        //This method allows a user to input their age and will check to see if they are old enough to vote or not.
        public static void VoterAge()
        {
            Console.WriteLine("Welcome! Let's see if you're old enough to vote.");
            Console.WriteLine("");
            Console.Write("Please enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You may vote.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Looks like you're too young this time!");
            }
            else
            {
                Console.WriteLine("Congratulations! It looks like you just became old enough to vote!");
            }
        }



        //This method takes an integer from the user and determines whether it is in the range of -10 to 10.
        public static void WithinRange()
        {
            Console.Write("Welcome! Enter a number to see if it falls within the range of -10 to 10. ");
            Console.WriteLine("");
            int num = Int32.Parse(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"Your number {num} is within the range.");
            }
            else
            {
                Console.WriteLine($"Your number {num} is NOT within the range.");
            }
        }



        //This method displays the multiplication table from 1 - 12 of a given integer.
        public static void MultiplicationTable()
        {
            Console.Write("Welcome! Please enter a number you would like to see the multiplication table for (1-12). ");
            Console.WriteLine("");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

        }
    }
}
