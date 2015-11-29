using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Core;
using System.Collections.Generic;

namespace Logic.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Convert_Method_Returns_Not_An_Empty_Or_Null_String()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(0);

            // Assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void Convert_Zero_Returns_String_Null()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(0);

            // Assert
            Assert.AreEqual("null", result);
        }

        [TestMethod]
        public void Convert_One_Returns_String_Eins()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(1);

            // Assert
            Assert.AreEqual("eins", result);
        }

        [TestMethod]
        public void Convert_Is_Able_To_Convert_From_Zero_To_Nineteen()
        {
            // Arrange
            Dictionary<int, string> entries = new Dictionary<int, string>()
            {
                { 0, "null" },
                { 1, "eins" },
                { 2, "zwei" },
                { 3, "drei" },
                { 4, "vier" },
                { 5, "fünf" },
                { 6, "sechs" },
                { 7, "sieben" },
                { 8, "acht" },
                { 9, "neun" },
                { 10, "zehn" },
                { 11, "elf" },
                { 12, "zwölf" },
                { 13, "dreizehn" },
                { 14, "vierzehn" },
                { 15, "fünfzehn" },
                { 16, "sechzehn" },
                { 17, "siebzehn" },
                { 18, "achtzehn" },
                { 19, "neunzehn" },
            };

            NumberConverter target = new NumberConverter();

            foreach (var entry in entries)
            {
                // Act
                var result = target.Convert(entry.Key);

                // Assert
                Assert.AreEqual(entry.Value, result);
            }
        }

        [TestMethod]
        public void Convert_Is_Able_To_Convert_Twenty_To_TwentyNine()
        {
            // Arrange
            Dictionary<int, string> entries = new Dictionary<int, string>()
            {
                { 20, "zwanzig" },
                { 21, "ein und zwanzig" },
                { 22, "zwei und zwanzig" },
                { 23, "drei und zwanzig" },
                { 24, "vier und zwanzig" },
                { 25, "fünf und zwanzig" },
                { 26, "sechs und zwanzig" },
                { 27, "sieben und zwanzig" },
                { 28, "acht und zwanzig" },
                { 29, "neun und zwanzig" },
            };

            NumberConverter target = new NumberConverter();

            foreach (var entry in entries)
            {
                // Act
                var result = target.Convert(entry.Key);

                // Assert
                Assert.AreEqual(entry.Value, result);
            }
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_Twenty_To_Ninety()
        {
            // Arrange
            Dictionary<int, string> entries = new Dictionary<int, string>()
            {
                { 20, "zwanzig" },
                { 30, "dreißig" },
                { 40, "vierzig" },
                { 50, "fünfzig" },
                { 60, "sechzig" },
                { 70, "siebzig" },
                { 80, "achtzig" },
                { 90, "neunzig" },
            };

            NumberConverter target = new NumberConverter();

            foreach (var entry in entries)
            {
                // Act
                var result = target.Convert(entry.Key);

                // Assert
                Assert.AreEqual(entry.Value, result); 
            }
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_981()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(981);

            // Assert
            Assert.AreEqual("neun hundert ein und achtzig", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_116()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(116);

            // Assert
            Assert.AreEqual("ein hundert sechzehn", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_999()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(999);

            // Assert
            Assert.AreEqual("neun hundert neun und neunzig", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_One_Thousand()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(1000);

            // Assert
            Assert.AreEqual("ein tausend", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_1234()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(1234);

            // Assert
            Assert.AreEqual("ein tausend zwei hundert vier und dreißig", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_1234567()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(1234567);

            // Assert
            Assert.AreEqual("eine million zwei hundert vier und dreißig tausend fünf hundert sieben und sechzig", result);
        }

        [TestMethod]
        public void Convert_Produces_Proper_Output_For_1234567890()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var result = target.Convert(1234567890);

            // Assert
            Assert.AreEqual("eine milliarde zwei hundert vier und dreißig millionen fünf hundert sieben und sechzig tausend acht hundert neunzig", result);
        }

        [TestMethod]
        public void Ensure_Proper_Endings()
        {
            // Arrange
            NumberConverter target = new NumberConverter();

            // Act
            var resultMillionSingular = target.Convert(1000000);
            var resultMillionPlural = target.Convert(2000000);

            var resultBillionSingular = target.Convert(1000000000);
            var resultBillionPlural = target.Convert(2000000000);

            // Assert
            Assert.IsTrue(resultMillionSingular.EndsWith("million"));
            Assert.IsTrue(resultMillionPlural.EndsWith("millionen"));

            Assert.IsTrue(resultBillionSingular.EndsWith("milliarde"));
            Assert.IsTrue(resultBillionPlural.EndsWith("milliarden"));
        }
    }
}
