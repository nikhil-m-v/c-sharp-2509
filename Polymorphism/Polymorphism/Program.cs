using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Assignment1
            //Circle circle = new Circle();
            //circle.Draw();
            //Rectangle rectangle = new Rectangle();
            //rectangle.Draw();

            ////Assignment2
            //MathOperations ops = new MathOperations();
            //Console.WriteLine($"Result: {ops.Multiply(2, 4)}");
            //Console.WriteLine($"Result: {ops.Multiply(2, 2, 3)}");

            ////Assignment3
            //Car car = new Car();
            //car.Drive();

            ////Assignment4
            //Manager manager = new Manager();
            //Developer developer = new Developer();
            //manager.ShowDetails();
            //developer.ShowDetails();
            //Employee.DisplayEmployees();

            ////Assignment5
            //string[] managerTasks = { "Oversee Project", "Schedule Meetings", "Allocate Resources" };
            //string[] developerTasks = { "Write Code", "Fix Bugs", "Implement Features" };

            //Employeee manager = new Managerr("Alice", managerTasks);
            //Employeee developer = new Developerr("Bob", developerTasks);

            //Employeee[] employees = { manager, developer };

            //foreach (var employee in employees)
            //{
            //    employee.DisplayTasks();
            //    Console.WriteLine();
            //}

            ////Assignment6
            //// Demonstrating Compile-Time Polymorphism (Method Overloading)
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Add(int, int): " + calculator.Add(5, 10));
            //Console.WriteLine("Add(double, double): " + calculator.Add(5.5, 3.2));
            //Console.WriteLine("Add(int, int, int): " + calculator.Add(1, 2, 3));

            //Console.WriteLine();

            //// Demonstrating Runtime Polymorphism (Method Overriding)
            //Animal myAnimal = new Animal();
            //Animal myDog = new Dog();

            //Console.WriteLine("Animal speaks:");
            //myAnimal.Speak();

            //Console.WriteLine("Dog speaks:");
            //myDog.Speak();

            ////Assignemnt7
            //Shapee circle = new Circlee(5);
            //Shapee rectangle = new Rectanglee(10, 5);

            //// Array of shapes demonstrating runtime polymorphism
            //Shapee[] shapes = { circle, rectangle };

            //foreach (var shape in shapes)
            //{
            //    shape.Describe();
            //    Console.WriteLine($"Area: {shape.CalculateArea():F2}");
            //    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
            //    Console.WriteLine();
            //}

            ////Assignment8
            //Cars myCar = new Cars("Tesla Model S");
            //myCar.Move();
            //myCar.Draw();

            //Assignment9{
            // Creating instances of WashingMachine and Refrigerator with specific models
            Appliance washingMachine = new WashingMachine("LG TurboWash");
            Appliance refrigerator = new Refrigerator("Samsung CoolTech");

            // Using polymorphism to call the Operate method
            Appliance[] appliances = { washingMachine, refrigerator };

            foreach (var appliance in appliances)
            {
                Console.WriteLine($"Appliance Model: {appliance.Model}");
                appliance.Operate();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
