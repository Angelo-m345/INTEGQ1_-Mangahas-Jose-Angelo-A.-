using FCMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSBusinessLayer
{
    public class ViewStudentFaculty
    {
        public static void Student()


        {
            Console.WriteLine("==========Student Room Assignment==========");
            Console.WriteLine("===========================================");
            Console.WriteLine("Type C, I, or E");
            Console.WriteLine(" C - View BSCE-2 Students");
            Console.WriteLine(" I - View BSIT-2 Students");
            Console.WriteLine(" E - Exit");
            Console.Write("Type your Choice: ");
            char Student = Convert.ToChar(Console.ReadLine());
            Student = char.ToUpper(Student);

            switch (Student)
            {


                case 'C':
                    Console.WriteLine("==========BSCE 2 Students==========");
                    BSCEStudents.BSCE2Studentlist();
                    break;

                case 'I':
                    Console.WriteLine("==========BSIT 2 Students==========");
                    BSITStudents.BSIT2Studentlist();
                    break;

                case 'E':
                    Console.WriteLine("The App is Shutting Down, Thank You!");
                    break;
            }
        }
       
        public static void Faculty()

        {
            Console.WriteLine("==========Faculty Assignment==========");
            Console.WriteLine("======================================");
            Console.WriteLine("Select C, I, or E options");
            Console.WriteLine(" C - View BSCE Facilitators");
            Console.WriteLine(" I - View BSIT Facilitators");
            Console.WriteLine(" E - Exit");
            Console.Write("Type your Choice: ");
            char Faculty = Convert.ToChar(Console.ReadLine());
            Faculty = char.ToUpper(Faculty);


            switch (Faculty)
            {

                case 'C':
                    Console.WriteLine("==========BSCE 2 FACILITATORS==========");
                    BSCEFaculty.BSCEfacilitatorslist();
                    break;

                case 'I': 
                    Console.WriteLine("==========BSIT 2 FACILITATORS==========");
                    BSITFaculty.BSITfacilitatorslist();
                    break;

                case 'E':
                    Console.WriteLine("The app is Shutting Down, Thank You!");
                    break;
            }

        }
    }
}
