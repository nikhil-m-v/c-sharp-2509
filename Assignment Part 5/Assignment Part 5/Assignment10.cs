using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    class FileHandler
    {
        public static string ReadFile(string filePath)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                Console.WriteLine("File opened");
                return reader.ReadToEnd();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File closed");
                }
            }
        }
    }
}
