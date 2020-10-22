using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    public class LinkedList
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

        public bool search(Node head, int x)
        {
            // Base case 
            if (head == null)
                return false;

           
            if (head.data == x)
                return true;

            // Recur for remaining list 
            return search(head.next, x);
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

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

    }
}
