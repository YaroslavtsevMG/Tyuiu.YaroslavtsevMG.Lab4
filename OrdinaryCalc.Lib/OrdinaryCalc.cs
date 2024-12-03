namespace OrdinaryCalc.Lib
{
    public static class OrdinaryCalc
    {
        public static double CalcSumma(double a, double b)
        {
            return a + b;
        }
        public static double CalcDifference(double a, double b)
        {
            return a - b;
        }
        public static double CalcMultiplication(double a, double b)
        {
            return a * b;
        }
        public static double CalcQuotient(double a, double b)
        {
            return a / b;
        }
        public static double CalcPower(double a, double b)
        {
            return Math.Pow(a,b);
        }
        public static double CalcRoot(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }
    }
}
