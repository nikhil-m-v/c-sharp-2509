using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class University
    {
        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
            Console.WriteLine($"Department '{name}' added.");
        }

        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            var department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
                Console.WriteLine($"Course '{courseName}' added to department '{departmentName}'.");
            }
            else
            {
                Console.WriteLine($"Department '{departmentName}' not found.");
            }
        }


        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nCourse Details:");
            foreach (var department in departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                department.DisplayCourses();
            }
        }

        public class Department
        {
            public string Name { get; set; }
            private List<Course> courses = new List<Course>();

            public Department(string name)
            {
                Name = name;
            }

            public void AddCourse(string courseName, string courseCode, int credits)
            {
                courses.Add(new Course(courseName, courseCode, credits));
            }

            public void DisplayCourses()
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"\tCourse Name: {course.CourseName}, Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }

            public class Course
            {
                public string CourseName { get; set; }
                public string CourseCode { get; set; }
                public int Credits { get; set; }

                public Course(string courseName, string courseCode, int credits)
                {
                    CourseName = courseName;
                    CourseCode = courseCode;
                    Credits = credits;
                }
            }
        }

    }
}

