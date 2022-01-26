using System;

namespace Models
{
    public static class MyMath
    {
        public static double Pow(double number, int power)
        {
            if (number == 0)
            {
                return 1;
            }
            if (power < 0)
            {
                power *= -1;
                number = 1 / number;
            }
            double answer = 1;
            for (int i = 0; i < power; ++i)
            {
                answer *= number;
            }
            return answer;
        }
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }
            if (number < 2)
            {
                return 1;
            }
            return Factorial(number - 1) * number;
        }
    }
}
