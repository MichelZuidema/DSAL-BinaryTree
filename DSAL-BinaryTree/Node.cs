using System;

namespace DSAL_BinaryTree 
{
    public class Node<T> where T:IComparable
    {
        public T Key { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public void Insert(T k) 
        {
            if(k.CompareTo(this.Key) > 0) {
                // Move Right
                if (this.Right == null) {
                    this.Right = new Node<T>() { Key = k };
                } else {
                    this.Right.Insert(k);
                }
            } else if(k.CompareTo(this.Key) < 0) {
                // Move Left
                if(this.Left == null) {
                    this.Left = new Node<T>() { Key = k };
                } else {
                    this.Left.Insert(k);
                }
            }
        }

        public Node<T> GetNode(T k)
        {
            if (this.Key == null)
                return null;

            if(k.CompareTo(this.Key) > 0) {
                if(this.Right != null) {
                    return this.Right.GetNode(k);
                } else {
                    return null;
                }
            }
                

            if(k.CompareTo(this.Key) < 0)  {
                if(this.Left != null) {
                    return this.Left.GetNode(k);
                } else {
                    return null;
                }
            }

            return this;
        }

        public bool Search(T k)
        {
            if(this.Key == null)
                return false;

            if(k.CompareTo(this.Key) > 0) {
                if(this.Right != null) {
                    return this.Right.Search(k);
                } else {
                    return false;
                }
            }
                

            if(k.CompareTo(this.Key) < 0)  {
                if(this.Left != null) {
                    return this.Left.Search(k);
                } else {
                    return false;
                }
            }

            return true;
        }

        public Node<T> Delete(Node<T> root, T key)
        {
            if(!Search(key))
            {
                return null;
            }

            if (root == null)
            {
                return root;
            }
            else if (key.CompareTo(root.Key) < 0)
            {
                root.Left = root.Left.Delete(root.Left, key);
            }
            else if (key.CompareTo(root.Key) > 0)
            {
                root.Right = root.Right.Delete(root.Right, key);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    return null;
                } else if(root.Left == null)
                {
                    return root.Right;
                } else if(root.Right == null)
                {
                    return root.Left;
                } else
                {
                    Node<T> tempKey = root.Right.getMinimum(root.Right);
                    root.Key = tempKey.Key;
                    root.Right = root.Right.Delete(root.Right, tempKey.Key);
                }
            }

            return root;
        }

        private Node<T> getMinimum(Node<T> node)
        {
            if(node.Left != null)
            {
                return node.Left.getMinimum(node.Left);
            } else
            {
                return node;
            }
        }

        public void printAllNodes(Node<T> t)
        {
            if (t.Left != null)
            {
                t.Left.printAllNodes(t.Left);
            }

            Console.Write(" " + t.Key);

            if (t.Right != null)
            {
                t.Right.printAllNodes(t.Right);
            }
        }
    }
}