using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;


namespace ProgrammingChallengesLibrary
{
    public static class ProgrammingChallenges
    {

        // 0.1 example hook-up
        public static string HelloWorld(string name)
        {
            return $"Hello, {name}";
        }
        public static string WillFail()
        {
            throw new InvalidOperationException("pretending this a normal method, but something went wrong");
        }

        // 1. Biggest / Smallest
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

        // 2. Hacker Speak
        public static string HackerSpeak(string input)
        {
            // declare an empty string so we have something to build into
            string result = "";

            // we nest our main code in a if statement to validate input not being null
            if (input != null)
            {
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
            }
            return result;
        }

        // 3. Letter Counter
        public static int LetterCounter(string input)
        {
            // create a variable for the running total
            int letterTotal = 0;

            // we nest our main code in a if statement to validate input not being null
            if (input != null)
            {
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
            }
            return letterTotal;
        }

        // 4. FizzBuzz
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

        // 5. Get File Name

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

        // 6. Imposter Formula
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

        // 7. Mean Calculator
        public static decimal CalculateTheMean(int[] listOfNumbers)
        {
            // Mean Calculation - add the values together and divide by the total number of values

            // declaring as decimal so we can get an accurate sum after equation
            decimal totalNumbersInList = listOfNumbers.Length;
            decimal sumOfNumbers = 0.00m;
            decimal result = 0.00m;

            if (totalNumbersInList > 0)
            {
                // get the array and start adding the values together
                for (int i = 0; i < listOfNumbers.Length; i++)
                {
                    sumOfNumbers += listOfNumbers[i];
                }

                // perform mean calculation
                decimal meanCalculation = sumOfNumbers / totalNumbersInList;

                // output result to 2 decimal places
                result = Math.Round(meanCalculation, 2);
            }
            return result;
        }

        // 8. Pin Code Validation
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

