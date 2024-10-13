using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1st--mul table
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {number * i}");
            //}
            //Console.ReadLine();
            ////1st

            ////2nd-- right triangle
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            ////2nd

            ////3rd--even sum
            //int sumEven = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumEven = sumEven + i;
            //    }
            //}
            //Console.WriteLine($"Sum = {sumEven}");
            //Console.ReadLine();
            ////3rd

            ////4th -- mul table 1to5
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            ////4th

            ////5th--print positive
            //int num = 0;

            //while (num >= 0)
            //{
            //    Console.Write("Enter number: ");
            //    num = int.Parse(Console.ReadLine());
            //}

            ////5th

            ////6th & 12th-menu calc
            //double firstNumber = 0;
            //double secondNumber = 0;
            //int choice = 0;
            //do
            //{
            //    firstNumber = 0;
            //    secondNumber = 0;
            //    choice = 0;
            //    Console.WriteLine("Enter first number:");
            //    firstNumber = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number");
            //    secondNumber = double.Parse(Console.ReadLine());
            //    Console.WriteLine("--OPERATIONS--");
            //    Console.WriteLine("1.Addition");
            //    Console.WriteLine("2.Subtraction");
            //    Console.WriteLine("3.Division");
            //    Console.WriteLine("4.Multiplication");
            //    Console.WriteLine("5.Exit");
            //    Console.Write("Enter your option: ");

            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"Sum = {firstNumber + secondNumber}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"Difference = {firstNumber - secondNumber}");
            //            break;
            //        case 3:
            //            if (secondNumber == 0)
            //            {
            //                Console.WriteLine("Division not possible");
            //                break;
            //            }
            //            Console.WriteLine($"Quotient = {firstNumber / secondNumber}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"Product = {firstNumber * secondNumber}");
            //            break;
            //    }
            //} while (choice != 5);
            ////6th & 12th

            ////7th -- 1to100 nos
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else if (i > 50)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            ////7th

            ////8th--odd sum
            //int sumOdd = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sumOdd = sumOdd + i;
            //    }
            //}
            //Console.WriteLine($"Sum = {sumOdd}");
            //Console.ReadLine();
            ////8th

            ////9th--factorial
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"Factorial of {number} is {factorial}");
            //Console.ReadLine();
            ////9th

            ////10th-- number pyramid
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            ////10th

            ////11th--random
            //Random rnd = new Random();
            //int randomNumber = rnd.Next(1, 101);
            //Console.Write("Guess a number between 1 and 100: ");
            //int guessNumber = int.Parse(Console.ReadLine());
            //if (guessNumber == randomNumber)
            //{
            //    Console.WriteLine("Correct");
            //}
            //else if (guessNumber > randomNumber)
            //{
            //    Console.WriteLine("Too high");
            //}
            //else if (guessNumber < randomNumber)
            //{
            //    Console.WriteLine("Too low");
            //}
            //Console.WriteLine($"Random number is : {randomNumber}");
            //Console.ReadLine();
            ////11th

            ////13th --sum of digits
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //int remainder = 0;
            //int sum = 0;
            //int temp = number;
            //do
            //{
            //    remainder = number % 10;
            //    sum += remainder;
            //    number /= 10;
            //} while (number >= 1);
            //Console.WriteLine($"Sum of digits of {temp} = {sum}");
            //Console.ReadLine();
            ////13th

            ////14th--largest
            //int[]numbers = new int[10];
            //int i = 0;
            //Console.WriteLine("Enter 10 numbers : ");
            //for (i = 0; i < 10; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int largest;
            //i = 0; 
            //largest = numbers[i];
            //for (i = 0; i < 10; i++)
            //{
            //    if (largest < numbers[i])
            //    {
            //        largest = numbers[i];
            //    }
            //}
            //Console.WriteLine($"Largest number : {largest}");
            //Console.ReadLine();
            ////14th

            ////15th--sum of sqaures
            //Console.WriteLine("Enter number");
            //int squareSum = 0;
            //int temp = 0;
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    temp = i;
            //    temp = temp * temp;
            //    squareSum += temp;
            //}
            //Console.WriteLine($"Sum of squares from 1 to {number} is {squareSum}");
            //Console.ReadLine();
            ////15th

            ////16th--countdown timer
            //int countdown = 10;

            //Console.WriteLine("Countdown Timer:");
            //do
            //{
            //    Console.WriteLine(countdown);
            //    Thread.Sleep(1000);  // Wait for 1 second (1000 milliseconds)
            //    countdown--;
            //}
            //while (countdown > 0);

            //Console.WriteLine("Countdown Complete!");
            ////16th

            ////17th--first multiple of 5
            //Console.WriteLine("Enter 5 numbers:");
            //int[] numbers = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (numbers[i] % 5 == 0)
            //    {
            //    Console.WriteLine($"First multiple of 5 : {numbers[i]}");
            //        break;
            //    }
            //}
            //Console.ReadLine();
            ////17th

            ////18th--non multiples of 3
            //Console.WriteLine("Enter number");
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            ////18th

            ////19th--palindrome
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //int remainder = 0;
            //int sum = 0;
            //int temp = number;
            //do
            //{
            //    remainder = number % 10;
            //    sum = sum*10 + remainder;
            //    number /= 10;
            //} while (number >= 1);
            //if (sum == temp)
            //{
            //    Console.WriteLine($"{temp} is a Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"{temp} is not a Palindrome");
            //}

            //Console.ReadLine();
            ////19th

            ////20th--average
            //Console.WriteLine("Total numbers :");
            //int totalNumber = int.Parse(Console.ReadLine());
            //double[] numbers = new double[totalNumber];
            //Console.WriteLine($"Enter {totalNumber} numbers");
            //for (int i = 0; i < totalNumber; i++)
            //{
            //    numbers[i] = double.Parse(Console.ReadLine());
            //}
            //double sum = 0;
            //double average = 0;

            //for (int i = 0; i < totalNumber; i++)
            //{
            //    sum += numbers[i];
            //}
            //average = sum/ totalNumber;
            //Console.WriteLine($"Average = {average}");
            //Console.ReadLine();
            ////20th

            ////21st--reverse
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //int remainder = 0;
            //int reverse = 0;

            //do
            //{
            //    remainder = number % 10;
            //    reverse = reverse * 10 + remainder;
            //    number /= 10;
            //} while (number >= 1);
            //Console.WriteLine($"Reversed Number : {reverse}");
            //Console.ReadLine();
            ////21st

            ////22nd--string operations
            //Console.WriteLine("Enter string:");
            //string str = Console.ReadLine();
            //int length = str.Length;
            //Console.WriteLine("String operations");
            //Console.WriteLine("1.Reverse");
            //Console.WriteLine("2.Uppercase");
            //Console.WriteLine("3.Lowercase");
            //Console.WriteLine("4.Length");
            //Console.Write("Enter your option: ");
            //int choice = int.Parse(Console.ReadLine());
            //switch (choice)
            //{
            //    case 2:
            //        Console.WriteLine(str.ToUpper());
            //        break;
            //    case 3:
            //        Console.WriteLine(str.ToLower());
            //        break;
            //    case 4:
            //        Console.WriteLine($"Length = {length}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input"); break;
            //}
            //Console.ReadLine();
            ////22nd

            ////23rd--divisibility by 4
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}Console.ReadLine();
            ////23rd

            ////24th--fibonacci
            //Console.WriteLine("Enter number of terms : ");
            //int number = int.Parse(Console.ReadLine()); 
            //int a = 0;
            //int b = 1;
            //int c;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 2; i < number; i++)
            //{

            //    c = a + b;
            //    a = b; b=c;
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine();
            ////24th

            ////25th--armstrong number
            //int number = 1;

            //Console.WriteLine("Armstrong numbers between 1 and 500 are:");
            //while (number <= 500)
            //{
            //    int sum = 0;
            //    int temp = number;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        sum += digit * digit * digit;
            //        temp /= 10;
            //    }

            //    if (sum == number)
            //    {
            //        Console.WriteLine(number);
            //    }

            //    number++;
            //}
            //Console.ReadLine();
            ////25th

            ////26th--conversion
            //while (true)
            //{
            //    Console.WriteLine("\nNumber System Conversion Menu:");
            //    Console.WriteLine("1. Binary to Decimal");
            //    Console.WriteLine("2. Decimal to Binary");
            //    Console.WriteLine("3. Decimal to Hexadecimal");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice (1-4): ");

            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter a binary number: ");
            //            string binaryInput = Console.ReadLine();
            //            try
            //            {
            //                int decimalValue = Convert.ToInt32(binaryInput, 2);
            //                Console.WriteLine($"Binary {binaryInput} in decimal is: {decimalValue}");
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Invalid binary number format.");
            //            }
            //            break;

            //        case 2:
            //            Console.Write("Enter a decimal number: ");
            //            int decimalInput = int.Parse(Console.ReadLine());
            //            string binaryResult = Convert.ToString(decimalInput, 2);
            //            Console.WriteLine($"Decimal {decimalInput} in binary is: {binaryResult}");
            //            break;

            //        case 3:
            //            Console.Write("Enter a decimal number: ");
            //            decimalInput = int.Parse(Console.ReadLine());
            //            string hexResult = Convert.ToString(decimalInput, 16).ToUpper();
            //            Console.WriteLine($"Decimal {decimalInput} in hexadecimal is: {hexResult}");
            //            break;

            //        case 4:
            //            Console.WriteLine("Exiting the program.");
            //            return;

            //        default:
            //            Console.WriteLine("Invalid choice. Please choose between 1 and 4.");
            //            break;
            //    }
            //}
            ////26th

            ////27th--string reversal
            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //string reversed = "";
            //int length = str.Length - 1;
            //for (int i = length; i >= 0; i--)
            //{
            //    reversed = reversed + str[i];
            //}
            //Console.WriteLine(reversed);
            //Console.ReadLine();
            ////27th

            ////28th -vowel count
            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //int length = str.Length - 1;
            //string word = str.ToLower();
            //int vowCount = 0;
            //int conCount = 0;
            //for (int i = 0; i <= length; i++)
            //{
            //    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
            //    {
            //        vowCount++;
            //    }
            //    else { conCount++; }
            //}

            //Console.WriteLine($"Vowels = {vowCount} and Consonants = {conCount}");
            //Console.ReadLine();
            ////28th

            ////29th--largest no
            //int[] numbers = new int[5];
            //Console.WriteLine("Enter 5 numbers : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int largest = numbers[0];
            //for (int i = 0; i < 5; i++)
            //{
            //    if (numbers[i] > largest)
            //    {
            //        largest = numbers[i];
            //    }
            //}
            //Console.WriteLine($"Largest = {largest}");
            //Console.ReadLine();
            ////29th

            ////30--no of digits
            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //int numberOfDigits = 0;


            //while (number >= 1)
            //{
            //    number = number / 10;
            //    numberOfDigits++;
            //}
            //Console.WriteLine($"number of digits = {numberOfDigits}");
            //Console.ReadLine();
            ////30
        }
    }
}
