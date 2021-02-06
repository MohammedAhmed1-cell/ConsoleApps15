using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Mohammed Ahmed version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// 
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Miles to feet");
            InputMiles();
            CaluculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Feet to Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading("Miles to Metres");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        

        public void OutputHeading(String header)
        {
            Console.WriteLine();
            Console.WriteLine(" ------------------------------- ");
            Console.WriteLine("     Convert " + header       );
            Console.WriteLine("     by Mohammed Ahmed           ");
            Console.WriteLine(" ------------------------------- ");
            Console.WriteLine();
        }

        /// <summary>
        ///  Prompt the user to enter the miles
        ///  Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }


        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CaluculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }






        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! ");
        }
    }




    
}
