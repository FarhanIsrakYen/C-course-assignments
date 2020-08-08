using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Uid = Convert.ToInt32(Console.ReadLine());
            string Uname = Console.ReadLine();
            string Upasswprd = Console.ReadLine();
            if (UserIdentifier(Uname, Upasswprd, Uid) == "librarian")
            {
                librarian lib = new librarian();
            }
            else if (UserIdentifier(Uname, Upasswprd, Uid) == "secretary")
            {
                secretary sec = new secretary();
            }
            else
            {
                users user = new users(); 
            }
        }

        public static string UserIdentifier(String name, String password, int id) //suppose different users have differnt id but librarian and secretary have unique specifiqe id
        {
            if (id == 102244)
                return "librarian";
            else if (id == 103355)
                return "secretary";
            else
                return "user";
        }
    }

}
