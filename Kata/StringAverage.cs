using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class StringAverage
    {
        public static string AverageString(string str)
        {
            if (String.IsNullOrEmpty(str)) return "n/a";
            string[] numText = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] numList = str.Split(' ');

            int sum = 0;
            foreach (string num in numList)
            {
                int numValue = Array.IndexOf(numText, num);
                if (numValue < 0) return "n/a";
                sum += numValue;
            }

            return numText[(int)Math.Floor((double)sum / (double)numList.Length)];
        }
    }
}
