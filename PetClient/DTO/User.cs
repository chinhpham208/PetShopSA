using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClient.DTO
{
    class User
    {
        public String USER { get; set; }="";
        public String PASS { get; set; }="";

        //public User(string uSER, string pASS)
        //{
        //    USER = uSER;
        //    PASS = pASS;
        //}
        private static string error = "Username does not exist!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(User user1, User user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.USER != user2.USER)
            {
                error = "Username does not exist!";
                return false;
            }

            else if (user1.PASS != user2.PASS)
            {
                error = "Username or password does not match!";
                return false;
            }

            return true;
        }
    }

}
