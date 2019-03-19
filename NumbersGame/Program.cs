using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();

        }

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                string answer = Console.ReadLine();
                int arrayLength = Convert.ToInt32(answer);
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format.");
                Console.WriteLine(formEx.Message);
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }

        static void Populate()
        {
            try
            {



            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }

        static void GetSum()
        {
            try
            {



            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }

        static void GetProduct()
        {
            try
            {



            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }

        static void GetQuotient()
        {
            try
            {



            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }
    }
}
