using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    namespace LinkedList
    {
        public class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
        {
            private Node<T> head = null;
            private Node<T> tail = null;

            private int count = 0;

            /// <summary>
            /// Add item to top of list.
            /// </summary>
            /// <param name="value"> Value to add. </param>
            public void AddFirst(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                var item = new Node<T>(value);
                if (head == null)
                {
                    head = tail = item;
                }
                else
                {
                    tail = head;
                    item.Next = tail;
                    head = item;
                }
                count++;
            }

            /// <summary>
            /// Delete first item from Linked List.
            /// </summary>
            public void DeleteFirst()
            {
                if (head == null)
                {
                    throw new ArgumentNullException();
                }
                if (count == 1)
                {
                    head = tail = null;
                }
                head = tail;
                tail = tail.Next;
                count--;
            }

            /// <summary>
            /// Get first item from Linked List.
            /// </summary>
            public T GetHead()
            {
                if (head == null)
                {
                    throw new ArgumentNullException();
                }
                return head.Value;
            }

            /// <summary>
            /// Get tail from Linked List.
            /// </summary>
            public T[] GetTail()
            {
                Node<T> node = tail;
                if (node != null)
                {
                    T[] answer = new T[count - 1];
                    for (int i = 0; i < count - 1; i++)
                    {
                        answer[i] = node.Value;
                        node = node.Next;
                    }
                    return answer;
                }
                else
                {
                    return new T[] { };
                }

            }

            public bool IsSorted()
            {
                if (head == null)
                {
                    throw new ArgumentNullException();
                }

                Node<T> LeftNode = head;
                Node<T> RightNode = head.Next;

                while (RightNode != null)
                {
                    if (LeftNode > RightNode)
                    {
                        return false;
                    }
                    LeftNode = RightNode;
                    RightNode = LeftNode.Next;
                }
                return true;
            }

            /*public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }*/
           
            public IEnumerator<T> GetEnumerator()
            {
                var current = head;
                while (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
            }
            
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }
        }
    }
}
