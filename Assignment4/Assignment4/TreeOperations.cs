using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    
    class TreeOperations<T>
    {
        public SupportingNode root { get; set; }
        public bool Insert( int input )
        {

            SupportingNode previous = null, crnt = this.root;

            while (crnt != null)
            {
                previous = crnt;
                if (input < crnt.data) 
                    crnt = crnt.leftNode;
                else if (input > crnt.data) 
                    crnt = crnt.rightNode;
                else
                {
                    return false;
                }
            }

            SupportingNode s = new SupportingNode();
            s.data = input;

            if (this.root == null)
                this.root = s;
            else
            {
                if (input < previous.data)
                    previous.leftNode = s;
                else
                    previous.rightNode = s;
            }

            return true;
        }


        public void TreeTraverse()
        {
            TreeTraverse(this.root);
            Console.WriteLine();
        }
        public void TreeTraverse(SupportingNode parent)
        {
            if (parent != null)
            {
                TreeTraverse(parent.leftNode);
                Console.Write($"{parent.data} ");
                TreeTraverse(parent.rightNode);
            }
        }
    }
}
