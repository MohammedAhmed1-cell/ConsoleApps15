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

        public const double FEET_In_METRES = 3.28084;

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

        public void FeetToMetres()
        {
            OutputHeading("Feet to Metres");
            InputFeet();
            CalculateFeetToMetres();
            OutputFeetToMetres();
        }


        public void MetresToFeet()
        {
            OutputHeading("Metres to Feet");
            InputMetres();
            CalculateMetresToFeet();
            OutputMetresToFeet();
        }

        public void MetresToMiles()
        {
            OutputHeading("Metres to Miles");
            InputMetres();
            CalculateMetresToMiles();
            OutputMetresToMiles();
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

        private void CalculateFeetToMetres()
        {
            metres = feet / FEET_In_METRES;
        }

        private void CalculateMetresToFeet()
        {
            feet = metres * FEET_In_METRES;
        }

        private void CalculateMetresToMiles()
        {
            miles = metres / METRES_IN_MILES;
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
