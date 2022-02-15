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

        //TODO: Fix delete method
        public Node<T> Delete(T k) {
            var delNode = GetNode(k) as Node<T>;
            

            // Go the right child
            // Look till .Left is null == smallest node.
            Node<T> swapNode = null;
            Node<T> currentNode = delNode.Right;
            bool found = false;
            while (!found)
            {
                currentNode = currentNode.Left;
            }

            Console.WriteLine("Lowest found!" + swapNode.Key);

            return null;
        }
    }
}