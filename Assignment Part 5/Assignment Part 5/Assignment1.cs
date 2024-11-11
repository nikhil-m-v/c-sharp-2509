using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    class Library
    {
        private string[] books;

        public Library(int numberOfBooks)
        {
            books = new string[numberOfBooks];
        }

        public void AddBook(int index, string title)
        {
            if (index >= 0 && index < books.Length)
            {
                books[index] = title;
                Console.WriteLine($"Book '{title}' added at position {index}.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Index {i}: {books[i]}");
            }
        }
    }

    class Classroom
    {
        private string[,] seats;

        public Classroom(int rows, int columns)
        {
            seats = new string[rows, columns];
        }

        public void AssignSeat(int row, int column, string studentName)
        {
            if (row >= 0 && row < seats.GetLength(0) && column >= 0 && column < seats.GetLength(1))
            {
                seats[row, column] = studentName;
                Console.WriteLine($"Seat assigned to {studentName} at row {row}, column {column}.");
            }
            else
            {
                Console.WriteLine("Invalid seat position.");
            }
        }

        public void DisplaySeatingArrangement()
        {
            Console.WriteLine("Seating arrangement in the classroom:");

            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j] != null) // Only display occupied seats
                    {
                        Console.Write($"[{i},{j}] {seats[i, j]}\t");
                    }
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
