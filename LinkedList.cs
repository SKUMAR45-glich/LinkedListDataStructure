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
        internal Node removeNode(Node head, int pos)
        {
            if (head == null)
                return null;

            Node temp = head;

            // If head needs to be removed 
            if (pos == 1)
            {

                // Change head 
                head = temp.next;
                return head;
            }

            // Find previous node of the node to be deleted 
            for (int i = 0; temp != null && i < pos;i++)
                temp = temp.next;

            // If position is more than number of nodes 
            if (temp == null || temp.next == null)
                return head;

            // Node temp->next is the node to be deleted 
            // Store pointer to the next of node to be deleted 
            Node next = temp.next.next;

            // Unlink the deleted node from list 
            temp.next = next;
            return head;
        }
    } 
}
