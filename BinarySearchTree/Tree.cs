using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree
    {
        public Node root;
        public Tree()
        {
            this.root = null;
        }
        

        public void Add(int data)
        {
            Node nodeToAdd = new Node(data);

            if (root == null)
            {
                root = nodeToAdd;
            }
            else
            {
                Node currentNode = CheckNode(nodeToAdd.value);

                if (nodeToAdd.value < currentNode.value)
                {

                    currentNode.left = nodeToAdd;
                }
                else
                {
                    currentNode.right = nodeToAdd;
                }
            }
        }

        public Node CheckNode(int data)
        {
            Node currentNode = root;
            while (currentNode.left != null && currentNode.right != null)
            {
                if (data < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (data > currentNode.value)
                {
                    currentNode = currentNode.right;
                }

            }
            return currentNode;
        }

        public string Search(int value)
        {
            string results = "found at: ";
            Node currentNode = root;
            bool found = false;
            if (currentNode == null)
            {
                return("no root found");
            }
            while (currentNode.left != null || currentNode.right != null)
            {
                if (value > currentNode.value)
                {
                    results += "right,";
                    currentNode = currentNode.right;

                }
                else if (value < currentNode.value)
                {
                    results += "left,";
                    currentNode = currentNode.left;
                }
            }
            
            if (value == currentNode.value)
            {
                if (results == "")
                {
                    results = "Root";
                }
                found = true;
                return (results);
            }
            if (found != true)
            {
                results = "not found";
            }
            return (results);
        }
    }
}
