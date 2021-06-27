using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSDataLayer
{
    public class BSITStudents
    {
       
        public static void BSIT2Studentlist ()
        {
            List<string> BSITs = new List<String>() { "Alfredson Brown     ",
                                                      "Rodrigo Gracio      ",
                                                      "Juan Miguel Castro  ",
                                                      "Gabriel Angelo Magno",
                                                      "Peterson Alvarado   ",
                                                      "Rita Manuela Santos ",
                                                      "Virgilio Vicente    ",
                                                      "Armando Bagatsing   "}; ;
            foreach (string b in BSITs)
            {
                Console.WriteLine(b);
            }

           
        }
    }
}
