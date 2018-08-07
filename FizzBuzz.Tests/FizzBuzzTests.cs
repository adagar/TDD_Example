using System;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1, 2, 4, 7, 8, 11, 13, 14)] int input)
        {
            //act
            string output = FizzBuzzer.GetValue(input);

            //assert
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_When3_ReturnsFizz(
            [Values(3, 6, 9, 12)] int input)
        {
            //act
            string output = FizzBuzzer.GetValue(input);

            //assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When5_ReturnsBuzz(
            [Values(5, 10)] int input)
        {
            //act
            string output = FizzBuzzer.GetValue(input);

            //assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }

    }
}
