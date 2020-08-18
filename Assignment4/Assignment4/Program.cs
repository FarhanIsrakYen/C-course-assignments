using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeOperations<int> op = new TreeOperations<int>();

            op.Insert(1);
            op.Insert(2);
            op.Insert(7);
            op.Insert(3);
            op.Insert(10);
            op.Insert(5); 
            op.Insert(8);
            op.TreeTraverse();
        }
    }
}
