using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Employeee
    {
        public string Name { get; set; }
        public string[] Tasks { get; set; }

        public Employeee(string name, string[] tasks)
        {
            Name = name;
            Tasks = tasks;
        }

        // Abstract method to display tasks
        public abstract void DisplayTasks();
    }

    // Derived class Manager
    public class Managerr : Employeee
    {
        public Managerr(string name, string[] tasks) : base(name, tasks) { }

        // Implementation of DisplayTasks for Manager
        public override void DisplayTasks()
        {
            Console.WriteLine($"Manager {Name}'s tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"- [Management] {task}");
            }
        }
    }

    // Derived class Developer
    public class Developerr : Employeee
    {
        public Developerr(string name, string[] tasks) : base(name, tasks) { }

        // Implementation of DisplayTasks for Developer
        public override void DisplayTasks()
        {
            Console.WriteLine($"Developer {Name}'s tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"- [Development] {task}");
            }
        }
    }
}
