using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Lotto
    {
        [TestMethod]
        public void TestLotto()
        {
            Assert.AreEqual(ChancesToWin(3, 25), 2300);
        }
        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(Factorial(8), 40320);
            Assert.AreEqual(Factorial(10), 3628800);
            Assert.AreEqual(Factorial(1), 1);
        }
        long Factorial(int number)
        {
            int i;
            int factorial = 1;
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        long Combinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        long ChancesToWin( int numberDraw, int totalNumber)
        {
            return Combinations(totalNumber, numberDraw);
        }
    }
}
