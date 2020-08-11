using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class librarian : users
    {
        public int LibId { get; private set; }
        public string LibName { get; private set; }
        public string LibPassword { get; private set; }

        private int[] users = new int[10000];

        public int GetUserWithDue(int id)
        {

            return id;
        }

        public void SendNotifications(int id, int email)
        {

        }
    }
}
