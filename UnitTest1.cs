using NUnit.Framework;
using System.IO;
using System;
using ZadanieTesty;

namespace TestDoZadania1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("3", "Liczba jest liczb¹ pierwsz¹")]
        [TestCase("5", "Liczba jest liczb¹ pierwsz¹")]
        [TestCase("11", "Liczba jest liczb¹ pierwsz¹")]
        public void PierwszyTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "Liczba jest nie liczb¹ pierwsz¹")]
        [TestCase("6", "Liczba jest nie liczb¹ pierwsz¹")]
        [TestCase("12", "Liczba jest nie liczb¹ pierwsz¹")]
        public void DrugiTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreNotEqual(expected, res);
        }

        [TestCase("-1", "Liczba jest nie liczb¹ pierwsz¹")]
        [TestCase("-112", "Liczba jest nie liczb¹ pierwsz¹")]
        public void TrzeciTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => sut.Sprawdzenie(input));
        }
    }
}