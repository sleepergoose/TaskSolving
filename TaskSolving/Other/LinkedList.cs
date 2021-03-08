using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.Other
{
    public partial class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(Node head)
        {
            int counter = 0;
            Node crowler = head;
            while (crowler != null)
            {
                counter++;
                crowler = crowler.Next;
            }
            return counter;
        }

        public static int Count(Node head, Predicate<int> func)
        {
            int counter = 0;
            Node crowler = head;
            while (crowler != null)
            {
                if (func(crowler.Data))
                    counter++;
                crowler = crowler.Next;
            }
            return counter;
        }
    }
}
