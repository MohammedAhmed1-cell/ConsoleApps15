using System;
using ConsoleAppProject.Helpers;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Mohammed Ahmed
    /// </summary>
    public static class Program
    {
        private static NetworkApp app04 = new NetworkApp();

        public static void App03Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

           StudentGrades game = new StudentGrades();
           game.MakeStudentTable();
           for (int i = 0; i < 10; i++)
           {
               game.Grades();
           }

           game.PrintStudents();
           int[] stats = game.CalculateStats("Biology Mark");
           Console.WriteLine("Minimum Biology Mark: " + stats[0]);
           Console.WriteLine("Maximum Biology Mark: " + stats[1]);
           Console.WriteLine("Mean Biology Mark: " + stats[2]);

           stats = game.CalculateStats("Chemistry Mark");
           Console.WriteLine("Minimum Chemistry Mark: " + stats[0]);
           Console.WriteLine("Maximum Chemistry Mark: " + stats[1]);
           Console.WriteLine("Mean Chemistry Mark: " + stats[2]);

           stats = game.CalculateStats("Physics Mark");
           Console.WriteLine("Minimum Physics Mark: " + stats[0]);
           Console.WriteLine("Maximum Physics Mark: " + stats[1]);
           Console.WriteLine("Mean Physics Mark: " + stats[2]);

           double[] GradePercentages = game.CalculateGradePercentage();
           Console.WriteLine("Percentage for First Class: " + GradePercentages[0]);
           Console.WriteLine("Percentage for Upper Second Class: " + GradePercentages[1]);
           Console.WriteLine("Percentage for Lower Second Class: " + GradePercentages[2]);
           Console.WriteLine("Percentage for Third Class: " + GradePercentages[3]);
           Console.WriteLine("Percentage for Fail: " + GradePercentages[4]);

        }

        public static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Black;

            NetworkApp game = new NetworkApp();
            game.DisplayMenu();



        }

    }
} 
