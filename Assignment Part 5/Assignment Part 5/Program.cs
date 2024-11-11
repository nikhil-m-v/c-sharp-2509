using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Assignment1-Identify the need for single and multidimensional arrays as properties of a class
            //Library library = new Library(3);
            //library.AddBook(0, "The Great Gatsby");
            //library.AddBook(1, "To Kill a Mockingbird");
            //library.AddBook(2, "1984");
            //library.DisplayBooks();

            //// Classroom management
            //Classroom classroom = new Classroom(3, 3);
            //classroom.AssignSeat(0, 0, "Alice");
            //classroom.AssignSeat(1, 1, "Bob");
            //classroom.AssignSeat(2, 2, "Charlie");
            //classroom.DisplaySeatingArrangement();

            ////Assignment2-Identify the need for an array of objects 
            //MovieLibrary library = new MovieLibrary(2);
            //library[0] = new Movie("Movie 1", 2023);
            //library[1] = new Movie("Movie 2", 2024);

            //library.DisplayMovies();

            ////Assignment3-Identify the need for enumerations 
            //Order order1 = new Order(1, OrderStatus.Pending);
            //Order order2 = new Order(2, OrderStatus.Shipped);
            //Order order3 = new Order(3, OrderStatus.Delivered);
            //order1.DisplayOrderInfo();
            //order2.DisplayOrderInfo();
            //order3.DisplayOrderInfo();

            ////Assignment4-Identify the need for value types and reference types 
            //Circle circle1 = new Circle(5.0);
            //Circle circle2 = circle1; // Copy by value

            //Console.WriteLine("Original Circle1:");
            //circle1.DisplayInfo();
            //Console.WriteLine("Copied Circle2:");
            //circle2.DisplayInfo();

            //// Changing Radius of circle2
            //circle2.Radius = 10.0;
            //Console.WriteLine("\nAfter modifying Circle2 Radius:");

            //Console.WriteLine("Circle1:");
            //circle1.DisplayInfo();
            //Console.WriteLine("Circle2:");
            //circle2.DisplayInfo();

            ////Shape class (reference type)
            //Shape shape1 = new Shape("Square");
            //Shape shape2 = shape1; // Copy by reference

            //Console.WriteLine("\nOriginal Shape1:");
            //shape1.DisplayInfo();
            //Console.WriteLine("Referenced Shape2:");
            //shape2.DisplayInfo();

            //// Changing ShapeName of shape2
            //shape2.ShapeName = "Rectangle";
            //Console.WriteLine("\nAfter modifying Shape2 ShapeName:");

            //Console.WriteLine("Shape1:");
            //shape1.DisplayInfo();
            //Console.WriteLine("Shape2:");
            //shape2.DisplayInfo();

            ////Assignment5-Identify the need for pass by reference using ref keyword 
            //int playerScore = 50;
            //Console.WriteLine($"Initial Player Score: {playerScore}");
            //ScoreManager scoreManager = new ScoreManager();
            //scoreManager.IncreaseScore(ref playerScore);
            //Console.WriteLine($"Player Score after calling IncreaseScore: {playerScore}");

            ////Assignment6-Identify the need for out parameters 
            //int num = 20;
            //int den = 3;
            //int resultQuotient;
            //int resultRemainder;

            //MathOps mathOps = new MathOps();
            //mathOps.Divide(num, den, out resultQuotient, out resultRemainder);

            //Console.WriteLine($"Numerator: {num}, Denominator: {den}");
            //Console.WriteLine($"Quotient: {resultQuotient}, Remainder: {resultRemainder}");

            ////Assignment7-What is Exception and its Types 
            //string filePath = "missingfile.txt";

            //try
            //{
            //    // Trying to read a file that does not exist
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine("File content: " + content);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //int[] numbers = { 1, 2, 3 }; // An array with 3 elements

            //try
            //{
            //    //access an index that does not exist
            //    Console.WriteLine("Accessing index 5: " + numbers[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            ////Assignment8-How to Handle Exception 
            //InputHandler inputHandler = new InputHandler();
            //int userInput = inputHandler.GetUserInput();
            //Console.WriteLine($"You entered a valid integer: {userInput}");

            ////Assignment9-Multiple Catch Blocks 
            //try
            //{
            //    Console.Write("Enter the first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = Calculator.Divide(num1, num2);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Invalid input. Please enter integers only.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Unexpected error: {ex.Message}");
            //}

            ////Assignment10--Finally Block
            //string filePath = @"C:\Users\nikhi\source\repos\Assignment Part 5\Assignment Part 5\myfile.txt";

            //try
            //{
            //    string content = FileHandler.ReadFile(filePath);
            //    Console.WriteLine("File Content:\n" + content);
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Error: File not found.");
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("Error: Access to the file is denied.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Unexpected error: {ex.Message}");
            //}

            ////Assignment11--Difference between throw and throws 
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //try
            //{
            //    AgeValidator.ValidateAge(age);
            //    Console.WriteLine("Access granted.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            ////Assignment12--Custom Exception 
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //try
            //{
            //    NumberValidator.CheckNumber(number);
            //    Console.WriteLine("The number is valid");
            //}
            //catch (NegativeNumberException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Unexpected error: {ex.Message}");
            //}

            //Assignment13--Logging Exceptions 

            LoggingExample.Divide(10, 0);

            //Assignment15

            //a
            FileProcessor file1 = new FileProcessor();
            file1.ReadFileContent("C:\\Users\\nikhi\\source\\repos\\Assignment Part 5\\Assignment Part 5\\myfile.txt");

            //b. Math Operation with Exception Handling
            try
            {
                MathOpss mathOps = new MathOpss();
                int result = mathOps.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //c.

            try
            {
                Person person = new Person();
                Console.Write("Enter age: ");
                int inputAge = int.Parse(Console.ReadLine());
                person.SetAge(inputAge);
                Console.WriteLine($"Age set to: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
