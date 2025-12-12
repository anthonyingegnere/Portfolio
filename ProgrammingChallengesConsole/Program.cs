using ProgrammingChallengesLibrary;
using System.Text;

// 0. example hook-up
string output = ProgrammingChallenges.HelloWorld("Ant");
Console.WriteLine(output);

// 1. 
int[] numbers = { 3, 5, 1, 8, 2 };
int[] result = ProgrammingChallenges.FindSmallestAndBiggestNumbers(numbers);
Console.WriteLine($"Smallest: {result[0]}, Biggest: {result[1]}");

// 2.
string hackerOutput = ProgrammingChallenges.HackerSpeak("Hello, thiS is Another Example.");
Console.WriteLine(hackerOutput);

// 3.
int letterTotal = ProgrammingChallenges.LetterCounter("My Friend Dwayne got distracted on defense and forced a fumble in the playoff game.");
Console.WriteLine($"there are {letterTotal.ToString()} letter D's in this sentence.");

// 4.
int[] fizzBuzzNumbers = { 3, 5, 15, 4, 30, 7, 9, 1 };
string[] fizzBuzzResults = ProgrammingChallenges.FizzBuzz(fizzBuzzNumbers);
foreach (string fizzBuzzResult in fizzBuzzResults)
{
    Console.WriteLine(fizzBuzzResult);
}

// 5.
string fileNameOutput = ProgrammingChallenges.GetFileName("C:/Projects/pil_tests/ascii/edabit.txt");
Console.WriteLine(fileNameOutput);

fileNameOutput = ProgrammingChallenges.GetFileName();
Console.WriteLine(fileNameOutput);

// 6.
int[] gameOne = { 1, 10 };
decimal imposterPercentageChance = ProgrammingChallenges.AmongUsImposterFormula(gameOne);
Console.WriteLine($"you have a {imposterPercentageChance:P0} chance of being the imposter.");

int[] gameTwo = { 2, 5 };
imposterPercentageChance = ProgrammingChallenges.AmongUsImposterFormula(gameTwo);
Console.WriteLine($"you have a {imposterPercentageChance:P0} chance of being the imposter.");

int[] gameThree = { 1, 8 };
imposterPercentageChance = ProgrammingChallenges.AmongUsImposterFormula(gameThree);
Console.WriteLine($"you have a {imposterPercentageChance:P0} chance of being the imposter.");

// 7.
int[] numberList = { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
decimal meanResult = ProgrammingChallenges.CalculateTheMean(numberList);
Console.WriteLine(meanResult);

numberList = new int[] { 2, 3, 2, 3 };
meanResult = ProgrammingChallenges.CalculateTheMean(numberList);
Console.WriteLine($"{meanResult:F2}");

numberList = new int[] { 3, 3, 3, 3, 3 };
meanResult = ProgrammingChallenges.CalculateTheMean(numberList);
Console.WriteLine($"{meanResult:F2}");

// 8.
string pinEntry = "1234";
bool atmOutput = ProgrammingChallenges.PinCodeValidation(pinEntry);
Console.WriteLine(atmOutput);

// 9.
string phoneNumberEntry = "(123) 456-7890";
bool isFormatVaild = ProgrammingChallenges.FormatValidation(phoneNumberEntry);
Console.WriteLine(isFormatVaild);

// 10.
int isThisPrime = -7537;
bool primeCheckerOutput = ProgrammingChallenges.PrimeNumberChecker(isThisPrime);
Console.WriteLine(primeCheckerOutput);