using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMSDataLayer
{
    public class BSCEFaculty
    {
        
        public static void BSCEfacilitatorslist()
        {
            List<string> BSCEs = new List<String>() { "Mr. Johnny Tayao    >Filipinolohiya         > TUESDAY 12:30pm - 3:30pm",
                                                      "Mr. Alfred Bautista >Programming 3          > TUESDAY 3:30pm - 6:30pm",
                                                      "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                                      "Ms. Juliana Monte   >Data Structures        > WEDNESDAY 2:00pm - 4:00pm",
                                                      "Ms. Darla Mae Cruz  >Discrete Mathematics   > FRIDAY 1:30pm - 3:30pm",
                                                      "Mr. Jonas Mendoza   >Physical Science       > FRIDAY 10:30am - 12:00pm"  }; ;



            foreach (string a in BSCEs)
            {
                Console.WriteLine(a);
            }
        }
    }
}
