using Fizzbuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace FizzbuzzTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ConsoleLogTest()
        {
            var program = new Program();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                program.ConsoleLog("Instruction text.");

                var expected = string.Format($"Instruction text.{Environment.NewLine}");
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void IsZeroTrueTest()
        {
            var program = new Program();
            var actual = program.IsZero(0);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsZeroFalseTest()
        {
            var program = new Program();
            var actual = program.IsZero(10);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ReadInputTest()
        {
            var program = new Program();

            using (StringReader sr = new StringReader("10"))
            {
                Console.SetIn(sr);
                string input = sr.ReadLine();

                program.ReadInput();

                var expected = string.Format("10");
                Assert.AreEqual(expected, input);
            }
        }


        [TestMethod]
        public void CheckOutputNoIntegerTest()
        {
            var program = new Program();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                program.CheckOutput("asf");

                var expected = string.Format($"Invalid input.{Environment.NewLine}");
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void CheckOutputIntegerTest()
        {
            var program = new Program();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                program.CheckOutput("3");

                var expected = string.Format($"1{Environment.NewLine}2{Environment.NewLine}Fizz{Environment.NewLine}");
                Assert.AreEqual(expected, sw.ToString());
            }
        }

       
        [TestMethod]
        public void RunFizzbuzzCheckTest()
        {
            var program = new Program();

            Assert.IsTrue(program.RunFizzbuzzCheck(402));
        }

        [TestMethod]
        public void CheckValue42Test()
        {
            var program = new Program();

            var expected = "Answer to the Ultimate Question of Life, the Universe, and Everything";
            var actual = program.CheckValue(42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValueFizzTest()
        {
            var program = new Program();

            var expected = "Fizz";
            var actual = program.CheckValue(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValueBuzzTest()
        {
            var program = new Program();

            var expected = "Buzz";
            var actual = program.CheckValue(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValueFizzbuzzTest()
        {
            var program = new Program();

            var expected = "Fizzbuzz";
            var actual = program.CheckValue(15);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckValueAny()
        {
            var program = new Program();

            var expected = "22";
            var actual = program.CheckValue(22);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateIntegerInputTest()
        {
            var program = new Program();

            var expected = program.ValidateIntegerInput("12");
            int integerNumber = 12;

            Assert.AreEqual(integerNumber, expected);
        }

        [TestMethod]
        public void ValidateInteger0InputTest()
        {
            var program = new Program();

            var expected = program.ValidateIntegerInput("hej");
            int integerNumber = 0;

            Assert.AreEqual(integerNumber, expected);
        }

        [TestMethod]
        public void ValidateRangeInputTrueTest()
        {
            var program = new Program();

            var expected = program.ValidateRangeInput(100);

            Assert.IsTrue(expected);
        }
     
        [TestMethod]
        public void ValidateRangeInputFalseTest()
        {
            var program = new Program();

            var result = program.ValidateRangeInput(900);

            Assert.IsFalse(result);
        }

    }
}
