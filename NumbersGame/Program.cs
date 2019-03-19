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
                Console.WriteLine("Enter a number greater than zero"); //message to user to enter a number
                string answer = Console.ReadLine(); //collects user entry as a string
                int arrayLength = Convert.ToInt32(answer); //converts the user input into an integer to be used in the Populate Method as the length of the array
                int[] arrayResult = Populate(arrayLength);  //sends the user input to the Populate Method
                int sum = GetSum(arrayResult);
                int product = GetProduct(arrayResult);
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format in the StartSequence method.");
                Console.WriteLine(formEx.Message);
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }
        }

        static int[] Populate(int arrayLength)
        {
            try
            {
                int[] arrayNum = new int[arrayLength]; //creates an array of the individual user inputted numbers
                string popNum; //creates a string variable needed for user input

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Please enter number: {i + 1} of {arrayLength} ->");
                    popNum = Console.ReadLine(); //collects user input as a string
                    arrayNum[i] = Convert.ToInt32(popNum); //converts user input into an integer to add into an array
                }

                
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format in the Populate method.");
                Console.WriteLine(formEx.Message);
            }
            catch (IndexOutOfRangeException IOoREx)
            {
                Console.WriteLine("Too many numbers entered.");
                Console.WriteLine(IOoREx.Message);
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }

            return arrayNum;
        }

        static void GetSum(int[] arrayResult)
        {
            try
            {
                int runningSum = 0; //establishes the initial value for the runningSum
                for (int i = 0; i < arrayResult.Length; i++) //adds each index value into runningSum
                 {
                    runningSum = runningSum + arrayResult[i];
                 }

                return runningSum;

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
