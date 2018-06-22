using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int data)
        {
            value = data;
            left = null;
            right = null;
        }
    }
}
