using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cub
{
    [TestClass]
    public class Cub
    {
        [TestMethod]
        public void TestCub()
        {
            Assert.AreEqual(Contor (2),442);
            Assert.AreEqual(Contor(1), 192);
            Assert.AreEqual(Contor(3), 692);
        }
        int CubNumber(int number)
        {
            return (number * number * number);
        }
        bool ValidateTermination888(int number)
        {
            if ( CubNumber (number )%1000 == 888)
            {
                return true;
            }
            else return false;
        }
        int Contor(int k)
        {
            int i ;
            int n = 0;
            for ( i = 1; n < k; i++)
            {
                if (ValidateTermination888(i) )
                {
                    n=n+1;
                }
            }
                return i-1;
        }
    }
}
