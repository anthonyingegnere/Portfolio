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

                // so we check the value of c and if it matches the character we have specified, update it to the new character
                switch (nextLetter.ToString().ToLower())
                {
                    
                    case "a":
                    //case 'A':
                        nextLetter = '4';
                        break;

                    case "e":
                    //case 'E':
                        nextLetter = '3';
                        break;

                    case "i":
                    //case 'I':
                        nextLetter = '1';
                        break;

                    case "o":
                    //case 'O':
                        nextLetter = '0';
                        break;

                    case "s":
                    //case 'S':
                        nextLetter = '5';
                        break;

                    default:
                        nextLetter = c;
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
            foreach (char nextChar in input.ToLower())
            {
                // check if it matches what we want (D)
                if (nextChar == 'd')
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
            // Method to take an int array and return if each value is divisible by 3 or 5 or both and assign a
            // codeword to that value and return either the codeword or the original number if not divisible by any

            // declaring output variables
            string isFizz = "Fizz";          // Divisible by 3
            string isBuzz = "Buzz";          // Divisible by 5
            string isFizzBuzz = "FizzBuzz";  // Divisible by both

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
            // we use -1 so that if there is no '/' we will put the last index at the 0 position to account for the zero-based index
            int lastIndexOfSlash = -1;

            // needs '/' because the last '/' will be where the fileName will start
            char slash = '/';

            // this loop will check each character of the string and then update the location of the last index if a '/' is present
            for (int i = 0; i < filePath.Length; i++)
            {
                if (filePath[i] == slash)
                {
                    lastIndexOfSlash = i;
                }
            }

            // checks if there is a '/' in the filePath
            if (lastIndexOfSlash >= 0)
            {
                // create a string containing the last part of filePath from the point of the last index
                for (int i = lastIndexOfSlash + 1; i < filePath.Length; i++)
                {
                    fileNameResult = fileNameResult + filePath[i].ToString();
                }
            }
            // if no '/' is present. Return the filePath
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

            // declaring as decimal so we can get an accurate sum after equation
            decimal totalNumbersInList = listOfNumbers.Length;
            decimal sumOfNumbers = 0.00m;

            // get the array and start adding the values together
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                sumOfNumbers += listOfNumbers[i];
            }

            // perform mean calculation
            decimal meanCalculation = sumOfNumbers / totalNumbersInList;

            // output result to 2 decimal places
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
        public static bool FormatValidation(string phoneNumberInput)
        {
            // correct format example = (123) 456-7890

            // create variable to handle valid or invalid phone number entry
            bool isValidFormat = false;

            // negative format validation prior to numerical validation
            if (phoneNumberInput.Length != 14   // check if the input is not 14 characters long
                || phoneNumberInput[0] != '('   // check if the indexed value at 0 is not '('
                || phoneNumberInput[4] != ')'   // check if the indexed value at 4 is not ')'
                || phoneNumberInput[5] != ' '   // check if the indexed value at 5 is not whitespace
                || phoneNumberInput[9] != '-')  // check if the indexed value at 9 is not '-'
            {
                isValidFormat = false;
            }
            else
            {
                // loops through the input and runs validation checks on the length of the string and the indexed values
                for (int i = 0; i < phoneNumberInput.Length; i++)
                {
                    // initialise a variable to access the value of i
                    char nextChar = phoneNumberInput[i];



                    // when the indexed position is not any of these spots. then execute the block within
                    if (i != 0 && i != 4 && i != 5 && i != 9)
                    {
                        // check if the value of nextChar is a digit
                        if (!char.IsDigit(nextChar))
                        {
                            // if value is not a digit, break out the loop, no need to check any further
                            isValidFormat = false;
                            break;
                        }
                    }
                }

            }  
            return isValidFormat;
        }

        // 10.
        public static bool PrimeNumberChecker(int isThisPrime)
        {
            // establish that nothing is prime unless we say so
            bool isPrimeNumber = false;

            // this loop will first check if the number is 1 or a negative and will not run if that is the case. 
            for (int i = 2; i < isThisPrime; i++)
            {
                // using modulus operator to check if the number is evenly divisible by the current value of i
                if (isThisPrime % i == 0)
                {
                    // if the number is evenly divisible by any of the numbers between 2 and itself, set isPrimeNumber and return it.
                    isPrimeNumber = false;
                    break;
                }
                else
                {
                    isPrimeNumber = true;
                }
            }
            return isPrimeNumber;
        }

















    }
}
