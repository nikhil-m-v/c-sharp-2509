using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    //15
    //a.runtime exceptions
    public class FileProcessor
    {
        public void ReadFileContent(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
    //b.runtime exceptions
    public class MathOpss
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
        }
    }


    //c.custom exception of invalid age
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Invalid age entered");
        }


    }
    //creating a class person for setAge method
    public class Person
    {

        public int Age { get; set; }

        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException();
            }
            Age = age;
        }
    }


}

