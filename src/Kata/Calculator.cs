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

            var number = numbers.Split(",");
            if (number.Length == 1)
            {
                return int.Parse(number[0]);
            }
            else
            {
                return int.Parse(number[0]) + int.Parse(number[1]);
            }
        }
    }
}