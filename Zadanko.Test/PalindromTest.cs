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

        [TestCase("Anna")]
        [TestCase("anna")]
        [TestCase("anna anna")]
        [TestCase("Kobyla ma maly bok")]
        [TestCase("anna    anna")]
        public void Check_WithString_ReturnGoodResponse(string var)
        {
            var result = _instance.Check(var);
            Assert.AreEqual("Tak, to jest palindrom", result);

        }

        [TestCase("Arkadiusz")]
        [TestCase("")]
        [TestCase("?%2 32 1! s")]
        public void Check_WithString_ReturnWrongResponse(string var)
        {
            var result = _instance.Check(var);
            Assert.AreEqual("Nope, to nie jest palindrom", result);

        }

    }
}
