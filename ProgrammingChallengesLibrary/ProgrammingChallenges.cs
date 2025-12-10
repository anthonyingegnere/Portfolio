using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace ProgrammingChallengesLibrary
{
    public static class ProgrammingChallenges
    {

        // 0.1 example hook-up
        public static string HelloWorld(string name)
        {
            return $"Hello, {name}";
        }

        // 1.
        public static int[] FindSmallestAndBiggestNumbers(int[] numbers)
        {
            // declare an empty array that we will return.
            // first entry being smallest & second being biggest
            int[] result = new int[2];

            // set smallest & biggest numbers to be the first number in the list
            // because we need somewhere to start (take first number, compare to x)
            int smallestNumber = numbers[0];
            int biggestNumber = numbers[0];

            foreach (int nextNumber in numbers)
            {
                // compare the first number to next number in list
                bool isStillSmallest = smallestNumber < nextNumber;
                bool isStillBiggest = biggestNumber > nextNumber;

                // keep hold of the smallest
                if (isStillSmallest == false)
                {
                    smallestNumber = nextNumber;
                }

                // keep hold of the biggest
                if (isStillBiggest == false)
                {
                    biggestNumber = nextNumber;
                }
            }

            // assign smallest and biggest to result
            result[0] = smallestNumber;
            result[1] = biggestNumber;
            
            return result;
        }

        // 2.
        public static string HackerSpeak(string input)
        {
            // declare an empty string so we have something to build into
            string result = "";

            foreach (char c in input)
            {
                // initialising a new variable so we can access c in our logic  to update it with the new char
                char nextLetter = c;

                //TODO: update to .ToLower on all but one to show working example
                // so we check the value of c and if it matches the character we have specified, update it to the new character
                switch (nextLetter)
                {
                    case 'a':
                    case 'A':
                        nextLetter = '4';
                        break;

                    case 'e':
                    case 'E':
                        nextLetter = '3';
                        break;

                    case 'i':
                    case 'I':
                        nextLetter = '1';
                        break;

                    case 'o':
                    case 'O':
                        nextLetter = '0';
                        break;

                    case 's':
                    case 'S':
                        nextLetter = '5';
                        break;
                        
                    default:
                        break;
                }
                // here we build the new string by updating it with each indivdual letter
                result = result + nextLetter;
            }
            return result;
        }

        // 3.
        public static int LetterCounter(string input)
        {
            // create a variable for the running total
            int letterTotal = 0;

            // get the next character of the string
            foreach (char nextChar in input)
            {
                //TODO: update to use .ToLower() 
                // check if it matches what we want (D)
                if (nextChar == 'd' || nextChar == 'D')
                {
                    // if it does, count it and add it to running total.
                    letterTotal++;
                }
            }
            // present total 
            return letterTotal;
        }

        // 4.
        public static string[] FizzBuzz(int[] input)
        {
            // declaring output variables
            string isFizz = "Fizz";
            string isBuzz = "Buzz";
            string isFizzBuzz = "FizzBuzz";

            string[] fizzBuzzResult = new string[input.Length];

            // look at the next character of the array, noting the index along the way
            for (int i = 0; i < input.Length; i++)
            {
                // initialising a variable to get the next letter in the array using i
                int nextInt = input[i];

                // boolean to determine if the nextInt is divisible by 3 or 5
                bool divisibleBy3 = (nextInt % 3) == 0;
                bool divisibleBy5 = (nextInt % 5) == 0;

                // consider if it is a multiple of 3 & 5
                // we do this first so we dont exit out of the loop early.
                if (divisibleBy3 && divisibleBy5)
                {
                    fizzBuzzResult[i] = isFizzBuzz;
                }
                // consider if it is a multiple of 3
                else if (divisibleBy3)
                {
                    fizzBuzzResult[i] = isFizz;
                }
                // consider if it is a multiple of 5
                else if (divisibleBy5)
                {
                    fizzBuzzResult[i] = isBuzz;
                }
                // if it is not any of the above, print as is.
                else
                {
                    fizzBuzzResult[i] = nextInt.ToString();
                }
            }
            return fizzBuzzResult;
        }

        // 5.

        // we are using an Optional parameter here for efficiency and readability on the main class
        public static string GetFileName(string filePath = "default/filepath")
        {
            // initialise result
            string fileNameResult = "";

            // get the last index of the filePath
            //TODO: tell me why -1
            int lastIndexOfSlash = -1;

            // needs / because the last / will be where the fileName will start
            char slash = '/';

            //TODO: add comments
            for (int i = 0; i < filePath.Length; i++)
            {  
                if (filePath[i] == slash)
                {
                    lastIndexOfSlash = i;
                }
            }
            
            // checks if there is a / in the filePath
            if (lastIndexOfSlash >= 0)
            {
                // create a string containing the last part of filePath from the point of the last index
                for (int i = lastIndexOfSlash + 1; i < filePath.Length; i++)
                {
                    fileNameResult = fileNameResult + filePath[i].ToString();
                }
            }
            // if no / is present. Return the filePath
            else
            {
                fileNameResult = filePath;
            }

            // return string
            return fileNameResult;
        }

        // 6.
        public static decimal AmongUsImposterFormula(int[] gameStats)
        {
            // Formula for percentage = 100 x (i / p)
            // where i is imposter and p is number of players

            // declaring a decimal variable for imposter and player count
            // and assigning them to the first and second index of array
            decimal imposterCount = gameStats[0];
            decimal playerCount = gameStats[1];

            // perform equation on the two numbers to get our decimal using percentage format specifier in hookup 
            decimal imposterPercentage = (imposterCount / playerCount);

            return imposterPercentage;
        }

        // 7.
        public static decimal CalculateTheMean(int[] listOfNumbers)
        {
            // Mean Calculation - add the values together and divide by the total number of values
            
            //TODO: Write more comments

            decimal totalNumbersInList = listOfNumbers.Length;
            decimal sumOfNumbers = 0.00m;

            // get the array and start adding the values together
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                sumOfNumbers += listOfNumbers[i];
            }

            // perform mean calculation
            decimal meanCalculation = sumOfNumbers / totalNumbersInList;

            // output result
            return Math.Round(meanCalculation, 2);
        }

        // 8.
        public static bool PinCodeValidation(string atmInput)
        {
            // variable for correct pin
            string correctPin = "1234";

            // create variable to handle valid or invalid pin entry
            bool isValidPin = false;

            // get atm input and check it against the valid pin
            if (atmInput == correctPin)
            {
                isValidPin = true;
            }

            // output result
            return isValidPin;
        }

        // 9.

        //TODO: one return
        public static bool FormatValidation(string phoneNumberInput)
        {
            // correct format example = (123) 456-7890

            // create variable to handle valid or invalid phone number entry
            bool isValidFormat = false;

            //TODO: make this one if
            // check the input is 14 characters long
            if (phoneNumberInput.Length != 14)
            {
                return isValidFormat;
            }

            // check the indexed value at 0 and 4 to ensure the area code () identifier is present
            if (phoneNumberInput[0] != '(' && phoneNumberInput[4] != ')')
            {
                return isValidFormat;
            }

            if (phoneNumberInput[4] != ')')
            {
                return isValidFormat;
            }

            // check the indexed value at 5 for whitespace
            if (phoneNumberInput[5] != ' ')
            {
                return isValidFormat;
            }

            // check the indexed value at 9 for a -
            if (phoneNumberInput[9] != '-')
            {
                return isValidFormat;
            }

            // Question: can I handle the validation here if i had access to .net library
             
            // check that each other character in the string is a numerical value between 0-9
            for (int i = 0; i < phoneNumberInput.Length; i++)
            {
                // initialise a variable to access the value of i
                char nextChar = phoneNumberInput[i];

                //TODO: reverese the order. do the opposite indexes as a !=
                // when the indexed position is at any of these spots. then execute the block within
                if (i == 1 || i == 2 || i == 3 || i == 6 || i == 7 || i == 8 || i == 10 || i == 11 || i == 12 || i == 13)
                {
                    //TODO: update to char.IsDigit()
                    if (nextChar == '1'
                        || nextChar == '2'
                        || nextChar == '3'
                        || nextChar == '4'
                        || nextChar == '5'
                        || nextChar == '6'
                        || nextChar == '7'
                        || nextChar == '8'
                        || nextChar == '9'
                        || nextChar == '0')
                    {
                        isValidFormat = true;
                    }
                    else
                    {
                        isValidFormat = false;
                        return isValidFormat;
                    }  
                }
            }
            return isValidFormat;
        }

        // 10.

        //TODO: one return method
        public static bool PrimeNumberChecker(int isThisPrime)
        {
            bool isPrimeNumber = true;
            
            // checks to make sure the number is a positive first.
            if (isThisPrime <= 1)
            {
                isPrimeNumber = false;
                return isPrimeNumber;
            }

            // check if the number is divisible by anything up to itself. 
            for (int i = 2; i < isThisPrime; i++)
            {
                if (isThisPrime % i == 0)
                {
                    // if the number is divisible evenly by any of the numbers between 2 and itself, set isPrimeNumber and return it.
                    isPrimeNumber = false;
                    return isPrimeNumber;
                } 
            }
            return isPrimeNumber;
        }

















    }
}
