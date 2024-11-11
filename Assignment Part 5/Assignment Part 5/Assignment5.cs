using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    public class ScoreManager
    {
        public void IncreaseScore(ref int score)
        {
            score += 10;
            Console.WriteLine($"Score inside IncreaseScore method: {score}");
        }
    }
}
