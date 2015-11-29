using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Read1ShouldReturnOne()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(1);

            Assert.AreEqual("eins", result);
        }

        [TestMethod]
        public void Read2ShouldReturnTwo()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(2);

            Assert.AreEqual("zwei", result);
        }


        [TestMethod]
        public void Read3ShouldReturnThree()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(3);

            Assert.AreEqual("drei", result);
        }

        [TestMethod]
        public void Read9ShouldReturnNine()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(9);

            Assert.AreEqual("neun", result);
        }

        [TestMethod]
        public void Read12ShouldReturnNTwelfe()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(12);

            Assert.AreEqual("zwölf", result);
        }

        [TestMethod]
        public void Read20ShouldReturnZwanzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(20);

            Assert.AreEqual("zwanzig", result);
        }

        [TestMethod]
        public void Read14ShouldReturnVierZehn()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(14);

            Assert.AreEqual("vierzehn", result);
        }

        [TestMethod]
        public void Read21ShouldReturnEinundzwanzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(21);

            Assert.AreEqual("einundzwanzig", result);
        }

        [TestMethod]
        public void Read31ShouldReturnEinunddreißig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(31);

            Assert.AreEqual("einunddreißig", result);
        }

        [TestMethod]
        public void Read50ShouldReturnfünfzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(50);

            Assert.AreEqual("fünfzig", result);
        }

        [TestMethod]
        public void Read100ShouldReturneinhundert()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(100);

            Assert.AreEqual("einhundert", result);


        }

        [TestMethod]
        public void Read102ShouldReturneinhundertwei()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(102);

            Assert.AreEqual("einhundertzwei", result);
        }

        [TestMethod]
        public void Read763ShouldReturnsiebenhundertdreiundsechzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(763);

            Assert.AreEqual("siebenhundertdreiundsechzig", result);
        }

        [TestMethod]
        public void Read1000ShouldReturnEintausend()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(1000);

            Assert.AreEqual("eintausend", result);
        }

        [TestMethod]
        public void Read4000ShouldReturnViertausend()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(4000);

            Assert.AreEqual("viertausend", result);
        }

        [TestMethod]
        public void Read10000ShouldReturnZehntausend()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(10000);

            Assert.AreEqual("zehntausend", result);
        }

        [TestMethod]
        public void Read1111ShouldReturnEintausendeinhundertelf()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(1111);

            Assert.AreEqual("eintausendeinhundertelf", result);
        }

        [TestMethod]
        public void Read764ShouldReturnSiebenhundertvierundsechzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(764);

            Assert.AreEqual("siebenhundertvierundsechzig", result);
        }

        [TestMethod]
        public void Read1213ShouldReturnEinausendzweihundertdreizehn()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(1213);

            Assert.AreEqual("eintausendzweihundertdreizehn", result);
        }

        [TestMethod]
        public void Read9999ShouldReturnNeuntausendneunhundertneunundneunzig()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(9999);

            Assert.AreEqual("neuntausendneunhundertneunundneunzig", result);
        }

        [TestMethod]
        public void Rea10000ShouldReturnZehntausend()
        {
            var numberConverter = new NumberConverter();

            string result = numberConverter.Convert(10000);

            Assert.AreEqual("zehntausend", result);
        }
    }
}
