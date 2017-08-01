using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchTree
    {

        private Node root;
        private int count;
        public BinarySearchTree()
        {
            this.root = null;
            this.count = 0;

        }
        public int Count { get { return this.count; } }

        public bool IsEmpty()
        {
            return root == null;
        }
        public void Add(int d)
        {
            if (IsEmpty())
            {
                root = new Node(d);
            }
            else
            {
                root.InsertData(root, d);
            }
            this.count++;
        }
        public bool Search(int s)
        {
            return Search(root, s);
        }
        public void Display()
        {
            if (!IsEmpty())
            {
                root.Display(root);
            }

        }
        public bool Search(Node node, int s)
        {
            if (node == null)
                return false;
            if (node.number == s)
            {
                return true;
            }
            else if (node.number < s)
            {
                return Search(node.rightChild, s);
            }
            else if (node.number > s)
            {
                return Search(node.leftChild, s);
            }
            return false;
        }

    }
}
