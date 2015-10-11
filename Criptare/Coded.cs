using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Criptare
{
    [TestClass]
    public class Coded
    {
        [TestMethod]
        public void TestCod()
        {
            Assert.AreEqual("A",EncodingMessage ("Ana ?are Mer,e si?cate  nu are",4));
        }
        [TestMethod]
        public void TestCodLungime()
        {
            Assert.AreEqual("ana",EncodingMessage("ana", 3));
        }
        string BoundMessage(string message)
        {
            return message.Replace(" ", "").Replace("?", "").Replace("!", "")
                .Replace(",", "").Replace(".", "");
        }
        string AddCode(string message, int finalLength)
        {
            
            int i;
            for (i = message .Length ; message.Length < finalLength;i++)
                message = message + "a";
            return message;
        }
        char EncodingMessage(string message,int numberOfColumns)
        {
            string boundWords = BoundMessage(message);
            string codedMessage = "";
            double  lengthMessage = boundWords.Length;
            int numberOfRows = (int)Math.Ceiling(lengthMessage / numberOfColumns);
            string messageBefor = AddCode(boundWords, (numberOfColumns* numberOfRows));
            int i;
            for(i=1;i<=messageBefor.Length; i++)
            {
                codedMessage = codedMessage + messageBefor[i];
            }
            return messageBefor [1];
        }
    }
}
