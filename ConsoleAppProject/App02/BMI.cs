using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This a BMI converter for App 02 and i have added a public class for
    /// the height and weight which are in double numbers
    /// </summary>
    /// <author>
    /// Mohammed Ahmed
    /// </author>
    public class BMI
    {
        private double height;

        private double weight;

        /// <summary>
        /// Added a public class for Calc which will give the main parts of the
        /// BMI and the imperial and metric measurements and the health message
        /// </summary>
        public void Calc()
        {
            OutputHeader();
            double BMIIndex = 0;
            int Unit = GetUnits();
            if (Unit == 1) BMIIndex = CalcMetricBMI();
            else if (Unit == 2) BMIIndex = CalcImperialBMI();
            OutputHealthMessage(BMIIndex);
        }

        public void OutputHeader()
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------- ");
            Console.WriteLine("     BMI Calculator ");
            Console.WriteLine("     by Mohammed Ahmed           ");
            Console.WriteLine(" ------------------------------- ");
            Console.WriteLine();
        }

        private int GetUnits()
        {
            int unit = 0;
            Console.WriteLine("Enter Metric or Imperial > ");
            string value = Console.ReadLine();
            if (String.Equals(value, "metric")) unit = 1;
            else if (String.Equals(value, "imperial")) unit = 2;
            return unit;
        }

        private double CalcMetricBMI()
        {
            Console.Write("Please enter your height in metres > ");
            string value = Console.ReadLine();
            height = Convert.ToDouble(value);

            Console.Write("Please enter your weight in kg > ");
            value = Console.ReadLine();
            weight = Convert.ToDouble(value);

            double index = weight / (height * height);
            return index;
        }

        private void OutputHealthMessage(double BMIIndex)
        {
            Console.Write("Your BMI is > ");
            Console.WriteLine(BMIIndex);
            if (BMIIndex < 18.50) Console.WriteLine("You are underweight");
            else if (BMIIndex < 25) Console.WriteLine("You are normal");
            else if (BMIIndex < 30) Console.WriteLine("You are overweight");
            else if (BMIIndex < 35) Console.WriteLine("You are obese class 1");
            else if (BMIIndex < 40) Console.WriteLine("You are obese class 2");
            else Console.WriteLine("You are obese class 3");
        }


        private double CalcImperialBMI()
        {
            Console.Write("Please enter your height in inches > ");
            string value = Console.ReadLine();
            height = Convert.ToDouble(value);

            Console.Write("Please enter your weight in pounds > ");
            value = Console.ReadLine();
            weight = Convert.ToDouble(value);

            double index = weight * 703 / height;
            return index;
        }
    }

    
}
