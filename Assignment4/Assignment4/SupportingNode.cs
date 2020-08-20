using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
   class SupportingNode<T>
    {
        public T Data { get; set; }
        public SupportingNode<T> RightNode { get; set; }
        public SupportingNode<T> LeftNode { get; set; }

    }

}
