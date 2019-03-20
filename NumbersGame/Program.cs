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

                int product = GetProduct(sum, arrayResult);

                int quotent = GetQuotient(product);

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

                return arrayNum;
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
            return null;
            
        }

        static int GetSum(int[] arrayResult)
        {
            int runningSum = 0; //establishes the initial value for the runningSum

            try
            {
                
                for (int i = 0; i < arrayResult.Length; i++) //adds each index value into runningSum
                 {
                    runningSum = runningSum + arrayResult[i];
                 }


            }
            catch (OverflowException ofEx)
            {
                Console.WriteLine("The sum total is too big of a number");
                Console.WriteLine(ofEx.Message);
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }

            return runningSum;
        }

        static int GetProduct(int firstMult, int[] arrayResult)
        {
            int product = 1;

            try
            {
                Console.WriteLine($"Please select a random number between 1 and {arrayResult.Length}");
                string answer = Console.ReadLine();
                int indexMult = Convert.ToInt32(answer);
                int secondMult = arrayResult[indexMult];

                product = firstMult * secondMult;

            }
            catch (OverflowException ofEx)
            {
                Console.WriteLine("The product total is too big of a number");
                Console.WriteLine(ofEx.Message);
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }

            
            return product;
        }

        static int GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide your product {product} by");
                string divNum = Console.ReadLine(); //gathers the users divisor
                int divisor = Convert.ToInt32(divNum); //convert to int

                int quotient = product / divisor;

                return quotient;
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
            }

            return product;
        }
    }
}
