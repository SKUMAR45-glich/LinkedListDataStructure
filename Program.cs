using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            
            list.Add(70);

            list.PrintReverse(list.head);
            Console.WriteLine("\n");
            list.Display();
            Console.WriteLine("\n");

            Console.WriteLine("Enter position to enter");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Data to enter");
            int data = Convert.ToInt32(Console.ReadLine());

            list.InsertAtParticularPosition(pos, data);
            list.Display();
        }
    }
}
