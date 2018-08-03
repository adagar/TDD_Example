using System;
using NUnit.Framework;
using RomanNumberalLibrary;

namespace RomanNumberLibrary.Tests
{
    [TestFixture]
    public class RomanNumberalTests
    {
        [Test]
        public void OneReturnsI()
        {
            string roman1 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(1);
            Assert.AreEqual(roman1, "I");
        }

        [Test]
        public void IfPassed2ReturnII()
        {
            string roman2 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(2);
            Assert.AreEqual(roman2, "II");
        }

        [Test]
        public void Passed3ReturnIII()
        {
            string roman3 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(3);
            Assert.AreEqual(roman3, "III");
        }

        [Test]
        public void Passed5ReturnV()
        {
            string roman5 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(5);
            Assert.AreEqual(roman5, "V");
        }

        [Test]
        public void Passed4ReturnIV()
        {
            string roman4 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(4);
            Assert.AreEqual(roman4, "IV");
        }

        [Test]
        public void Passed10ReturnX()
        {
            string roman10 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(10);
            Assert.AreEqual(roman10, "X");
        }

        [Test]
        public void Passed7ReturnVII()
        {
            string roman7 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(7);
            Assert.AreEqual(roman7, "VII");
        }

        [Test]
        public void Passed9ReturnIX()
        {
            string roman9 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(9);
            Assert.AreEqual(roman9, "IX");
        }

        [Test]
        public void Passed9ReturnXIV()
        {
            string roman9 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(14);
            Assert.AreEqual(roman9, "XIV");
        }

        [Test]
        public void Passed50ReturnL()
        {
            string roman50 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(50);
            Assert.AreEqual(roman50, "L");
        }

        [Test]
        public void Passed100ReturnC()
        {
            string roman100 = RomanNumberalLibrary.RomanNumberalConverter.GetValue(100);
            Assert.AreEqual(roman100, "C");
        }
    }
}
