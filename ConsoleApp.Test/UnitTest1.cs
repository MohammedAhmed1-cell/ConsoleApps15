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

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.feet = 5280;
            converter.CalculateMiles();
            double expectedDistance = 1;
            Assert.AreEqual(expectedDistance, converter.miles);

        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.miles = 1608.34;
            converter.CalculateMetres();
            double expectedDistance = 1;
            Assert.AreEqual(expectedDistance, converter.miles);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.feet = 1;
            converter.CalculateFeetToMetres();
            double expectedDistance = 3.28084;
            Assert.AreEqual(expectedDistance, converter.miles);
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.feet = 3.28084;
            converter.CalculateMetresToFeet();
            double expectedDistance = 1;
            Assert.AreEqual(expectedDistance, converter.miles);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.feet = 1;
            converter.CalculateMetresToMiles();
            double expectedDistance = 1608.34;
            Assert.AreEqual(expectedDistance, converter.miles);
        }


    }
}
