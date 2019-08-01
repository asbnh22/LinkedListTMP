using System;

namespace LinkedList
{

    public class Node<T> 
        where T : IComparable<T>

    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            Value = value;
        }

        public int CompareTo(T other)
        {
            if (other != null)
            {
                return this.Value.CompareTo(other);

            }
            else
            {
                return 1;
            }
        }

        public static bool operator <(Node<T> leftNode, Node<T> rightNode)
        {
            return leftNode.CompareTo(rightNode.Value) < 0;
        }

        public static bool operator >(Node<T> leftNode, Node<T> rightNode)
        {
            return leftNode.CompareTo(rightNode.Value) > 0;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
       
    }
}

