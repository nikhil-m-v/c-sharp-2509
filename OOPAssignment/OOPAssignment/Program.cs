using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPAssignment.Book;

namespace OOPAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Assignment1
            //try
            //{
            //    Circle circle1 = new Circle();
            //    circle1.Radius = 10;
            //    Console.WriteLine(circle1.Radius);
            //    Circle circle2 = new Circle();
            //    circle2.Radius = -10;
            //    Console.WriteLine(circle2.Radius);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////Assignment2
            //try
            //{
            //    Employee emp1 = new Employee();
            //    Employee emp2 = new Employee();
            //    emp1.Salary = 40000;
            //    Console.WriteLine(emp1.Salary);
            //    emp2.Salary = -40000;
            //    Console.WriteLine(emp2.Salary);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////Assignment3
            //Library library = new Library();

            //library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            //library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
            //library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));

            //Console.WriteLine("Books in the library:");
            //library.DisplayBooks();

            //library.RemoveBook("9780451524935");
            //Console.WriteLine("\nAfter removing '1984':");
            //library.DisplayBooks();

            ////Assignment4
            //BankingSystem account1 = new BankingSystem("123456789", "John Doe", 5000);

            //account1.DisplayAccountInfo();

            //account1.Deposit(1000);
            //account1.Withdraw(2000);
            //account1.Withdraw(5000);

            //account1.DisplayAccountInfo();

            ////Assignment5
            //StudentManagementSystem std = new StudentManagementSystem("John", "S001", new List<int> { 85, 90, 78 });
            //std.DisplayStudentInfo();
            //std.AddMark(68);
            //std.AverageMark();

            ////Assignment6
            //Items.Inventory storeInventory = new Items.Inventory();

            //Items item1 = new Items("Laptop", 10, 1000);
            //Items item2 = new Items("Phone", 20, 500);
            //Items item3 = new Items("Headphones", 50, 150);

            //storeInventory.AddItem(item1);
            //storeInventory.AddItem(item2);
            //storeInventory.AddItem(item3);

            //storeInventory.DisplayInventory();

            //storeInventory.UpdateItem(item1, 8, 900);

            //storeInventory.RemoveItem(item2);

            //Console.WriteLine("\nAfter removing Phone:");
            //storeInventory.DisplayInventory();

            ////Assignment7
            //Products product1 = new Products("Laptop", 10, 1000);
            //Products product2 = new Products("Phone", 5, 500);

            //Console.WriteLine(product1);
            //Console.WriteLine(product2);

            //product1.PlaceOrder(2);
            //product2.PlaceOrder(6);
            //product2.PlaceOrder(3);

            //Console.WriteLine(product1);
            //Console.WriteLine(product2);

            ////Assignment8
            //Print printer = new Print();

            //printer.PrintData("Hello, World!");
            //printer.PrintData(42);
            //printer.PrintData(new int[] { 1, 2, 3, 4, 5 });

            ////Assignment9
            //Rectangle rectangle = new Rectangle();
            //rectangle.CalculateArea(5);
            //rectangle.CalculateArea(10, 5);

            ////Assignment10
            //Time time1 = new Time();
            //time1.SetTime(12,15);
            //time1.GetTime();

            //Time time2 = new Time();
            //time2.SetTime(10, 50);
            //time2.GetTime();

            ////Assignment11
            //Bank bank = new Bank(1000);

            ////Assignment12
            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();

            ////Assignment13
            //MathOperations math = new MathOperations();
            //math.getPI();

            ////Assignment14
            //Configuration userConfig = new Configuration("Dark Mode");
            //userConfig.DisplaySettings();

            ////Assignment15
            //Console.WriteLine("Phone1:");
            //Phone phone1 = new Phone("Samsung", "Black", 2024);
            //phone1.DisplayInfo();
            //Console.WriteLine("Phone2:");
            //Phone phone2 = new Phone(phone1);
            //phone2.DisplayInfo();
            //Console.WriteLine("After modifying Phone1:");
            //phone1.Model = "Nothing";
            //phone1.Color = "White";
            //phone1.Year = 2023;
            //Console.WriteLine("Phone1:");
            //phone1.DisplayInfo();
            //Console.WriteLine("Phone2:");
            //phone2.DisplayInfo();

            ////Assignment16
            //Cars car1 = new Cars("Toyota");
            //Cars car2 = new Cars("Honda", "Civic");
            //Cars car3 = new Cars("Ford", "Mustang", 2020);
            //Cars car4 = new Cars("Chevrolet", "Camaro", 2019, 35000);

            //car1.DisplayDetails();
            //car2.DisplayDetails();
            //car3.DisplayDetails();
            //car4.DisplayDetails();

            ////Assignment17
            //Product product1 = new Product("Television");
            //Product product2 = new Product("Laptop", 1500);
            //Product product3 = new Product("Smartphone", 1000, 100);

            //product1.CalculateFinalPrice();
            //product2.CalculateFinalPrice();
            //product3.CalculateFinalPrice();

            ////Assignment18
            //// 1. Constructor Initialization
            //Productss product1 = new Productss("Laptop", 999.99, "Electronics");
            //Console.WriteLine("Constructor Initialization:");
            //Console.WriteLine(product1);

            //// 2. Object Initializer Syntax
            //Productss product2 = new Productss
            //{
            //    Name = "Smartphone",
            //    Price = 699.99,
            //    Category = "Electronics"
            //};
            //Console.WriteLine("\nObject Initializer Syntax:");
            //Console.WriteLine(product2);

            //// 3. Static Factory Method
            //Productss product3 = Productss.CreateProduct("Tablet", 499.99, "Electronics");
            //Console.WriteLine("\nStatic Factory Method:");
            //Console.WriteLine(product3);

            //// 4. Anonymous Type
            //var anonymousProduct = new { Name = "Headphones", Price = 199.99, Category = "Accessories" };
            //Console.WriteLine("\nAnonymous Type:");
            //Console.WriteLine($"Name: {anonymousProduct.Name}, Price: {anonymousProduct.Price}, Category: {anonymousProduct.Category}");

            //// 5. Reflection
            //Productss product4 = (Productss)Activator.CreateInstance(typeof(Productss), "Smart Watch", 299.99, "Wearables");
            //Console.WriteLine("\nReflection:");
            //Console.WriteLine(product4);

            //// 6. Default values in constructor
            //Productss product5 = new Productss();
            //Console.WriteLine("\nDefault Constructor with Default Values:");
            //Console.WriteLine(product5);


            ////Assignment20

            //ShoppingCart myCart = new ShoppingCart();

            //myCart.AddProduct("Apple", 1.50, 3);
            //myCart.AddProduct("Bread", 2.00, 2);
            //myCart.AddProduct("Milk", 1.75, 1);

            //double total = myCart.CalculateTotalPrice();
            //Console.WriteLine($"\nTotal Price of all products: {total}");

            //Console.ReadLine();

            ////Assignment21
            //Banks myBank = new Banks();

            //myBank.AddCustomer("Alice");
            //myBank.AddCustomer("Bob");

            //myBank.AddAccount("Alice", 1001, 5000.00m);
            //myBank.AddAccount("Alice", 1002, 1500.50m);
            //myBank.AddAccount("Bob", 1003, 3000.75m);

            //myBank.DisplayCustomerDetails();

            //Console.ReadLine();


            ////Assignment22

            //University university = new University();

            //university.AddDepartment("Computer Science");
            //university.AddDepartment("Mathematics");

            //university.AddCourse("Computer Science", "Data Structures", "CS101", 4);
            //university.AddCourse("Computer Science", "Algorithms", "CS102", 3);
            //university.AddCourse("Mathematics", "Calculus I", "MATH101", 4);
            //university.AddCourse("Mathematics", "Linear Algebra", "MATH102", 3);

            //university.DisplayCourseDetails();

            //Console.ReadLine();
        }
    }
}



