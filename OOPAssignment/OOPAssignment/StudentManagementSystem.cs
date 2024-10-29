using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class StudentManagementSystem
    {
        private string studentName;
        private string studentID;
        private List<int> marks = new List<int>();
        public StudentManagementSystem(string sName,string sID, List<int> marks)
        {
            studentName = sName;
            studentID = sID;
            this.marks = marks;  
        }

        public void AddMark(int mark)
        {
            marks.Add(mark);
            Console.WriteLine($"\n{mark} Added");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student ID: {studentID}");
            Console.Write("Marks:");
            foreach (int item in marks)
            {
                Console.Write($" {item}");
            }
        }

        public void AverageMark()
        {
            int sum = 0;
            int avg = 0;
            int count = 0;
            foreach (var item in marks)
            {
                sum+= item;
                count++;
            }
            avg = sum/count;
            Console.WriteLine($"Average mark:{avg}");
        }
    }
}
