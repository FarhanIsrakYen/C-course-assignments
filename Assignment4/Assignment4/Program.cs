using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeOperations op = new TreeOperations();

            op.InsertData(2);
            op.InsertData(3);
            op.InsertData(10);
            op.InsertData(6);
            op.Show();
        }
    }
}
