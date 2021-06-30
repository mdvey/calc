using System;

namespace calc
{
    static class TwoArgumentsFactory
    {

        public static ITwoArgumentsCalculator CreateCalculator(string calcname)
        {
            switch (calcname)
            {
                case "plus":
                    return new AdditionCalc();
                case "minus":
                    return new SubstractCalc();
                case "multiply":
                    return new MultiplyCalc();
                case "split":
                    return new DivisionCalc();
                case "operation X^(1/Y)":
                    return new SqrtCalc();
                default:
                    return new AdditionCalc(); // заглушка "для невозможного варианта"
            }
        }
    }

    interface ITwoArgumentsCalculator
    {
        double Calculate(double firstValue, double secondValue);
    }

    class AdditionCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }

    class SubstractCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }

    class MultiplyCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }

    class DivisionCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }

    class SqrtCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, 1 / secondValue);
        }
    }    
}
