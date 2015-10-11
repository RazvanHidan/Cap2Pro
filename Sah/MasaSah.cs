using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sah
{
    [TestClass]
    public class MasaSah
    {
        [TestMethod]
        public void TestChess()
        {
            Assert.AreEqual(NumberOfSquare(2), 5);
            Assert.AreEqual(NumberOfSquare(8), 204);
        }
        int Sqr(int number)
        {
            return number * number;
        }
        int NumberOfSquare(int lengthTable)
        {
            int squareNumber = 0;
            for (int i=0; i< lengthTable ; i++)
            {
                squareNumber = squareNumber + Sqr(lengthTable - i);
            }
            return squareNumber;
        }
    }
}
