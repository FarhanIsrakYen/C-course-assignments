using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    //class TreeOperations<T>:SupportingNode<T>
    class TreeOperations : SupportingNode
    {
        //public SupportingNode<T> root;
        public SupportingNode root;

        public TreeOperations()
        {
            root = null;
        }

        //public void InsertData(T nodeData)
        public void InsertData(int nodeData)
        {
            //SupportingNode<T> n = new SupportingNode<T>();
            //SupportingNode<T> crnt;
            //SupportingNode<T> parentNode;

            SupportingNode n = new SupportingNode();
            SupportingNode crnt;
            SupportingNode parentNode;

            n.data = nodeData;

            if (root == null)
            {
                root = n;
            }
            else
            {
                crnt = root;
                while(true)
                {
                    parentNode = crnt;
                    if(nodeData < crnt.data)
                    {
                        crnt = crnt.leftNode;
                        if (crnt == null)
                        {
                            parentNode.leftNode = n;
                            break;
                        }

                        else
                        {
                            crnt = crnt.rightNode;
                            if (crnt == null)
                            {
                                parentNode.rightNode = n;
                                break;
                            }
                        }
                    }
                }
            }

            
        }
    }
}
