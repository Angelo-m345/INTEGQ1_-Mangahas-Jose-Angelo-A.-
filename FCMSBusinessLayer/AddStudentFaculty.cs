using FCMSDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FCMSBusinessLayer
{
    public class AddStudentFaculty
    {
        public static void AddStudent()
        {
            List<string> BSITs = new List<String>() { "Alfredson Brown     ",
                                                      "Rodrigo Gracio      ",
                                                      "Juan Miguel Castro  ",
                                                      "Gabriel Angelo Magno",
                                                      "Peterson Alvarado   ",
                                                      "Rita Manuela Santos ",
                                                      "Virgilio Vicente    ",
                                                      "Armando Bagatsing   "}; ;


           
            Console.WriteLine("Add Students");
            Console.WriteLine("===============");

            Console.WriteLine("How many students would you like to add?");
            int ITPlus = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ITPlus; i++)
            { 
            Console.WriteLine("Enter Student Name: ");
            string add = Console.ReadLine();
            BSITs.Add(add);
            }

            foreach (var Bsit in BSITs)
            {

                Console.WriteLine(Bsit);

            }

        }

        public static void AddFaculty()
        {
            List<string> BSCEs = new List<String>() { "Mr. Johnny Tayao",
                                                      "Mr. Alfred Bautista",
                                                      "Dr. Ellen Santiago",
                                                      "Ms. Juliana Monte",
                                                      "Ms. Darla Mae Cruz",
                                                      "Mr. Jonas Mendoza" }; ;



            Console.WriteLine("Add Faculty");
            Console.WriteLine("===============");

            Console.WriteLine("How many faculty would you like to add?");
            int ITPlus = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ITPlus; i++)
            { 
            Console.WriteLine("Enter Faculty Name: ");
            string add = Console.ReadLine();
            BSCEs.Add(add);
            }

            foreach (var Bsce in BSCEs)
            {

                Console.WriteLine(Bsce);

            }
        }
    }
}
