using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class QueueUsingLinkList
    {
        Node head = null;

        /// Enqueues methode to add the specified data in queue 
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("\ninserted into queue " + node.data);
        }

        /// Displays this elements in queue
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
