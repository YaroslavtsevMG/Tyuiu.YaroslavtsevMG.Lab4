namespace NDSCalc.Lib
{
    public static class NDSCalc
    {
        public static double[] CalcFirstFormula(double x, double y)
        {
            return [(x*y)/(y+100),x- (x * y) / (y + 100)];
        }
        
        public static double[] CalcSecondFormula(double x, double y)
        {
            return [(x*y)/100, x+ (x * y) / 100];
        }
    }
}
