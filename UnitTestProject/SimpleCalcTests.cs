using CalcLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class SimpleCalcTests
    {
        //Add Method
        [TestMethod]
        public void TestAddWithTwoPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(2.25M, 3.75M);
        }

        [TestMethod]
        public void TestAddWithTwoNegativeNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(-2.25M, -3.75M);
        }

        [TestMethod]
        public void TestAddWithFirstNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(-2.25M, 3.75M);
        }

        [TestMethod]
        public void TestAddWithSecondNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(2.25M, -3.75M);
        }

        [TestMethod]
        public void TestAddTwoPositiveNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(2, 3);
        }

        [TestMethod]
        public void TestAddTwoNegativeNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(-2, -3);
        }

        [TestMethod]
        public void TestAddWithTwoZeroPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(0M, 0M);
        }

        [TestMethod]
        public void TestAddTwoPositiveNumbersWithFirstNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(0M, 3.75M);
        }

        [TestMethod]
        public void TestAddTwoPositiveNumbersWithSecondNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(2.25M, 0M);
        }

        [TestMethod]
        public void TestAddOneNegativeNumberWithOneZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.add(0M, -3.75M);
        }

        //Subtract Method
        [TestMethod]
        public void TestSubtractWithTwoPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(2.25M, 3.75M);
        }

        [TestMethod]
        public void TestSubtractWithTwoNegativeNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(-2.25M, -3.75M);
        }

        [TestMethod]
        public void TestSubtractWithFirstNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(-2.25M, 3.75M);
        }

        [TestMethod]
        public void TestSubtractWithSecondNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(2.25M, -3.75M);
        }

        [TestMethod]
        public void TestSubtractTwoPositiveNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(2, 3);
        }

        [TestMethod]
        public void TestSubtractTwoNegativeNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(-2, -3);
        }

        [TestMethod]
        public void TestSubtractWithTwoZeroPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(0M, 0M);
        }

        [TestMethod]
        public void TestSubtractTwoPositiveNumbersWithFirstNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(0M, 3.75M);
        }

        [TestMethod]
        public void TestSubtractTwoPositiveNumbersWithSecondNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(2.25M, 0M);
        }

        [TestMethod]
        public void TestSubtractOneNegativeNumberWithOneZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.subtract(0M, -3.75M);
        }

        //Multiply Method
        [TestMethod]
        public void TestMultiplyWithTwoPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(2.25M, 3.75M);
        }

        [TestMethod]
        public void TestMultiplyWithTwoNegativeNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(-2.25M, -3.75M);
        }

        [TestMethod]
        public void TestMultiplyWithFirstNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(-2.25M, 3.75M);
        }

        [TestMethod]
        public void TestMultiplyWithSecondNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(2.25M, -3.75M);
        }

        [TestMethod]
        public void TestMultiplyTwoPositiveNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(2, 3);
        }

        [TestMethod]
        public void TestMultiplyTwoNegativeNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(-2, -3);
        }

        [TestMethod]
        public void TestMultiplyWithTwoZeroPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(0M, 0M);
        }

        [TestMethod]
        public void TestMultiplyTwoPositiveNumbersWithFirstNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(0M, 3.75M);
        }

        [TestMethod]
        public void TestMultiplyTwoPositiveNumbersWithSecondNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(2.25M, 0M);
        }

        [TestMethod]
        public void TestMultiplyOneNegativeNumberWithOneZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.multiply(0M, -3.75M);
        }

        //Divide Method
        [TestMethod]
        public void TestDivideWithTwoPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(2.25M, 3.75M);
        }

        [TestMethod]
        public void TestDivideWithTwoNegativeNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(-2.25M, -3.75M);
        }

        [TestMethod]
        public void TestDivideWithFirstNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(-2.25M, 3.75M);
        }

        [TestMethod]
        public void TestDivideWithSecondNegativeNumber()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(2.25M, -3.75M);
        }

        [TestMethod]
        public void TestDivideTwoPositiveNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(2, 3);
        }

        [TestMethod]
        public void TestDivideTwoNegativeNumbersWithoutDecimal()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(-2, -3);
        }

        [TestMethod]
        public void TestDivideWithTwoZeroPositiveNumbers()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(0M, 0M);
        }

        [TestMethod]
        public void TestDivideTwoPositiveNumbersWithFirstNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(0M, 3.75M);
        }

        [TestMethod]
        public void TestDivideTwoPositiveNumbersWithSecondNumberAsZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(2.25M, 0M);
        }

        [TestMethod]
        public void TestDivideOneNegativeNumberWithOneZeroValue()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.divide(0M, -3.75M);
        }

        //Selection Methods
        [TestMethod]
        public void TestSelectionAdd()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.OperatorSwitch(2.25M, 3.75M, "add");
        }

        [TestMethod]
        public void TestSelectionSubtract()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.OperatorSwitch(2.25M, 3.75M, "subtract");
        }

        [TestMethod]
        public void TestSelectionMultiply()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.OperatorSwitch(2.25M, 3.75M, "multiply");
        }

        [TestMethod]
        public void TestSelectionDivide()
        {
            SimpleCalc simplecalc = new SimpleCalc();
            decimal result = simplecalc.OperatorSwitch(2.25M, 3.75M, "divide");
        }
    }
}