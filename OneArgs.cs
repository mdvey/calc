namespace calc
{
    static class OneArgumentsFactory
    {

        public static IOneArgumentsCalculator CreateCalculator(string calcname)
        {
            switch (calcname)
            {
                case "operation 1/X":
                    return new FlipCalc();
                default:
                    return new FlipCalc(); // заглушка "для невозможного варианта"
            }
        }
    }

    interface IOneArgumentsCalculator
    {
        double Calculate(double firstValue);
    }

    class FlipCalc : IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return 1 / firstValue;
        }
    }
}
