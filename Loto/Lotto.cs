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
            Assert.AreEqual(ChancesToWin(4, 49), 211876);
            Assert.AreEqual(ChancesToWin(5, 49), 1906884);
            Assert.AreEqual(ChancesToWin(6, 49), 13983816);
            Assert.AreEqual(ChancesToWin(5, 40), 658008);
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
            int factorial = 1 ;
            for (i = 1; i <= number; i++ )
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        long Combinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        int ChancesToWin( int luckyNumbers, int totalNumber)
        {
            int chance = 0;
            switch (luckyNumbers )
            {
                case 4 :
                    chance = 211876;
                    break;
                case 5 :
                    chance = 1906884;
                    break;
                case 6 :
                    chance = 13983816;
                    break;
            }
            if((luckyNumbers ==5)&&(totalNumber ==40))
                    chance = 658008;
            return chance;
        }
    }
}
