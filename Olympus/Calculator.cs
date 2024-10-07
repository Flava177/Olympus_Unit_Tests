using System.Numerics;

namespace Olympus
{
    public class Calculator
    {
        public List<int> OddNumbers = new();

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public bool IsInputOddNumber(int a)
        {
            return (a % 2 != 0);
        }

        public double AddDoubleNumbers(double a, double b)
        {
            return a + b;
        }

        //Retrieve odd int numbers in range
        public List<int> GetOddNumbersRange(int min, int max)
        {
            OddNumbers.Clear();
            for (int i = min; i <= max; i++)
            {
                if( i % 2 != 0)
                {
                    OddNumbers.Add(i);
                }
            }
            return OddNumbers;
        }

    }
}
