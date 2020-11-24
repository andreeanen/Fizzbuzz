using Fizzbuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzbuzzTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ValidateIntegerInputTest()
        {
            //Arrange
            var program = new Program();
            //Act
            var expected = program.ValidateIntegerInput("12");
            int integerNumber = 12;
            //Assert
            Assert.AreEqual(integerNumber, expected);
        }

        [TestMethod]
        public void ValidateRangeInputTest()
        {
            //Arrange
            var program = new Program();
            //Act
            var expected = program.ValidateRangeInput(100);
            //Assert
            Assert.IsTrue(expected);
        }
    }


}
