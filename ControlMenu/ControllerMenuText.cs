using ProjektLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace zControlMenu
{
    public static class ControllerMenuText
    {

        public static string startmenutext()
        {
          string startext =  " press 1 to enter Admin " +
               "\n press 2 to enter Booking " +
               "\n press 3 to enter ClubInfo";

            return startext;
        }

        public static string option1text()
        {
            string option1 =
                "1. Tilføj: båd/event/blog/user/repair\r\n" +
                "2. Find: båd/event/blog/user/repair\r\n" +
                "3. Redigér: båd/event/blog/user/repair\r\n" +
                "4. Slet: båd/event/blog/user/repair\r\n ";

            return option1;
        }
        public static string option2text()
        {
         string option2 = "1.Se alle både\n" +
                            "2.Se Bookinger\n" +
                            "3.Se Bookinger på båd\n" +
                            "4.Lav booking\n" +
                            "5.Tilbage fra booking\n" +
                            "6.Andmeld reperation";

            return option2;
        }
        public static string option3text()
        {
            string option3 = "Klubinfo\r\n" +
                "1. Se medlemmer  \r\n" +
                "2. Bliv medlem\r\n" +
                "3. Se aktiviteter\r\n" +
                "4. Se blogposts\r\n" +
                "5. Se events\r\n";
            return option3;

            
        }
        public static string option1Type()
        {
            string theoption = "select 1 for boat \n " +
                                "select 2 for event \n " +
                                "select 3 for blog \n " +
                                "select 4 for user \n " +
                                "select 5 for repair \n " ;

            return theoption;
        }

    }
}
