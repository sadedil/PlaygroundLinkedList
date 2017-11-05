using System;
using System.Collections.Generic;
using System.Text;

namespace PlaygroundLinkedList
{
    internal class LinkedListHelper
    {
        public static LinkedList CreateSequentialList(int limit)
        {
            if (limit < 0)
                throw new ArgumentOutOfRangeException(nameof(limit));

            Random random = new Random((int)DateTime.Now.Ticks);

            LinkedList list = new LinkedList() { };
            Node current = null;
            for (int i = 0; i < limit; i++)
            {
                if (current == null)
                {
                    current = new Node() { Data = i + 1 };
                    list.Head = current;
                    continue;
                }
                current.Next = new Node() { Data = i + 1 };
                current = current.Next;
            }

            return list;
        }

        public static LinkedList CreateFormuledList(int limit, Func<int, int> formula)
        {
            if (limit < 0)
                throw new ArgumentOutOfRangeException(nameof(limit));

            Random random = new Random((int)DateTime.Now.Ticks);

            LinkedList list = new LinkedList() { };
            Node current = null;
            for (int i = 0; i < limit; i++)
            {
                if (current == null)
                {
                    current = new Node() { Data = formula(i) };
                    list.Head = current;
                    continue;
                }
                current.Next = new Node() { Data = formula(i) };
                current = current.Next;
            }

            return list;
        }
    }
}