using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class TreeOperations<T>
    {
        public SupportingNode<T> Root { get; set; }
        public void Insert( T input )
        {
            SupportingNode<T> previous = null, current = this.Root;
            while (current != null)
            {
                previous = current;
                if (input <= current.Data)
                    current = current.LeftNode;
                else if (input > current.Data)
                    current = current.RightNode;                
            }
            SupportingNode<T> support = new SupportingNode<T>();
            support.Data = input;
            if (this.Root == null)
                this.Root = support;
            else
                if (input <= previous.Data)
                    previous.LeftNode = support;
                else
                    previous.RightNode = support;      
        }
        public void TreeTraverse()
        {
            TreeTraverse(this.Root);
            Console.WriteLine();
        }
        public void TreeTraverse(SupportingNode<T> parent)
        {
            if (parent != null)
            {
                TreeTraverse(parent.LeftNode);
                Console.Write($"{parent.Data} ");
                TreeTraverse(parent.RightNode);
            }
        }
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

        public SupportingNode<T> Delete(SupportingNode<T> parent, T key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key < parent.Data)
            {
                parent.LeftNode = Delete(parent.LeftNode, key);
            }
            else if (key > parent.Data)
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
