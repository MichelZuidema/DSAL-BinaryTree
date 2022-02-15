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
            if(this.Key.CompareTo(k) > 0) {
                // Move Right
                if (this.Right == null) {
                    this.Right = new Node<T>() { Key = k };
                } else {
                    this.Right.Insert(k);
                }
            } else if(this.Key.CompareTo(k) < 0) {
                // Move Left
                if(this.Left == null) {
                    this.Left = new Node<T>() { Key = k };
                } else {
                    this.Left.Insert(k);
                }
            }
        }

        public T GetNode(T k)
        {
            if(this.Key == null)
                return default(T);

            if(this.Key.CompareTo(k) > 0) {
                if(this.Right != null) {
                    return this.Right.GetNode(k);
                } else {
                    return default(T);
                }
            }
                

            if(this.Key.CompareTo(k) < 0)  {
                if(this.Left != null) {
                    return this.Left.GetNode(k);
                } else {
                    return default(T);
                }
            }

            return k;
        }

        public bool Search(T k)
        {
            if(this.Key == null)
                return false;

            if(this.Key.CompareTo(k) > 0) {
                if(this.Right != null) {
                    return this.Right.Search(k);
                } else {
                    return false;
                }
            }
                

            if(this.Key.CompareTo(k) < 0)  {
                if(this.Left != null) {
                    return this.Left.Search(k);
                } else {
                    return false;
                }
            }

            return true;
        }

        public void Delete(T k) {
            Node<T> delNode = GetNode(k);



            // Go the right chuld
            // Look till .Left is null == smallest node.
        }
    }
}