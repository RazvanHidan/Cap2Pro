using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColoaneExcel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void TestExcel1Letter()
        {
            Assert.AreEqual("Z", Word (26));
            Assert.AreEqual("A", Word(1));
        }
        [TestMethod]
        public void TestExcel2Letter()
        {
            Assert.AreEqual("AA", Word(27));
            Assert.AreEqual("ZZ", Word(702));
            Assert.AreEqual("ZA", Word(677));
            Assert.AreEqual("AZ", Word(52));
            Assert.AreEqual("BC", Word(55));
            Assert.AreEqual("YA", Word(651));
        }
        [TestMethod]
        public void TestExcel3Letter()
        {
            Assert.AreEqual("AAA", Word(703));
            Assert.AreEqual("AAZ", Word(728));
            Assert.AreEqual("ABC", Word(731));
        }
        string addLetterFromAscii(string word,int codAscii)
        {
            return ((char)codAscii + word);
        }
        string Word(int numberOfColum)
        {
            string constructWord = "";
            int cellNumber = numberOfColum;
            while (cellNumber >26)
            {
                if (cellNumber % 26 == 0)
                {
                    constructWord = "Z" + constructWord;
                    cellNumber = (cellNumber - 1) / 26;
                }
                else
                {
                    constructWord = (char)((cellNumber % 26) + 64) + constructWord;
                    cellNumber = (cellNumber / 26);
                }
            }
            constructWord = (char)((cellNumber % 27) + 64) + constructWord;
            return constructWord;
        }
    }
}
