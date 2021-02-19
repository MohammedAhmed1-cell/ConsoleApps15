using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace ConsoleApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.miles = 5;
            converter.CalculateFeet();
            double expectedDistance = 26400;
            Assert.AreEqual(expectedDistance, converter.feet);
        }
    }
}
