using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TerenulFermierului
{
    [TestClass]
    public class TetstFarm
    {
        [TestMethod]
        public void TestSurface()
        {
            Assert.AreEqual(ReturnInitialLength(57000, 230), 150);
            Assert.AreEqual(ReturnInitialLength(770000, 230), 770);
        }

        int CalculateSurface(int length, int width)
            {
            return length * width;
            }
        int ReturnInitialLength(int surface, int addedWidth)
        {
            int initialWidth = 1;
            int toalWidth = initialWidth + addedWidth;
            for (initialWidth = 1 ; CalculateSurface (initialWidth ,toalWidth )<surface; initialWidth++)
            {
                toalWidth = initialWidth + addedWidth;
            }
            return initialWidth-1;
        }
    }
}
