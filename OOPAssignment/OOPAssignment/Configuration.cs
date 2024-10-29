using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Configuration
    {
        public static string ApplicationName;

        public string UserPreference { get; set; }

        static Configuration()
        {
            ApplicationName = "Default Application";
            Console.WriteLine("System-wide settings loaded.");
        }
        public Configuration(string userPreference)
        {
            UserPreference = userPreference;
            Console.WriteLine("User-specific settings loaded.");
        }

        public void DisplaySettings()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"User Preference: {UserPreference}");
        }
    }
}
