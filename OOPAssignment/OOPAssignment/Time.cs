using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public void SetTime(int hours, int minutes)
        {
            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = 0;
            }
            else
            {
                Console.WriteLine("Error: Invalid hour or minute value.");
            }
        }

        public void SetTime(int seconds)
        {
            if (seconds >= 0 && seconds < 86400)
            {
                this.hours = seconds / 3600;
                this.minutes = (seconds % 3600) / 60;
                this.seconds = seconds % 60;
            }
            else
            {
                Console.WriteLine("Error: Invalid seconds value.");
            }
        }

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hours = value;
                }
                else
                {
                    Console.WriteLine("Error: Invalid Hour value.");
                }
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Error: Invalid Minute value.");
                }
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("Error: Invalid Second value.");
                    
                }
            }
        }

        public void GetTime()
        {
            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
