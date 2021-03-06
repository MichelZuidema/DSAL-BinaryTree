using System;

namespace DSAL_BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node<int>() { Key = 100 };
            tree.Insert(52);
            tree.Insert(303);
            tree.Insert(19);
            tree.Insert(76);
            tree.Insert(310);
            tree.Insert(88);
            tree.Insert(276);
            tree.Insert(7);
            tree.Insert(11);

            tree.printAllNodes(tree);

            tree.Delete(tree, 321321);

            Console.WriteLine();
            tree.printAllNodes(tree);

            Console.WriteLine();
        }
    }
}
