using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    //class SupportingNode<T>
    //{
    //    public T data;

    //    public SupportingNode<T> rightNode;

    //    public SupportingNode<T> leftNode;

    //    public void Show()
    //    {
    //        Console.Write(data + " ");
    //    }
    //}

    class SupportingNode
    {
        public int data;

        public SupportingNode rightNode;

        public SupportingNode leftNode;

        public void Show()
        {
            Console.Write($"{ data } ");
        }
    }

}
