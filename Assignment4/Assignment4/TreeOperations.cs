using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment4
{
   
    //class TreeOperations
    class TreeOperations<T> where T : IComparable
    {
        public SupportingNode<T> Root { get; set; }
        public void Insert( T input )
        {
            //SupportingNode previous = null, current = this.Root;
            SupportingNode<T> previous = null, current = this.Root;
            while (current != null)
            {
                previous = current;
                if (input.CompareTo(previous.Data) <= 0)
                    current = current.LeftNode;
                else
                    current = current.RightNode;
            }
            //SupportingNode support = new SupportingNode();
            SupportingNode<T> support = new SupportingNode<T>
            {
                Data = input
            };
            if (this.Root == null)
                this.Root = support;
            else      
                if (input.CompareTo(previous.Data) <= 0)
                    previous.LeftNode = support;
                else
                    previous.RightNode = support;
        }
        public void TreeTraverse()
        {
            TreeTraverse(this.Root);
            Console.WriteLine();
        }
        //public void TreeTraverse(SupportingNode parent)
        public void TreeTraverse(SupportingNode<T> parent)
        {
            if (parent != null)
            {
                TreeTraverse(parent.LeftNode);
                Console.Write($"{parent.Data} ");
                TreeTraverse(parent.RightNode);
            }
        }
        //public int Minimum(SupportingNode node)
        public T Minimum(SupportingNode<T> node)
        {
            T min = node.Data;
            while(node.LeftNode != null)
            {
                min = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return min;
        }
        //public SupportingNode Delete(SupportingNode parent, int key)
        public SupportingNode<T> Delete(SupportingNode<T> parent, T key)
        {
            if (parent == null)
                return parent;
            if (key.CompareTo(parent.Data) < 0)
                parent.LeftNode = Delete(parent.LeftNode, key);
            else if (key.CompareTo(parent.Data) > 0)
                parent.RightNode = Delete(parent.RightNode, key);
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;
                parent.Data = Minimum(parent.RightNode);                
                parent.RightNode = Delete(parent.RightNode, parent.Data);
            }
            return parent;
        }
        public void Delete(T input)
        {
            this.Root = Delete(this.Root, input);
        }
    }
}
