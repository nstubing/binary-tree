using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInarySearchTree
{
    class BinarySearchTree
    {
        public Node root;
        public int count;


        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Add(int number)
        {
            Node current = root;
            bool added = false;
            if (current == null)
            {
                root = new Node(number);
                count++;
            }
            while (added == false)
            {
                if (current.childLeft == null && number < current.nodeValue)
                {
                    current.childLeft = new Node(number);
                    added = true;
                    count++;
                }
                else if (current.childRight == null && number > current.nodeValue)
                {
                    current.childRight = new Node(number);
                    added = true;
                    count++;
                }
                else if (current.childLeft != null && number < current.nodeValue)
                {
                        current = current.childLeft;
                }
                else if (current.childRight != null && number > current.nodeValue)
                {
                    current = current.childRight;
                }
            }
        }


        public void Search(int number)
        {
            Node current = root;
            bool found = false;
            string foundPath = "I found "+number+" in the binary tree and it took a path of";
            for(int i = 0;(current.childLeft!=null || current.childRight!=null) && found==false;i++)
            {
                if(number==current.nodeValue)
                {
                    found = true;
                }
                else if ( number<current.nodeValue)
                {
                    current = current.childLeft;
                    foundPath += "  LEFT";
                }
                else if(number>current.nodeValue)
                {
                    current = current.childRight;
                    foundPath += "  RIGHT";
                }
            }
            if (found=true)
            {
                foundPath += ".";
                Console.WriteLine(foundPath);
            }
            else
            {
                Console.WriteLine("The binary tree did not have anything matching your result!");
            }
                
            


        }

    }
}
