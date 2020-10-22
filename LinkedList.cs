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
        
        internal Node sortList(Node head)
        {
             
            Node current = head, index = null;
            Node temp = head;

            if (head == null)
            {
                return head;
            }
            else
            {
                while (current != null)
                {
                    
                    index = current.next;

                    while (index != null)
                    {
                         
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp.data = current.data;
                            current.data = index.data;
                            index.data = temp.data;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
                return head;
            }
        }
    } 
}
