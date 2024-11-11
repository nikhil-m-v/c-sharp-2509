using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    public class InputHandler
    {
        public int GetUserInput()
        {
            int number;
            while (true) // Keep prompting until a valid integer is entered
            {
                Console.Write("Please enter an integer: ");

                try
                {
                    number = int.Parse(Console.ReadLine());
                    break; // Exit the loop if parsing is successful
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer within the range of -2,147,483,648 to 2,147,483,647.");
                }
            }

            return number;
        }
    }
}
