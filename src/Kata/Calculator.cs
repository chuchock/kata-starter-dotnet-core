using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers = "")
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            var numberList = numbers.Split(new []{",","\n"}, StringSplitOptions.None).Select(int.Parse);
            return numberList.Sum();
        }
    }
}