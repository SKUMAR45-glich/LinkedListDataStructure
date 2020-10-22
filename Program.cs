using System;

namespace LinkedListDataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            
            list.Add(70);

            list.Display();

            Console.WriteLine("Node to be searched:");
            int key = Convert.ToInt32(Console.ReadLine());
            list.search(list.head,key);
            list.Display();

        }
    }
}
