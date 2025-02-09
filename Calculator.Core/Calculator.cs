namespace Calculator.Core
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divide by 0");
            }
            return (double)a / (double)b;
        }
        public static float Multiply(int a, float b)
        {
            checked
            {
                float result = a * b;
                if (result > float.MaxValue || result < float.MinValue)
                {
                    throw new OverflowException("Multiplication result is out of range.");
                }
                return result;
            }
        }
        public static int Subtract(int a, int b)
        {
            checked
            {
                return a - b;
            }
        }
    }
}




