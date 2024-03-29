﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasaPranz
{
    [TestClass]
    public class TestLaunch
    {

        [TestMethod]
        public void TestCommonLunch()
        {
            Assert.AreEqual(LowestMultiple(4, 6), 12);
            Assert.AreEqual(LowestMultiple(1, 6), 6);
            Assert.AreEqual(LowestMultiple(4, 1), 4);
            Assert.AreEqual(LowestMultiple(4, 16), 16);
        }
        int LowestMultiple(int number1, int number2)
        {
            int multiplyNumbers = number1 *number2 ;
            if (number1 == 1 || number2 == 1)
            {
                return (number2 + number1 - 1);
            }
            else
            {
                int commonFactor = 2;
                while ((commonFactor <= number1) && (commonFactor <= number2))
                {
                    if ((number2 % commonFactor == 0) && (number1 % commonFactor == 0))
                    {
                        multiplyNumbers = multiplyNumbers / commonFactor;
                        number1 = number1 / commonFactor;
                        number2 = number2 / commonFactor;
                        commonFactor = 2;
                    }
                    else
                        commonFactor++;
                }
                return multiplyNumbers;
            }
        }
    }
}
