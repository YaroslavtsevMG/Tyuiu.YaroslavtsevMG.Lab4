namespace ConversionCalc.Lib
{
    public static class ConversionCalc
    {
        public static double FromByteToKilobyte(double x)
        {
            return x/1024;
        }
        public static double FromByteToMegabyte(double x)
        {
            return x / 1024/1024;
        }
        public static double FromByteToGigabyte(double x)
        {
            return x / 1024 / 1024/1024;
        }
        public static double FromByteToTerrabyte(double x)
        {
            return x / 1024 / 1024 / 1024/1024;
        }
        public static double FromByteToPetabyte(double x)
        {
            return x / 1024 / 1024 / 1024 / 1024/1024;
        }
        public static double FromByteToEkzobyte(double x)
        {
            return x / 1024 / 1024 / 1024 / 1024 / 1024/1024;
        }
        public static double FromEkzobyteToByte(double x)
        {
            return x * 1024 * 1024 * 1024 * 1024 * 1024 * 1024;
        }
        public static double FromPetabyteToByte(double x)
        {
            return x * 1024 * 1024 * 1024 * 1024 * 1024;
        }
        public static double FromTerrabyteToByte(double x)
        {
            return x * 1024 * 1024 * 1024 * 1024;
        }
        public static double FromGigabyteToByte(double x)
        {
            return x * 1024 * 1024 * 1024;
        }
        public static double FromMegabyteToByte(double x)
        {
            return x * 1024 * 1024;
        }
        public static double FromKilobyteToByte(double x)
        {
            return x * 1024;
        }
    }
}
