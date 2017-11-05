using System.Diagnostics;

namespace PlaygroundLinkedList
{
    [DebuggerDisplay("{Data}, Next:{Next.Data}")]
    internal class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }
    }
}