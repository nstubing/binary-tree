using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.Add(100);
            myTree.Add(120);
            myTree.Add(86);
            myTree.Add(75);
            myTree.Add(65);
            myTree.Add(115);
            myTree.Add(145);
            myTree.Add(176);
            myTree.Add(73);

            myTree.Search(115);
        }
    }
}
