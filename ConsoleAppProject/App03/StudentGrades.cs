using ConsoleAppProject.Helpers;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;
using System.Data;
namespace ConsoleAppProject.App03
{
    /// <summary>
    /// I have created a class called student grades and i have comprised each part of the
    /// data table and their grade count
    /// </summary>
    public class StudentGrades
    {
        public DataTable students = new DataTable("Students");

        int[] GradeCount = new int[] { 0, 0, 0, 0, 0 };

        /// <summary>
        /// This is a public student table with all the information of the student details
        /// within colums when starting the program
        /// </summary>
        public void MakeStudentTable()
        {
            DataColumn column;
            //make id column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            students.Columns.Add(column);


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            column.AutoIncrement = false;
            column.Caption = "Name";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            students.Columns.Add(column);


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Biology Mark";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            students.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Physics Mark";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            students.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Chemistry Mark";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            students.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Grade";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            students.Columns.Add(column);
        }

        public void CreateColumn(string name)
        {
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "name";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            students.Columns.Add(column);
        }

        /// <summary>
        /// This is a error class so when i make an error when inputing a wrong number
        /// or anything else it will say enter the valid number.
        /// </summary>
        /// <returns></returns>
        private int ReadNumber()
        {
            bool Done = false;
            int n = 0;
            while(!Done)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    Done = true;
                    
                }
                catch
                {
                    Console.Write("Please enter valid number: ");
                }
            }
            return n;
        }

        /// <summary>
        /// I have made the the information of each student starting with their ID, Name,
        /// and subjects
        /// </summary>
        public void Grades()
        {
            
            double result, biology, physics, chemistry, total;
            double percentage;
            string name1, division;
            Console.Write("Enter student details : \n ");
            Console.Write("\n\n");

            result = ConsoleHelper.InputNumber("Student ID: ");
            
            Console.Write("Name of Student :");
            name1 = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Physics Score :");
            physics = ReadNumber();

            Console.Write("Enter Chemistry Score :");
            chemistry = ReadNumber();

            Console.Write("Enter Biology Score :");
            biology = ReadNumber();
            total = biology + chemistry + physics;
            percentage = total / 3;
            ///When calculating the results it will show what class they are in depending on thier grade/percentage
            if (percentage >= 70)
            {
                division = "First Class:";
                GradeCount[0] = GradeCount[0] + 1;
            }
            else
               if (percentage < 70 && percentage >= 60)
            {
                division = "Upper Second Class";
                GradeCount[1] = GradeCount[1] + 1;
            }
            else
               if (percentage < 60 && percentage >= 50)
            {
                division = "Lower Second Class";
                GradeCount[2] = GradeCount[2] + 1;
            }

            else
               if (percentage < 49 && percentage >= 40)
            {
                division = "Third Class";
                GradeCount[3] = GradeCount[3] + 1;
            }

            else
            {
                division = "Fail";
                GradeCount[4] = GradeCount[4] + 1;
            }

            Console.Write("\nRoll No : {0} \nName of Student : {1}\n", result, name1);
            Console.Write("Physics Marks :{0}\nChemistry Marks :{1}\nBiology Marks :{2}\n", physics, chemistry, biology);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, percentage, division);
            Console.ReadLine();

            ///This is a table for each of the information of each student when calculating alll the students it will be formed in a table
            DataRow row = students.NewRow();
            row["id"] = result;
            row["Name"] = name1;
            row["Biology Mark"] = biology;
            row["Physics Mark"] = physics;
            row["Chemistry Mark"] = chemistry;
            row["Grade"] = division;
            students.Rows.Add(row);
        }

        /// <summary>
        /// The class print students has been customed to the size of the table and its positioning when staing the application
        /// </summary>
        public void PrintStudents()
        {
            Console.Write("{0,-3}", "id");
            Console.Write("{0,-10}", "Name");
            Console.Write("{0,-5}", "Bio");
            Console.Write("{0,-5}", "Phys");
            Console.Write("{0,-5}", "Chem");
            Console.Write("{0,-10}", "Grade");
            Console.WriteLine();

            ///Coordinates for each row
            foreach (DataRow row in students.Rows)
            {
                Console.Write("{0,-3:D}",row["id"]);
                Console.Write("{0,-10}",row["Name"]);
                Console.Write("{0,-5:D}",row["Biology Mark"]);
                Console.Write("{0,-5:D}",row["Physics Mark"]);
                Console.Write("{0,-5:D}", row["Chemistry Mark"]);
                Console.Write("{0,-10}", row["Grade"]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This is just the code for calculating the maximum, minimum and mean mark of each student
        /// </summary>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public int[] CalculateStats(string ColumnName)
        {
            int[] Stats = new int[] { 100, 0, 0 };

            int length = 0;

            
            
            foreach (DataRow row in students.Rows)
            {
              if (Convert.ToInt32(row[ColumnName]) < Stats[0]) Stats[0] = Convert.ToInt32(row[ColumnName]);

              if (Convert.ToInt32(row[ColumnName]) > Stats[1]) Stats[1] = Convert.ToInt32(row[ColumnName]);

              Stats[2] = Stats[2] + Convert.ToInt32(row[ColumnName]);

              length = length + 1;
            }

            Stats[2] = Stats[2] / length;
            

            return Stats;
        }

        /// <summary>
        /// When filling in all the information it will show the class of the student and their overall grade for each subject
        /// </summary>
        /// <returns></returns>
        public double[] CalculateGradePercentage()
        {
            int total = GradeCount[0] + GradeCount[1] + GradeCount[2] + GradeCount[3] + GradeCount[4];
            double[] percentages = new double[5];
            percentages[0] = 100 * GradeCount[0] / total;
            percentages[1] = 100 * GradeCount[1] / total;
            percentages[2] = 100 * GradeCount[2] / total;
            percentages[3] = 100 * GradeCount[3] / total;
            percentages[4] = 100 * GradeCount[4] / total;

            return percentages;
        }
        

      

        
    }
}
