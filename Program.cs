﻿using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            
            list.Add(70);

            list.Display();
            list.removeFirstNode(list.head);
            list.Display();

        }
    }
}
