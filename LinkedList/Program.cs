using System;
using LinkedList.LinkedList;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.AddFirst(11);
            list.AddFirst(7);
            list.AddFirst(5);
            list.AddFirst(3);
            list.AddFirst(1);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            list.DeleteFirst();

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            Console.WriteLine(list.GetHead());
            Console.WriteLine();

            int[] tail;
            tail = list.GetTail();
            foreach (int i in tail)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            list.AddInSorted(6);
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine(list.IsSorted().ToString());


            Console.ReadLine();
        }
    }
}
