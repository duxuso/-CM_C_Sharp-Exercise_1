using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullOrEmptyString;

namespace NullOrEmptyStringTest
{
    [TestClass]
    public class NullOrEmptyStringTests 
    {
        [TestMethod]
        public void isNullOrEmpty_WhenStringIsNull()
        {
            // arrange
            string test_null = null;
            bool expected = true;

            NullOrEmptyStrings noes = new NullOrEmptyStrings();

            // act
            bool actual = noes.isNullOrEmpty(test_null);
                   
            // assert            
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void isNullOrEmpty_WhenStringIsEmpty() { 
            // arrange
            string test_empty = "";
            bool expected = true;

            NullOrEmptyStrings noes = new NullOrEmptyStrings();

            // act
            bool actual = noes.isNullOrEmpty(test_empty);

            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void isNullOrEmpty_WhenStringIsOther() { 
            // arrange
            string test_other = "something";
            bool expected = false;

            NullOrEmptyStrings noes = new NullOrEmptyStrings();

            // act
            bool actual = noes.isNullOrEmpty(test_other);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
