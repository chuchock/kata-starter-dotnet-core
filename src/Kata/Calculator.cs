namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers = "")
        {
            if (numbers.Length == 1)
            {
                return int.Parse(numbers);
            }

            return 0;
        }
    }
}