using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizzbuzz;
using System;
using System.IO;

namespace FizzbuzzTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void WriteInstructionTest()
        {
            var program = new Program();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                program.WriteInstruction("Instruction text.");

                var expected = string.Format($"Instruction text.{Environment.NewLine}");
                Assert.AreEqual(expected, sw.ToString());
            }
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
        public void PrintResultTest()
        {
            var program = new Program();

            Assert.IsTrue(program.PrintResult(402));
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
        public void CheckValue3Test()
        {
            var program = new Program();

            var expected = "Fizz";
            var actual = program.CheckValue(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValue5Test()
        {
            var program = new Program();

            var expected = "Buzz";
            var actual = program.CheckValue(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValue15Test()
        {
            var program = new Program();

            var expected = "Fizzbuzz";
            var actual = program.CheckValue(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckValue20Test()
        {
            var program = new Program();

            var expected = "22";
            var actual = program.CheckValue(22);

            Assert.AreEqual(expected, actual);
        }
    }
}
