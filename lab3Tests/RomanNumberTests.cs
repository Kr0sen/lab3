using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace lab3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            ushort exception = 0;

            ushort numberToConvert = 59;
            ushort numberToConvert2 = 2345;
            ushort numberToConvert3 = 34256;

            string expectedString = "LIX";
            string expectedString2 = "MMCCCXLV";
            string expectedString3 = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMCCLVI";

            string actualString = (new RomanNumber(numberToConvert)).ToString();
            string actualString2 = (new RomanNumber(numberToConvert2)).ToString();
            string actualString3 = (new RomanNumber(numberToConvert3)).ToString();

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(exception));

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(expectedString2, actualString2);
            Assert.AreEqual(expectedString3, actualString3);
        }

        [TestMethod()]
        public void SumTest()
        {
            RomanNumber numberToSum = new RomanNumber(23);
            RomanNumber numberToSum2 = new RomanNumber(990);
            string expectedSum = "MXIII";

            RomanNumber numberToSumExc = new RomanNumber(30000);
            RomanNumber numberToSumExc2 = new RomanNumber(50000);

            Assert.ThrowsException<RomanNumberException>(() => null + numberToSum2);
            Assert.ThrowsException<RomanNumberException>(() => numberToSum + null);
            Assert.ThrowsException<RomanNumberException>(() => (null as RomanNumber) + null);

            Assert.AreEqual(expectedSum, (numberToSum + numberToSum2).ToString());

            Assert.ThrowsException<RomanNumberException>(() => numberToSumExc + numberToSumExc2);
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber numberToSub = new RomanNumber(1234);
            RomanNumber numberToSub2 = new RomanNumber(234);
            string expectedSub = "M";

            RomanNumber numberToSubExc = new RomanNumber(9234);
            RomanNumber numberToSubExc2 = new RomanNumber(9234);

            RomanNumber numberToSubExc3 = new RomanNumber(1);
            RomanNumber numberToSubExc4 = new RomanNumber(50000);

            Assert.ThrowsException<RomanNumberException>(() => null - numberToSub2);
            Assert.ThrowsException<RomanNumberException>(() => numberToSub - null);
            Assert.ThrowsException<RomanNumberException>(() => (null as RomanNumber) - null);

            Assert.AreEqual(expectedSub, (numberToSub - numberToSub2).ToString());

            Assert.ThrowsException<RomanNumberException>(() => numberToSubExc - numberToSubExc2);
            Assert.ThrowsException<RomanNumberException>(() => numberToSubExc3 - numberToSubExc4);
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber numberToMul = new RomanNumber(4321);
            RomanNumber numberToMul2 = new RomanNumber(5);
            string expectedMul = "MMMMMMMMMMMMMMMMMMMMMDCV";

            RomanNumber numberToMulExc = new RomanNumber(9234);
            RomanNumber numberToMulExc2 = new RomanNumber(9234);

            Assert.ThrowsException<RomanNumberException>(() => null * numberToMul2);
            Assert.ThrowsException<RomanNumberException>(() => numberToMul * null);
            Assert.ThrowsException<RomanNumberException>(() => (null as RomanNumber) * null);

            Assert.AreEqual(expectedMul, (numberToMul * numberToMul2).ToString());

            Assert.ThrowsException<RomanNumberException>(() => numberToMulExc * numberToMulExc2);
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber numberToDiv = new RomanNumber(63921);
            RomanNumber numberToDiv2 = new RomanNumber(7);
            string expectedDiv = "MMMMMMMMMCXXXI";

            RomanNumber numberToDivExc = new RomanNumber(9234);
            RomanNumber numberToDivExc2 = new RomanNumber(9235);

            Assert.ThrowsException<RomanNumberException>(() => null / numberToDiv2);
            Assert.ThrowsException<RomanNumberException>(() => numberToDiv / null);
            Assert.ThrowsException<RomanNumberException>(() => (null as RomanNumber) / null);

            Assert.AreEqual(expectedDiv, (numberToDiv / numberToDiv2).ToString());

            Assert.ThrowsException<RomanNumberException>(() => numberToDivExc / numberToDivExc2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            ushort numberToConvert = 2323;
            ushort numberToConvert2 = 1;
            ushort numberToConvert3 = 9999;
            ushort numberToConvert4 = 65535;
            ushort numberToConvert5 = 9876;
            ushort numberToConvert6 = 54321;
            ushort numberToConvert7 = 54345;

            string expectedString = "MMCCCXXIII";
            string expectedString2 = "I";
            string expectedString3 = "MMMMMMMMMCMXCIX";
            string expectedString4 = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMDXXXV";
            string expectedString5 = "MMMMMMMMMDCCCLXXVI";
            string expectedString6 = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMCCCXXI";
            string expectedString7 = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMCCCXLV";

            string actualString = (new RomanNumber(numberToConvert)).ToString();
            string actualString2 = (new RomanNumber(numberToConvert2)).ToString();
            string actualString3 = (new RomanNumber(numberToConvert3)).ToString();
            string actualString4 = (new RomanNumber(numberToConvert4)).ToString();
            string actualString5 = (new RomanNumber(numberToConvert5)).ToString();
            string actualString6 = (new RomanNumber(numberToConvert6)).ToString();
            string actualString7 = (new RomanNumber(numberToConvert7)).ToString();

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(expectedString2, actualString2);
            Assert.AreEqual(expectedString3, actualString3);
            Assert.AreEqual(expectedString4, actualString4);
            Assert.AreEqual(expectedString5, actualString5);
            Assert.AreEqual(expectedString6, actualString6);
            Assert.AreEqual(expectedString7, actualString7);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber numberToClone = new RomanNumber(59);
            RomanNumber numberToClone2 = new RomanNumber(2345);
            RomanNumber numberToClone3 = new RomanNumber(34256);

            RomanNumber resultNumber = (RomanNumber)numberToClone.Clone();
            RomanNumber resultNumber2 = (RomanNumber)numberToClone2.Clone();
            RomanNumber resultNumber3 = (RomanNumber)numberToClone3.Clone();

            Assert.AreEqual(numberToClone.ToString(), resultNumber.ToString());
            Assert.AreEqual(numberToClone2.ToString(), resultNumber2.ToString());
            Assert.AreEqual(numberToClone3.ToString(), resultNumber3.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            ushort number = 100;
            ushort number2 = 25946;
            ushort number3 = 53712;
            RomanNumber numberToCompare = new RomanNumber(number);
            RomanNumber numberToCompare2 = new RomanNumber(number2);
            RomanNumber numberToCompare3 = new RomanNumber(number3);

            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare), number - number);
            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare2), number - number2);
            Assert.AreEqual(numberToCompare.CompareTo(numberToCompare3), number - number3);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare), number2 - number);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare2), number2 - number2);
            Assert.AreEqual(numberToCompare2.CompareTo(numberToCompare3), number2 - number3);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare), number3 - number);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare2), number3 - number2);
            Assert.AreEqual(numberToCompare3.CompareTo(numberToCompare3), number3 - number3);

            Assert.ThrowsException<RomanNumberException>(() => numberToCompare.CompareTo(null));
        }
    }
}