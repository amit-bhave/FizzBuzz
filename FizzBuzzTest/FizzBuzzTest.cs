using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz.Service;

namespace FizzBuzzTest
{
    [TestFixture]
    internal class FizzBuzzTest
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void IsFizzBuzzResultValid(int testKey, string expectedValue)
        {
            var service = new FizzBuzzService();

            var result = service.GetFizzBuzzResults();

            var resultText = result.First(x => x.FizzBuzzNumber == testKey).FizzBuzzResultText;

            Assert.That(resultText.Equals(expectedValue));
        }
    }
}
