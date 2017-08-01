using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Node
    {
        public Node leftChild;
        public Node rightChild;
        public int number;

        public Node(int number)
        {
            this.number = number;
            rightChild = null;
            leftChild = null;
        }
        public Node InsertData(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (node.number > data)
            {
                node.leftChild = InsertData(node.leftChild, data);
            }
            else if (node.number < data)
            {
                node.rightChild = InsertData(node.rightChild, data);
            }
            return node;
        }

        public void Display(Node n)
        {
            if (n == null)
                return;

            Display(n.leftChild);
            Console.Write(n.number.ToString() + " ");
            Display(n.rightChild);
        }


    }
}
