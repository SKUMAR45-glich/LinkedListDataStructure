using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void PrintReverse(Node head)
        {
            
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            PrintReverse(head.next);
            Console.WriteLine(head.data + "");
            
        }

        
    }
}
