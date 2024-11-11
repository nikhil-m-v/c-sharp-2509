using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Assignment1-Abstract Class 
            //Car car = new Car();
            //car.StartEngine();
            //car.StopEngine();

            //Motorcycle motorcycle = new Motorcycle();
            //motorcycle.StartEngine();
            //motorcycle.StopEngine();

            ////Assignment2-Virtual Functions 
            //Cat cat = new Cat();
            //cat.MakeSound();
            //Dog dog = new Dog();
            //dog.MakeSound();

            ////Assignment3-Interface 
            //Cars cars = new Cars();
            //cars.Drive();
            //Truck truck = new Truck();
            //truck.Drive();

            ////Assignment4-Interface vs. Abstract Class 
            //Duck duck = new Duck();
            //duck.Fly();
            //duck.Swim();

            ////Assignment5-Static Class
            //MathOperation.Multiply(2, 3);
            //MathOperation.Add(8, 6);

            ////Assignment6-Extension Methods 
            //int num = 4;
            //Console.WriteLine(num.IsEven());
            //num = 5;
            //Console.WriteLine(num.IsEven());

            ////Assignement7-Partial class
            //Person person = new Person();
            //person.Name = "Alice";
            //person.ShowDetails();

            ////Assignment8-Partial method 
            //Employee employee = new Employee
            //{
            //    Name = "John Doe",
            //    HoursWorked = 40,
            //    HourlyRate = 20
            //};
            //employee.DisplaySalary();

            //Assignment9
            //Library library = new Library(3);

            //library[0] = new Book("1984", "George Orwell");
            //library[1] = new Book("To Kill a Mockingbird", "Harper Lee");
            //library[2] = new Book("The Great Gatsby", "F. Scott Fitzgerald");

            //Console.WriteLine("Books in the Library:");
            //library.DisplayBooks();

            ////Assignement10
            //int result;
            //try
            //{
            //    Console.WriteLine("Enter the numerator: ");
            //    int numerator = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the denominator: ");
            //    int denominator = int.Parse(Console.ReadLine());

            //    result = Calculator.Divide(numerator, denominator);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Please enter valid integers.");
            //}
            //finally
            //{
            //    Console.WriteLine("Division attempt completed.");
            //}

            ////Assignment11
            //Carr myCar = new Carr(CarType.SUV);
            //Console.WriteLine("Car Type: " + myCar.Type);
            //myCar.DisplayCarMessage(myCar.Type);

            //Assignment12
            Type calculatorType = typeof(Calculators);
            var classAttributes = calculatorType.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Developed by: {attr.Name}, Last Modified: {attr.LastModified}\n");
            }

            // Retrieve Method Attribute
            var methodInfo = calculatorType.GetMethod("Add");
            var methodAttributes = methodInfo.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in methodAttributes)
            {
                Console.WriteLine($"Method Developed by: {attr.Name}, Last Modified: {attr.LastModified}");
            }

            Console.ReadLine();
        }
    }
}
