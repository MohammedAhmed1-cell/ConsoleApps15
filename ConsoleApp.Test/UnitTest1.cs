using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using System;
using System.Data;

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
            converter.miles = 1.0;
            converter.CalculateMetres();
            double expectedDistance = 1608.34;
            Assert.AreEqual(expectedDistance, converter.metres);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.feet = 3.2;       
            converter.CalculateFeetToMetres();
            double expectedDistance = 1;
            Assert.AreEqual(expectedDistance, Math.Round(converter.metres, 1));
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.metres = 1.0;
            converter.CalculateMetresToFeet();
            double expectedDistance = 3.28084;
            Assert.AreEqual(expectedDistance, converter.feet);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.metres = 1608.34;
            converter.CalculateMetresToMiles();
            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.miles);
        }

        [TestMethod]
        public void TestMean()
        {
            StudentGrades grades = new StudentGrades();
          
            grades.MakeStudentTable();

            DataRow row = grades.students.NewRow();
            row["id"] = 1;
            row["Name"] = "Mohammed";
            row["Biology Mark"] = 67;
            row["Physics Mark"] = 78;
            row["Chemistry Mark"] = 70;
            row["Grade"] = "First Class";
            grades.students.Rows.Add(row);
        }


    }
}
