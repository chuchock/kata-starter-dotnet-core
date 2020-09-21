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
                var sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += int.Parse(number[i]);
                }

                return sum;
            }
        }
    }
}