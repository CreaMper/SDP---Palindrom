using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanko.Test
{

    [TestFixture]
    public class PalindromTest
    {
        private Palindrom _instance;

        [SetUp]
        public void Setup()
        {
            _instance = new Palindrom();
        }

        [TestCase("Arkadiusz")]
        [TestCase("Anna")]
        [TestCase("anna")]
        [TestCase("Myszojeleń")]
        [TestCase("Kobyłamamałybok")]
        public void Check_WithString_ReturnGoodResponse(string var)
        {
            var result = _instance.Check(var);
            Assert.AreEqual("Tak, to jest palindrom", result);

        }
    }
}
