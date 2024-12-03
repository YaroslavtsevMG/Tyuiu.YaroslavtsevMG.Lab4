using NDSCalc.Lib;

namespace NDSCalc.Test
{
    [TestClass]
    public class ValidNDSCalc
    {
        [TestMethod]
        public void ValidCalcFirstFormula()
        {
            Assert.AreEqual(10, NDSCalc.Lib.NDSCalc.CalcFirstFormula(110, 10)[0]);
            Assert.AreEqual(100, NDSCalc.Lib.NDSCalc.CalcFirstFormula(110, 10)[1]);
        }
        [TestMethod]
        public void ValidCalcSecondFormula()
        {
            Assert.AreEqual(0.2, NDSCalc.Lib.NDSCalc.CalcSecondFormula(1, 20)[0]);
            Assert.AreEqual(1.2, NDSCalc.Lib.NDSCalc.CalcSecondFormula(1, 20)[1]);
        }
    }
}