using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a public class for the distance converter with public and
    /// private variables that will be shown when running the terminal
    /// </summary>
    /// <author>
    /// Mohammed Ahmed version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_In_METRES = 3.28084;

        public double miles;

        public double feet;

        public double metres;

        /// <summary>
        /// These public classes are for the conversions for the distance
        /// converter when you run the program.
        /// miles to feet
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Miles to feet");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Feet to Miles
        /// </summary>
        public void FeetToMiles()
        {
            OutputHeading("Feet to Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        /// <summary>
        /// Miles to Metres
        /// </summary>
        public void MilesToMetres()
        {
            OutputHeading("Miles to Metres");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        /// <summary>
        /// Feet to Metres
        /// </summary>
        public void FeetToMetres()
        {
            OutputHeading("Feet to Metres");
            InputFeet();
            CalculateFeetToMetres();
            OutputFeetToMetres();
        }

        /// <summary>
        /// Metres to Feet
        /// </summary>
        public void MetresToFeet()
        {
            OutputHeading("Metres to Feet");
            InputMetres();
            CalculateMetresToFeet();
            OutputMetresToFeet();
        }

        /// <summary>
        /// Metres to Miles
        /// </summary>
        public void MetresToMiles()
        {
            OutputHeading("Metres to Miles");
            InputMetres();
            CalculateMetresToMiles();
            OutputMetresToMiles();
        }

        /// <summary>
        /// This is the output header for when running the program it will
        /// display this message.
        /// </summary>
        /// <param name="header"></param>
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
        public void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Tells the user how many metres as a double number
        /// </summary>
        public void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        /// <summary>
        /// Prompts the user to enter how many feet as a double number
        /// </summary>
        public void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// When you enter the numbers, these private void classes will
        /// calculate the conversion
        /// </summary>
        public void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        public void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        public void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        public void CalculateFeetToMetres()
        {
            metres = feet / FEET_In_METRES;
        }

        public void CalculateMetresToFeet()
        {
            feet = metres * FEET_In_METRES;
        }

        public void CalculateMetresToMiles()
        {
            miles = metres / METRES_IN_MILES;
        }






        /// <summary>
        /// When staring the program it will tell you how many for metres, feet
        /// etc...
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

        private void OutputMetresToMiles()
        {
            Console.WriteLine(metres + " metres is " + miles + " miles! ");
        }

        private void OutputMetresToFeet()
        {
            Console.WriteLine(metres + " metres is " + feet + " feet! ");
        }

        private void OutputFeetToMetres()
        {
            Console.WriteLine(feet + " feet is " + metres + " metres ");
        }


        /// <summary>
        /// This will give the user specfic numbers to input because it is
        /// a private class, e.g. input 1 and will give you the conversion or
        /// else input 2 or 3
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private int InputUnits(String prompt)
        {
            int unit = 0;
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            if (String.Equals(value, "feet")) unit = 1;
            else if (String.Equals(value, "miles")) unit = 2;
            else if (String.Equals(value, "metres")) unit = 3;
            return unit;
        }

        /// <summary>
        /// This code is to make the text of the program much understandable, e.g.
        /// it will ask the conversion that you want to enter.
        /// </summary>
        public void Converter()
        {
            OutputHeading("feet, miles and metres");
            int FromUnits = 0;
            int ToUnits = 0;
            FromUnits = InputUnits("What units to convert from > ");
            ToUnits = InputUnits("What units to convert to > ");
            if ((FromUnits == 1) && (ToUnits == 2)) FeetToMiles();
            else if ((FromUnits == 1) && (ToUnits == 3))FeetToMetres();
            else if ((FromUnits == 2) && (ToUnits == 1)) MilesToFeet();
            else if ((FromUnits == 2) && (ToUnits == 3)) MilesToMetres();
            else if ((FromUnits == 3) && (ToUnits == 1)) MetresToFeet();
            else if ((FromUnits == 3) && (ToUnits == 2)) MetresToMiles();
            

        }
    }




    
}
