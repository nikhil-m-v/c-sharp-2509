using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Phone
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Phone(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }

        public Phone(Phone other)
        {
            Model = other.Model;
            Color = other.Color;
            Year = other.Year;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Color: {Color}, Year: {Year}");
        }
    }

}
