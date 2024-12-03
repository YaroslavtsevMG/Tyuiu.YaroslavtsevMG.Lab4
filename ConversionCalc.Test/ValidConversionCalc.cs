namespace ConversionCalc.Test
{
    [TestClass]
    public class ValidConversionCalc
    {
        [TestMethod]
        public void ValidFromByteToKilobyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToKilobyte(1024*2));
        }
        [TestMethod]
        public void ValidFromByteToMegabyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToMegabyte(1024 * 2 * 1024));
        }
        [TestMethod]
        public void ValidFromByteToGigabyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToGigabyte((long)1024 * 2 * 1024 * 1024));
        }
        [TestMethod]
        public void ValidFromByteToTerrabyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToTerrabyte((long)1024 * 2 * 1024 * 1024 * 1024));
        }
        [TestMethod]
        public void ValidFromByteToPetabyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToPetabyte((long)1024 * 2 * 1024 * 1024 * 1024 * 1024));
        }
        [TestMethod]
        public void ValidFromByteToEkzobyte()
        {
            Assert.AreEqual(2, ConversionCalc.Lib.ConversionCalc.FromByteToEkzobyte((long)1024 * 2 * 1024 * 1024 * 1024 * 1024 * 1024));
        }
        [TestMethod]
        public void ValidFromEkzobyteToByte()
        {
            Assert.AreEqual((long)1024 * 1024 * 1024 * 1024 * 1024 * 1024, ConversionCalc.Lib.ConversionCalc.FromEkzobyteToByte(1));
        }
        [TestMethod]
        public void ValidFromPetabyteToByte()
        {
            Assert.AreEqual((long)1024 * 1024 * 1024 * 1024 * 1024 , ConversionCalc.Lib.ConversionCalc.FromPetabyteToByte(1));
        }
        [TestMethod]
        public void ValidFromTerrabyteToByte()
        {
            Assert.AreEqual((long)1024 * 1024 * 1024 * 1024 , ConversionCalc.Lib.ConversionCalc.FromTerrabyteToByte(1));
        }
        [TestMethod]
        public void ValidFromGigabyteToByte()
        {
            Assert.AreEqual((long)1024 * 1024 * 1024 , ConversionCalc.Lib.ConversionCalc.FromGigabyteToByte(1));
        }
        [TestMethod]
        public void ValidFromMegabyteToByte()
        {
            Assert.AreEqual((long)1024 * 1024 , ConversionCalc.Lib.ConversionCalc.FromMegabyteToByte(1));
        }
        [TestMethod]
        public void ValidFromKilobyteToByte()
        {
            Assert.AreEqual((long)1024 , ConversionCalc.Lib.ConversionCalc.FromKilobyteToByte(1));
        }
    }
}