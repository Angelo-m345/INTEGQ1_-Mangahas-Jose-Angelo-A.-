using FCMSBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSUserInterface
{
    public class Menu
    {
        public static void menu ()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("==================");
            Console.WriteLine("Type A, B, C, D or E");
            Console.WriteLine("A - View Student");
            Console.WriteLine("B - View Faculty");
            Console.WriteLine("C - Add Student");
            Console.WriteLine("D - Add Faculty");
            Console.WriteLine("E - Exit"); 
            Console.Write("Type your choice: ");
            char FacultyoStudent = Convert.ToChar(Console.ReadLine());
            FacultyoStudent = char.ToUpper(FacultyoStudent);
          

            switch (FacultyoStudent)
            {
                case 'A':
                    ViewStudentFaculty.Student();
                    break;

                case 'B':
                    ViewStudentFaculty.Faculty();
                    break;

                case 'C':
                    AddStudentFaculty.AddStudent();
                    break;

                case 'D':
                    AddStudentFaculty.AddFaculty();
                    break;

                case 'E':
                    Console.WriteLine("The app is Shuting Down, Thank You!");
                    break;
            }
        }
    }
}
