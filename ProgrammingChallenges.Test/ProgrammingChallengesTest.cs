using ProgrammingChallengesLibrary;
using System.Xml.Linq;
using Xunit;
using Challenges = ProgrammingChallengesLibrary.ProgrammingChallenges;
namespace ProgrammingChallenges.Test
{
    public class ProgrammingChallengesTest
    {
        // test one is covered in example file, consider moving here once testing complete.

        // 1. Biggest / Smallest

        [Fact]
        public void ProgrammingChallenges_FindSmallestAndBiggestNumbers_ManyDifferentSizedNumbers_Success()
        {
            // Arrange 
            int[] numbers = { 3, 5, 6, 28, 9, 17, 8, 200, 50, 88, 2 };
            int[] expected = { 2, 200 };

            // Act 
            int[] actual = Challenges.FindSmallestAndBiggestNumbers(numbers);

            // Assert 
            Assert.Equal(expected, actual);
        }

        // ProgrammingChallenges_FindSmallestAndBiggestNumbers_OnlyOneNumber_SuccessSingleNumberReturnedAsBoth
        [Fact]
        public void ProgrammingChallenges_FindSmallestAndBiggestNumbers_OnlyOneNumber_SuccessSingleNumberReturnedAsBoth()
        {
            // Arrange
            int[] numbers = { 3 };
            int[] expected = { 3, 3 };

            // Act
            int[] actual = Challenges.FindSmallestAndBiggestNumbers(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FindSmallestAndBiggestNumbers_HandlesNegativeNumbers_Success()
        {
            // Arrange
            int[] numbers = { 3, 5, 6, 28, 9, -10 };
            int[] expected = { -10, 28 };

            // Act
            int[] actual = Challenges.FindSmallestAndBiggestNumbers(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 2. Hacker Speak
       
        [Fact]
        public void ProgrammingChallenges_HackerSpeak_ManyLowerCaseAndUpperCaseCharacters_Success()
        {
            // Arrange
            string hackerInput = "Hello, thiS is Another Example.";
            string expected = "H3ll0, th15 15 4n0th3r 3x4mpl3.";

            // Act
            string actual = Challenges.HackerSpeak(hackerInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_HackerSpeak_NoUpdateableCharaters_ReturnsSameStringWithSameCase()
        {
            // Arrange
            string hackerInput = "Grumpy Funky Lynx";
            string expected = "Grumpy Funky Lynx";

            // Act
            string actual = Challenges.HackerSpeak(hackerInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_HackerSpeak_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string hackerInput = "";
            string expected = "";

            // Act
            string actual = Challenges.HackerSpeak(hackerInput);

            // Assert
            Assert.Equal(expected, actual);
        }
        // ProgrammingChallenges_HackerSpeak_Null_ReturnsEmptyString  - Bonus: if this doesnt, fix the method to return and empty string
        [Fact]
        public void ProgrammingChallenges_HackerSpeak_Null_ReturnsEmptyString()
        {
            // Arrange
            string hackerInput = null;
            string expected = "";

            // Act
            string actual = Challenges.HackerSpeak(null);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 3. Letter Counter

        [Fact]
        public void ProgrammingChallenges_LetterCounter_NumberOfCharctersCountedWithMixedCase_Success()
        {
            // Arrange
            string counterInput = "My Friend Dwayne got distracted on defense and forced a fumble in the playoff game.";
            int expected = 7;

            // Act
            int actual = Challenges.LetterCounter(counterInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_LetterCounter_EmptyString_ReturnsZero()
        {
            // Arrange
            string counterInput = "";
            int expected = 0;

            // Act
            int actual = Challenges.LetterCounter(counterInput);

            // Assert
            Assert.Equal(expected, actual);
        }
        // ProgrammingChallenges_LetterCounter_Null_ReturnsZero
        [Fact]
        public void ProgrammingChallenges_LetterCounter_Null_ReturnsZero()
        {
            // Arrange
            string counterInput = null;
            int expected = 0;

            // Act
            int actual = Challenges.LetterCounter(counterInput);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 4. FizzBuzz 

        [Fact]
        public void ProgrammingChallenges_FizzBuzz_DivisibleBy3_ReturnsFizz()
        {
            // Arrange
            int[] fizzBuzzInput = { 3 };
            string[] expected = { "Fizz" };

            // Act
            string[] actual = Challenges.FizzBuzz(fizzBuzzInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FizzBuzz_DivisibleBy5_ReturnsBuzz()
        {
            // Arrange
            int[] fizzBuzzInput = { 5 };
            string[] expected = { "Buzz" };

            // Act
            string[] actual = Challenges.FizzBuzz(fizzBuzzInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FizzBuzz_DivisibleBy3And5_ReturnsFizzBuzz()
        {
            // Arrange
            int[] fizzBuzzInput = { 15 };
            string[] expected = { "FizzBuzz" };

            // Act
            string[] actual = Challenges.FizzBuzz(fizzBuzzInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FizzBuzz_NotDivisibleByAny_ReturnsNumber()
        {
            // Arrange
            int[] fizzBuzzInput = { 4 };
            string[] expected = { "4" };

            // Act
            string[] actual = Challenges.FizzBuzz(fizzBuzzInput);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 5. Get File Name

        [Fact]
        public void ProgrammingChallenges_GetFileName_IfASlashPresent_ReturnsFinalPartOfPath()
        {
            // Arrange
            string getFileInput = "C:/Projects/pil_tests/ascii/edabit.txt";
            string expected = "edabit.txt";

            // Act
            string actual = Challenges.GetFileName(getFileInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_GetFileName_IfASlashIsNotPresent_ReturnsInputAsIs()
        {
            // Arrange
            string getFileInput = "edabit.txt";
            string expected = "edabit.txt";

            // Act
            string actual = Challenges.GetFileName(getFileInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_GetFileName_IfNoParameterPassed_SuccessByDefaultParameter()
        {
            // Arrange
            // method has a default parameter of "default/filepath"
            string expected = "filepath";

            // Act
            string actual = Challenges.GetFileName();

            // Assert
            Assert.Equal(expected, actual);
        }


        // 6. Imposter Formula

        [Fact]
        public void ProgrammingChallenges_AmongUsImposterFormula_PreFormatSpecifierEquation_ReturnsDecimal()
        {
            // Arrange
            int[] gameStatsInput = { 1, 10 };
            decimal expected = 0.1m;

            // Act
            decimal actual = Challenges.AmongUsImposterFormula(gameStatsInput);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 7. Mean Calculator 

        [Fact]
        public void ProgrammingChallenges_CalculateTheMean_SumOfArrayCalculation_ReturnsSum()
        {
            // Arrange
            int[] numberListInput = { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
            decimal expected = 2.55m;

            // Act
            decimal actual = Challenges.CalculateTheMean(numberListInput);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ProgrammingChallenges_CalculateTheMean_HandlesEmptyArray_ReturnsZero()
        {
            // Arrange
            int[] numberListInput = Array.Empty<int>();
            decimal expected = 0.00m;

            // Act
            decimal actual = Challenges.CalculateTheMean(numberListInput);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 8. Pin Code Validation
        // Valid pin = "1234"

        [Fact]
        public void ProgrammingChallenges_PinCodeValidation_ValidInput_ReturnsTrue()
        {
            // Arrange
            string pinInput = "1234";
            bool expected = true;

            // Act
            bool actual = Challenges.PinCodeValidation(pinInput);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_PinCodeValidation_InvalidInput_ReturnsFalse()
        {
            // Arrange
            string pinInput = "3421";
            bool expected = false;

            // Act
            bool actual = Challenges.PinCodeValidation(pinInput);

            // Assert
            Assert.Equal(expected, actual);
        }


        // 9. Phone Number Validation 

        [Fact]
        public void ProgrammingChallenges_FormatValidation_ValidNumberWithCorrectFormat_ReturnsTrue()
        {
            // Arrange
            string phoneNumberInput = "(123) 456-7890";
            bool expected = true;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfTheInputIsNot14CharactersLong_ReturnsFalse()
        {
            // Arrange
            string phoneNumberInput = "(123) 456-789";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfTheIndexedValueAt0IsNot()
        {
            // Arrange
            string phoneNumberInput = "5123) 456-7890";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfTheIndexedValueAt4IsNot()
        {
            // Arrange
            string phoneNumberInput = "(1237 456-7890";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfTheIndexedValueAt5IsNotWhitespace_ReturnsFalse()
        {
            // Arrange
            string phoneNumberInput = "(123)8456-7890";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfTheIndexedValueAt9IsNotHyphen_ReturnsFalse()
        {
            // Arrange
            string phoneNumberInput = "(123) 45697890";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_FormatValidation_CheckIfAnyRemainingCharacterIsNotADigit_ReturnsFalse()
        {
            // Arrange
            string phoneNumberInput = "(1g3) 456-7890";
            bool expected = false;
            // Act
            bool actual = Challenges.FormatValidation(phoneNumberInput);
            // Assert
            Assert.Equal(expected, actual);
        }


        // 10. Prime Number Checker 

        [Fact]
        public void ProgrammingChallenges_PrimeNumberChecker_ValidPrimeNumberPassed_ReturnsTrue()
        {
            // Arrange
            int isThisPrimeInput = 23;
            bool expected = true;
            // Act
            bool actual = Challenges.PrimeNumberChecker(isThisPrimeInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_PrimeNumberChecker_NonPrimeNumberPassed_ReturnsFalse()
        {
            // Arrange
            int isThisPrimeInput = 88;
            bool expected = false;
            // Act
            bool actual = Challenges.PrimeNumberChecker(isThisPrimeInput);
            // Assert
            Assert.Equal(expected, actual);
        }
      
        [Fact]
        public void ProgrammingChallenges_PrimeNumberChecker_NegativeNumberPassed_ReturnsFalse()
        {
            // Arrange
            int isThisPrimeInput = -223;
            bool expected = false;
            // Act
            bool actual = Challenges.PrimeNumberChecker(isThisPrimeInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProgrammingChallenges_PrimeNumberChecker_NumberOnePassed_ReturnsFalse()
        {
            // Arrange
            int isThisPrimeInput = 1;
            bool expected = false;
            // Act
            bool actual = Challenges.PrimeNumberChecker(isThisPrimeInput);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}