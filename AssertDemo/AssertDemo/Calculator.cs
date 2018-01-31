using System;

namespace AssertDemo
{
    public class Calculator
    {
        public int AddInts(int a, int b)
        {
            return a + b;
        }


        public double AddDoubles(double a, double b)
        {
            return Math.Round(a + b, 5);
        }


        public int Divide(int value, int by)
        {
            if (by == 0)
                throw new DivideByZeroException();

            return value / by;
        }
    }
}