using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.Win32;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1st
            //Console.WriteLine("Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine($"Hi {name}");
            //Console.ReadLine();
            ////1st

            ////2nd
            //Console.WriteLine("Enter your name:");
            //string name =Console.ReadLine();
            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your favourite color:");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello {name}! You are {age} years old.");
            //Console.WriteLine($"Your favourite color is {color}");
            //Console.ReadLine();
            ////2nd

            ////3rd
            //Console.WriteLine("Enter 1st number:");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number:");
            //double n2 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Sum is {n1 + n2}");
            //Console.WriteLine($"Difference is {n1 - n2}");
            //Console.WriteLine($"Product is {n1 * n2}");
            //if (n2 != 0)
            //{

            //    Console.WriteLine($"Quotient is {n1 / n2}");
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not possible");
            //}
            //Console.ReadLine();
            ////3rd

            ////4th
            //Console.WriteLine("Enter temperature in Celcius");
            //double ctemp = double.Parse(Console.ReadLine());
            //double ftemp = (ctemp * 9 / 5) + 32;
            //Console.WriteLine($"Temperature in Fahrenheit is {ftemp}");
            //Console.ReadLine();
            ////4th

            ////5th
            //Console.WriteLine("Enter Principal");
            //double p = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Rate");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Time");
            //double t = double.Parse(Console.ReadLine());

            //double i = (p * r * t) / 100;
            //Console.WriteLine($"Simple interest {i}");
            //Console.ReadLine();
            ////5th

            ////6th
            //Console.WriteLine("Enter Radius");
            //double r = double.Parse(Console.ReadLine());
            //const double pi = 3.14159;
            //Console.WriteLine($"Area of circle is {pi * r * r}");
            //Console.ReadLine();
            ////6th

            ////7th --time
            //Console.WriteLine("Enter time in seconds:");
            //int second = int.Parse(Console.ReadLine());
            //double minute = (double)second / 60;
            //double hour = minute / 60;
            //Console.WriteLine($"Time in minutes:{minute}\nTime in hours:{hour}");
            //Console.ReadLine();
            ////7th

            ////8th -- string length
            //Console.WriteLine("Enter string");
            //string str = Console.ReadLine();
            //int length = str.Length;
            //int count = 0;
            //for (int i = 0; i <= length - 1; i++)
            //{
            //    if (str[i] != ' ')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Length of string is: {count}");
            //Console.ReadLine();
            ////8th

            ////9th -- bmi
            //Console.WriteLine("Enter height:");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter weight:");
            //double weight = double.Parse(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine($"BMI : {bmi}");
            //Console.ReadLine();
            ////9th

            ////10th
            //int myInt = 25;
            //float myFloat = 5.75F;
            //double myDouble = 19.99;
            //char myChar = 'A';
            //string myString = "Hello, World!";
            //bool myBool = true;
            //Console.WriteLine($"Integer:  {myInt}  - Type:   {myInt.GetType()}");
            //Console.WriteLine($"Float:   {myFloat}  - Type:   {myFloat.GetType()}");
            //Console.WriteLine($"Double :   {myDouble}  - Type:   {myDouble.GetType()}");
            //Console.WriteLine($"Character :   {myChar}   - Type:   {myChar.GetType()}");
            //Console.WriteLine($"String :   {myString}   - Type:  {myString.GetType()}");
            //Console.WriteLine($"Boolean : {myBool} - Type:   {myBool.GetType()}");
            //Console.ReadLine();
            ////10th

            ////11th --variables and constants
            //Console.WriteLine("Enter radius of circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter length of rectangle");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter breadth of rectangle");
            //double breadth = double.Parse(Console.ReadLine());
            //const double PI = 3.14159;
            //Console.WriteLine($"Area of Circle: {PI * radius * radius}");
            //Console.WriteLine($"Area of Rectangle: {length * breadth}");
            //Console.ReadLine();
            ////11th

            ////12th -- using const
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //Console.WriteLine("Enter radius of circle: ");
            //double radius = double.Parse(Console.ReadLine());
            //double circumference = 2 * PI * radius;
            //Console.WriteLine($"Circumference of circle: {circumference}");
            //Console.WriteLine($"There are {DAYS_IN_WEEK} days in a week");
            //Console.ReadLine();
            ////12th

            ////13th
            //Console.WriteLine("Enter length of rectangle in cm");
            //double cmLength = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter breadth of rectangle in cm");
            //double cmBreadth = double.Parse(Console.ReadLine());
            //const double CM_TO_INCH = 1 / 2.5;
            //double inLength = cmLength * CM_TO_INCH;
            //double inBreadth = cmBreadth * CM_TO_INCH;
            //Console.WriteLine($"Area of Rectangle in sq cm: {cmLength * cmBreadth}");
            //Console.WriteLine($"Area of Rectangle in sq inch: {inLength * inBreadth}");
            //Console.ReadLine();
            ////13th

            ////14th -- coding standards
            //Console.WriteLine("Enter Name:");
            //string employeeName = Console.ReadLine();
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter salary:");
            //int monthlySalary = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Employee name : {employeeName}, age : {age} , monthly salary: {monthlySalary}");
            //Console.ReadLine();
            ////14th

            ////15th --coding standards
            //int firstNumber = 5;
            //int secondNumber = 3;
            //int sum = firstNumber + secondNumber;
            //Console.WriteLine($"Sum is {sum}");
            //Console.ReadLine();
            ////15th

            ////17th --Find the Power of a Number 
            //Console.WriteLine("Enter base:");
            //double baseValue = double.Parse( Console.ReadLine() );
            //Console.WriteLine("Enter exponent:");
            //double exponentValue = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Power is : {Math.Pow(baseValue,exponentValue)}");
            //Console.ReadLine();
            ////17th

            ////18th --vote
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Citizenship:");
            //string citizenship = Console.ReadLine();
            //if (citizenship.ToLower() == "indian" && age >= 18)
            //{
            //    Console.WriteLine("Eligible to vote");
            //}
            //else {
            //    Console.WriteLine("Not eligible to vote");
            //}
            //Console.ReadLine() ;
            ////18th

            ////19th -- loan
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter salary:");
            //int salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Any outstanding loan? (yes/no)");
            //string loan = Console.ReadLine();
            //if (loan.ToLower() == "no" && age >= 18 && salary>=30000)
            //{
            //    Console.WriteLine("Eligible for loan");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible for loan");
            //}
            //Console.ReadLine();
            ////19th

            ////20th--job eligibility
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter work experience in years:");
            //int workExperience = int.Parse(Console.ReadLine());
            //Console.WriteLine("Has college degree? (yes/no)");
            //string degree = Console.ReadLine();
            //if (degree.ToLower() == "yes" && age >= 18 && age <= 35 && workExperience >= 2)
            //{
            //    Console.WriteLine("Eligible for job");
            //}
            //else if (degree.ToLower() == "no" && age >= 18 && age <= 35 && workExperience >= 5)
            //{
            //    Console.WriteLine("Eligible for job");
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible for job");
            //}
            //Console.ReadLine();

            ////20th

            ////21st--vowel
            //Console.WriteLine("Enter character:");
            //string ch = Console.ReadLine();
            //string letter = ch.ToLower();
            //if(letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            //    {
            //    Console.WriteLine("Character is a vowel");
            //    }
            //else
            //{
            //    Console.WriteLine("Character is a consonant");
            //}
            //Console.ReadLine();
            ////21st

            ////22nd--pos,neg,zero
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Number is positive");
            //}
            //else if(number < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else { Console.WriteLine("Number is zero"); }
            //Console.ReadLine();
            ////22nd

            ////23rd--divisibilty by 5,11
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 5 == 0 && number % 11 == 0)
            //{ 
            //    Console.WriteLine($"{number} is divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is NOT divisible by 5 and 11");
            //}
            //Console.ReadLine();
            ////23rd

            ////24th--Simple Calculator 
            //Console.WriteLine("enter two numbers :");
            //double num1 = Double.Parse(Console.ReadLine());
            //double num2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("enter 1. for addition 2. for subtraction 3.for multiplication 4.for division");
            //int op = Convert.ToInt32(Console.ReadLine());

            //switch (op)
            //{
            //    case 1:
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case 4:
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine($"{num1} / {num2} = {num1}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"no answer");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Please enter valid number for operation");
            //        break;
            //}
            //Console.ReadLine();

            ////24th

            ////25th--grading
            //Console.WriteLine("enter the marks out of 100 :");
            //double marks = Double.Parse(Console.ReadLine());
            //if (marks >= 90)
            //{
            //    Console.WriteLine("the grade is A");
            //}
            //else if (marks >= 80 && marks <= 89)
            //{
            //    Console.WriteLine(" the grade is B");
            //}
            //else if (marks >= 70 && marks <= 79)
            //{
            //    Console.WriteLine("the grade is C");
            //}
            //else if (marks >= 60 && marks <= 69)
            //{
            //    Console.WriteLine("the grade is D");
            //}
            //else if (marks < 60)
            //{
            //    Console.WriteLine("the grade is F");
            //}
            //Console.ReadLine();
            ////25th

            ////26th-Swap two values
            //Console.WriteLine("Swap using 3rd variable");
            //Console.WriteLine("enter the number a :");
            //double a = Double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the number b :");
            //double b = Double.Parse(Console.ReadLine());

            //double temp = 0;
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine($"the number a = {a}");
            //Console.WriteLine($"the number b ={b}");

            //Console.WriteLine("\nSwap without using 3rd variable");
            //Console.WriteLine("enter the number a :");
            //double x = Double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the number b :");
            //double y = Double.Parse(Console.ReadLine());

            //double sum = x + y;
            //x = sum - x; y = sum - y;
            //Console.WriteLine($"the number a = {x}");
            //Console.WriteLine($"the number b ={y}");
            //Console.ReadLine();
            ////26th

            ////27th--arithmetic operations
            //Console.WriteLine("enter number a :");
            //double a = Double.Parse(Console.ReadLine());
            //Console.WriteLine("enter number b :");
            //double b = Double.Parse(Console.ReadLine());

            //Console.WriteLine($"addition = {a} + {b} = {a + b}");
            //Console.WriteLine($"subtraction = {a} - {b} = {a - b}");
            //Console.WriteLine($"multiplication = {a} * {b} = {a * b}");

            //Console.WriteLine($"modulus = {a} % {b} = {a % b}");
            //Console.WriteLine($"increment of {a} = {a + 1} and increment of {b} = {b + 1}");
            //Console.WriteLine($"decrement of {a} ={a - 1} and decrement of {b} = {b - 1}");

            //if (b != 0)
            //{
            //    Console.WriteLine($"division = {a} / {b} = {a / b}");

            //}
            //else
            //{
            //    Console.WriteLine("division not possible");
            //}
            //Console.ReadLine();
            ////27th

            ////28th--average of three nos
            //Console.WriteLine("Enter three numbers :");
            //double firstNumber = double.Parse(Console.ReadLine());
            //double secondNumber = double.Parse(Console.ReadLine());
            //double thirdNumber = double.Parse(Console.ReadLine());
            //double average = (firstNumber+secondNumber+thirdNumber)/3;
            //Console.WriteLine($"Average is {average}");
            //Console.ReadLine();

            ////28th

            ////29th--currency conversion
            //Console.WriteLine("Enter amount in USD:");
            //double usd = double.Parse(Console.ReadLine());
            //double convsersionFactor = 0.85;
            //double eur = usd * convsersionFactor;
            //Console.WriteLine($"Amount in EUR: {eur}");
            //Console.ReadLine();
            ////29th

            ////30th-- Input is within a range
            //Console.WriteLine("Enter number :");
            //int number = int.Parse(Console.ReadLine());
            //int flag = 0;
            //if (number>=1 && number <= 100) 
            //{
            //flag = 1;
            //}
            //int x = number % 2;
            //if (flag == 0)
            //{
            //    Console.WriteLine("Number does not meet conditions");
            //}
            //else
            //{
            //    if (x == 1) { Console.WriteLine("Number meets the conditions and is odd"); }
            //    else { Console.WriteLine("Number meets the conditions and is even"); }
            //}
            //Console.ReadLine();
            ////30th

            ////31st--divisibilty by 3 and 5
            //Console.WriteLine("enter the number");
            //double num = Double.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("divisible by both 3 and 5");
            //}
            //else
            //{
            //    Console.WriteLine("not divisible by both 3 and 5");
            //}
            //Console.ReadLine();
            ////31st

            ////32nd
            //Console.WriteLine("enter the year:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (y % 4 == 0)
            //{
            //    if (y % 100 == 0)
            //    {
            //        if (y % 400 == 0)
            //        {
            //            Console.WriteLine("it is a leap year");
            //        }
            //        else
            //        {
            //            Console.WriteLine("it is not a leap year");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("it is a leap year");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" it is not a leap year");
            //}
            //Console.ReadLine();
            ////32nd

            ////33rd--Check whether a number is positive, even and greater than 50
            //Console.WriteLine("Enter number :");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    if (number % 2 == 0)
            //    {
            //        if (number > 50)
            //        {
            //            Console.WriteLine($"{number} is positive, even and greater than 50");
            //        }
            //        else 
            //        {
            //            Console.WriteLine($"{number} does NOT meet all conditions");
            //        }
            //    }
            //}
            //Console.ReadLine();
            ////33rd

            ////34th--Calculate student grade 
            //Console.WriteLine("enter marks of sub1 out of 100");
            //double m1 = Double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the marks of sub2 out of 100");
            //double m2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("enter the markds of sub3 out of 100");
            //double m3 = Double.Parse(Console.ReadLine());
            //int count = 0;

            //if (m1 >= 40 && m2 >= 40 && m3 >= 40)
            //{
            //    double av = (m1 + m2 + m3) / 3;
            //    Console.Write("the student had passed all the subjects");
            //    if (av > 70)
            //    {
            //        Console.Write($" with distiction");
            //    }
            //}
            //else
            //{
            //    if (m1 < 40)
            //    {
            //        count++;
            //    }
            //    if (m2 < 40)
            //    { count++; }
            //    if (m3 < 40)
            //    { count++; }

            //    Console.WriteLine($"the number of subjects failed is {count}");
            //}
            //Console.ReadLine();
            ////34th

            ////35th--Salary and Tax Calculation 
            //Console.WriteLine("Enter salary ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter age ");
            //int age = int.Parse(Console.ReadLine());

            //double tax = 0;

            //if (salary < 10000)
            //{
            //    tax = 0;
            //    Console.WriteLine("Tax not applicable");
            //}
            //else if(salary > 10000 && salary < 50000)
            //{
            //    tax = salary * 0.1;
            //}
            //else if (salary > 50000)
            //{
            //    tax = salary * 0.2;
            //}


            //if (tax < 5000 && age >= 60)
            //{
            //    Console.WriteLine("Tax not applicable");
            //}
            //else if (tax >= 5000 && age >= 60)
            //{
            //    Console.WriteLine($"Tax after reduction is {tax - 5000}");
            //}
            //else if (tax > 10000 && age < 60)
            //{
            //    Console.WriteLine($"Tax is {tax}");
            //}
            //Console.ReadLine();
            ////35th
        }
    }
}
