using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzbuzzCalculatorTest
{
    [TestFixture]
    public class FizzBuzzCalculatorTest
    {
        [Test]
        public void FizzbuzzCalcReturnsFizzForThree()
        {
            Assert.AreEqual("Fizz", FizzbuzzCalculator.FizzbuzzCalculator.fizzbuzzCalc(3));
        }

        [Test]
        public void FizzbuzzCalcReturnsBuzzForFive()
        {
            Assert.AreEqual("Buzz", FizzbuzzCalculator.FizzbuzzCalculator.fizzbuzzCalc(5));
        }

        [Test]
        public void FizzbuzzCalcReturnsFizzBuzzForFifteen()
        {
            Assert.AreEqual("FizzBuzz", FizzbuzzCalculator.FizzbuzzCalculator.fizzbuzzCalc(15));
        }

        [Test]
        public void FizzbuzzCalcReturnsNumberToStringForDefaultCase()
        {
            Assert.AreEqual(29.ToString(), FizzbuzzCalculator.FizzbuzzCalculator.fizzbuzzCalc(29));
        }
    }
}
