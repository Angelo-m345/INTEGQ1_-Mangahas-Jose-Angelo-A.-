using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCMSDataLayer
{
    public class BSCEStudents
    {
      
        public static void BSCE2Studentlist ()
        {
            List<string> BSCEs = new List<String>() {"Ralph Talay     ",
                                                     "Francisco Reyes ",
                                                     "Rody Bartolome  ",
                                                     "Alyanna Romero  ",
                                                     "Robert Alarcon  ",
                                                     "Andrew Emerson  ",
                                                     "Joshua Vilanueva",
                                                     "Jason Batumbkal "};

            foreach (string b in BSCEs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
