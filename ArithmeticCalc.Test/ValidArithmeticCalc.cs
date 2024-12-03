namespace ArithmeticCalc.Test
{
    [TestClass]
    public class ValidArithmeticCalc
    {
        [TestMethod]
        public void TestCalcExpression()
        {
            Assert.AreEqual(5, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("3 + 2"));
            Assert.AreEqual(Math.Sin(3+2)*4*4*4, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 + 2 ) * 4 ^ 3"));
            Assert.AreEqual(Math.Sin(3 + 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 + 2 ) * 2 √ 4"));
            Assert.AreEqual(Math.Sin(3 + 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 + 2 ) * 2 log 4"));
            Assert.AreEqual(Math.Sin(3 + 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 + 2 ) * 4 / 2"));
            Assert.AreEqual(Math.Sin(3 - 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 - 2 ) * 4 / 2"));
            Assert.AreEqual(Math.Sin(3 - 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 - 2 ) * 2 mod 4"));
            Assert.AreEqual(Math.Sin(3 - 2) * 2, ArithmeticCalc.Lib.ArithmeticCalc.CalcExpression("sin ( 3 + negative 2 ) * 2 mod 4"));
        }
        [TestMethod]
        public void ValidGetPostfixForm()
        {
            Assert.AreEqual("3", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("3 + 2")[0]);
            Assert.AreEqual("2", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("3 + 2")[1]);
            Assert.AreEqual("+", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("3 + 2")[2]);
            Assert.AreEqual("+", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("( 3 + 2 )")[2]);
            Assert.AreEqual("2", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("( 3 + 2 )")[1]);
            Assert.AreEqual("3", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("( 3 + 2 )")[0]);
            Assert.AreEqual("*", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("( 3 + 2 ) * 4")[4]);
            Assert.AreEqual("sin", ArithmeticCalc.Lib.ArithmeticCalc.GetPostfixForm("sin ( 3 + 2 ) * 4")[3]);



        }
    }
}