        // 9. Phone Number Validation
        public static bool FormatValidation(string phoneNumberInput)
        {
            // correct format example = (123) 456-7890

            // create variable to handle valid or invalid phone number entry
            bool isValidFormat = true;

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
                        else
                        {
                            // valid execution path - no code to run
                        }
                    }
                }

            }
            return isValidFormat;
        }
        // 10. Prime Number Checker
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

        // 11. POKER Hand Ranking

        public static string PokerHandRanking(string[] pokerHandInput)
        {
            // -create the ten combinations-
            //        Royal Flush       | A, K, Q, J, 10, all with the same suit.
            //        Straight Flush    | Five cards in sequence, all with the same suit.
            //        Four of a Kind    | Four cards of the same rank.
            //        Full House        | Three of a Kind with a Pair.
            //        Flush             | Any five cards of the same suit, not in sequence.
            //        Straight          | Five cards in a sequence, but not of the same suit.
            //        Three of a Kind   | Three cards of the same rank.
            //        Two Pair          | Two different Pair.
            //        Pair              | Two cards of the same rank.
            //        High Card         | No other valid combination.

            string royalFlush = "Royal Flush";
            string straightFlush = "Straight Flush";
            string fourOfAKind = "Four of a Kind";
            string fullHouse = "Full House";
            string flush = "Flush";
            string straight = "Straight";
            string threeOfAKind = "Three of a Kind";
            string twoPair = "Two Pair";
            string pair = "Pair";
            string highCard = "High Card";

            // get a random hand of 5 cards from the deck
            // the input from main is: string[] pokerHandInput = { "10h", "Jh", "Qh", "Ah", "Kh" };
            string pokerHandResult = "";

            // declare cardNumber variables for value and suit to be used after we have looped through the hand
            int cardOneValue = 0;
            int cardTwoValue = 0;
            int cardThreeValue = 0;
            int cardFourValue = 0;
            int cardFiveValue = 0;

            string cardOneSuit = "";
            string cardTwoSuit = "";
            string cardThreeSuit = "";
            string cardFourSuit = "";
            string cardFiveSuit = "";



            // get each card from the hand
            for (int card = 0; card < pokerHandInput.Length; card++)
            {
                // assigns a variable so we can use the next card in our logic
                string nextCard = pokerHandInput[card];

                // assigns the last value of the nextCard string to a "suit" 
                string suitName = nextCard.Last().ToString();

                // create and empty string to build a cardValue 
                string cardValue = "";
                int cardValueToInt;

                // cards have either 2 or 3 elements
                // if the length of nextCard is exactly 3, assign card value to first and second elements
                if (nextCard.Length == 3)
                {
                    cardValue = $"{nextCard[0]}{nextCard[1]}";
                }
                // otherwise the length will be 2 so just assign the first element
                else
                {
                    cardValue = nextCard.First().ToString();
                }

                // Conversion to int so we can compare the value later
                if (cardValue == "J")
                {
                    cardValueToInt = 11;
                }
                else if (cardValue == "Q")
                {
                    cardValueToInt = 12;
                }
                else if (cardValue == "K")
                {
                    cardValueToInt = 13;
                }
                else if (cardValue == "A")
                {
                    cardValueToInt = 14;
                }
                else
                {
                    bool success = int.TryParse(cardValue, out cardValueToInt);
                }

                // run through the switch to assign the cardValue and suit to a cardNumber
                switch (card)
                {
                    case 0:
                        cardOneValue = cardValueToInt;
                        cardOneSuit = suitName;
                        break;
                    case 1:
                        cardTwoValue = cardValueToInt;
                        cardTwoSuit = suitName;
                        break;
                    case 2:
                        cardThreeValue = cardValueToInt;
                        cardThreeSuit = suitName;
                        break;
                    case 3:
                        cardFourValue = cardValueToInt;
                        cardFourSuit = suitName;
                        break;
                    case 4:
                        cardFiveValue = cardValueToInt;
                        cardFiveSuit = suitName;
                        break;
                    default:
                        break;
                }
            }

            // create a new array for our combination checks
            // starting by putting the cards in order from smallest to biggest
            int[] pokerHandValues = { cardOneValue, cardTwoValue, cardThreeValue, cardFourValue, cardFiveValue };
            Array.Sort(pokerHandValues);

            // declare a negative bool for isInSequence then check if the cardValues are in a sequence
            bool isInSequence = false;

            if (pokerHandValues[1] == pokerHandValues[0] + 1 &&
                pokerHandValues[2] == pokerHandValues[1] + 1 &&
                pokerHandValues[3] == pokerHandValues[2] + 1 &&
                pokerHandValues[4] == pokerHandValues[3] + 1)
            {
                isInSequence = true;
            }

            // first check
            // have they have all got the same suit
            bool isAllSameSuit = (cardOneSuit == cardTwoSuit && cardThreeSuit == cardFourSuit && cardFiveSuit == cardOneSuit);

            if (isAllSameSuit)
            {
                // Then if they are all in sequence, do this
                if (isInSequence)
                {
                    // check if the fifth card is an ace
                    if (pokerHandValues[4] == 14)
                    {
                        pokerHandResult = royalFlush;
                    }
                    // if not then its a straight flush
                    else
                    {
                        pokerHandResult = straightFlush;
                    }
                }
                // if same suit but not in sequence = flush
                else
                {
                    pokerHandResult = flush;
                }
            }
            // if they are not all the same suit check through these
            else if (!isAllSameSuit)
            {
                // check for 4 of a kind and (3 of a kind(in the middle indexes only))
                // declare an anchor variable, to use as the stepping off point for the next checks
                bool matchingMiddle = false;

                // check if the 3 middle numbers match, because the array is sorted lowest to highest,
                // a low or high non matching number will be sorted to either end of the array

                // because the array is sorted, the only way for the values at index 1 and 3 to be the same is if 2 is also the same.
                if (pokerHandValues[1] == pokerHandValues[3])
                {
                    matchingMiddle = true;

                    // then check if the index 0 and 3 match as they are the furthest apart without including the index at the opposite end and vice versa
                    if (pokerHandValues[0] == pokerHandValues[3] || pokerHandValues[1] == pokerHandValues[4])
                    {
                        // 4 matching values = four of a kind
                        pokerHandResult = fourOfAKind;
                    }
                    else
                    {
                        // 3 of one kind and no other pair = three of a kind
                        pokerHandResult = threeOfAKind;
                    }
                }
                // if the 3 cards in the middle dont match then we need to look for a full house
                else if (!matchingMiddle)
                {
                    // check if there is a match on the first 3 or last 3 indexes
                    if (pokerHandValues[0] == pokerHandValues[2] || pokerHandValues[2] == pokerHandValues[4])
                    {
                        // check if there is a pair on the remaining cards, we have this as an and because if there is a 3 of a kind present, then the opposite indexes will also match
                        if (pokerHandValues[0] == pokerHandValues[1] && pokerHandValues[3] == pokerHandValues[4])
                        {
                            // 3 of one kind and 1 pair = full house
                            pokerHandResult = fullHouse;
                        }
                        else
                        {
                            // 3 of one kind and no other pair = three of a kind
                            pokerHandResult = threeOfAKind;
                        }
                    }

                    // next we check for a straight, we already know they are not all the same suit.
                    if (isInSequence)
                    {
                        // are all values in sequence? if yes = straight
                        pokerHandResult = straight;
                    }

                    // next we need to check for 2 pairs
                    // first we can check if there is a pair at the beginning and end of the array
                    if (pokerHandValues[0] == pokerHandValues[1] && pokerHandValues[3] == pokerHandValues[4] ||
                        pokerHandValues[1] == pokerHandValues[2] && pokerHandValues[3] == pokerHandValues[4] ||
                        pokerHandValues[0] == pokerHandValues[1] && pokerHandValues[2] == pokerHandValues[3])
                    {
                        // 2 pairs of different kinds = two pair
                        pokerHandResult = twoPair;
                    }
                    // final check is for a pair
                    else if (pokerHandValues[0] == pokerHandValues[1] ||
                             pokerHandValues[1] == pokerHandValues[2] ||
                             pokerHandValues[2] == pokerHandValues[3] ||
                             pokerHandValues[3] == pokerHandValues[4])
                    {
                        // one pair and no other matches = pair
                        pokerHandResult = pair;
                    }
                    // All else fails. assign high card
                    else
                    {
                        pokerHandResult = highCard;
                    }
                }              
            }
            // return the highest combination
            return pokerHandResult;
        }




















    }
}
