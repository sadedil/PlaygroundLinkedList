using System;

namespace PlaygroundLinkedList
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public void PrintList()
        {
            Node current = this.Head;
            while (current != null)
            {
                Console.Write(current.Data);
                Console.Write("->");
                current = current.Next;
            }

            Console.WriteLine("END");
        }

        public void IterativeReverseList()
        {
            Node temp = null;
            Node prev = null;
            Node current = this.Head;

            while (current != null)
            {
                temp = current.Next;
                current.Next = prev;

                prev = current;
                current = temp;
            }

            this.Head = prev;
        }

        public void RecursiveReverseList(Node currentNode)
        {
            if (currentNode is null)
                return;

            if (currentNode.Next is null)
            {
                this.Head = currentNode;
                return;
            }

            RecursiveReverseList(currentNode.Next);
            currentNode.Next.Next = currentNode;
            currentNode.Next = null;
        }

        public void RemoveItems(Func<int, bool> predicate)
        {
            Node prev = null;
            Node current = this.Head;
            while (current != null)
            {
                if (predicate(current.Data))
                {
                    if (prev == null)
                        this.Head = current.Next;
                    else
                        prev.Next = current.Next;
                }
                prev = current;
                current = current.Next;
            }
        }

        public LinkedList MergeWith(LinkedList other)
        {
            LinkedList result = new LinkedList();

            Node current1 = this.Head;
            Node current2 = other.Head;
            while (current1 != null && current2 != null)
            {
                //TODO: Maybe we can implement more effective way
                var smallOne = current1.Data <= current2.Data ? current1 : current2;
                var bigOne = smallOne.Equals(current1) ? current2 : current1;

                if (result.Head is null)
                    result.Head = smallOne;

                var sNext = smallOne.Next;
                var bNext = bigOne.Next;

                smallOne.Next = bigOne;
                if (sNext != null)
                    bigOne.Next = sNext;

                current1 = sNext;
                current2 = bNext;
            }

            return result;
        }
    }
}