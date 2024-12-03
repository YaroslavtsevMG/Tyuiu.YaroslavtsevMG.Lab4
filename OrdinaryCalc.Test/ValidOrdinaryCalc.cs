namespace OrdinaryCalc.Test
{
    [TestClass]
    public class ValidOrdinaryCalc
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            Assert.AreEqual(1, OrdinaryCalc.Lib.OrdinaryCalc.CalcSumma(1, 0));
        }
        [TestMethod]
        public void TestCalculateDifference()
        {
            Assert.AreEqual(10, OrdinaryCalc.Lib.OrdinaryCalc.CalcDifference(90, 80));
        }
        [TestMethod]
        public void TestCalculateMultiplication()
        {
            Assert.AreEqual(0, OrdinaryCalc.Lib.OrdinaryCalc.CalcMultiplication(1, 0));
        }
        [TestMethod]
        public void TestCalculateQuotient()
        {
            Assert.AreEqual(1000, OrdinaryCalc.Lib.OrdinaryCalc.CalcQuotient(1000000, 1000));
        }
    }
}