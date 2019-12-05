using consoleapp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Test
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestAdd()
        {
            int a = 2;
            int b = 3;
            int expectedResult = 5;
            int currentResult = 0;
            AditionBusiness additionBusiness = new AditionBusiness();

            currentResult = additionBusiness.Add(a,b);

            Assert.AreEqual(expectedResult, currentResult);


        }
    }
}
