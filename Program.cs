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
            list.Add(40);
            
            list.Add(70);

            list.Display();

            int pos = Convert.ToInt32(Console.ReadLine());
            
            list.sortList(list.head);
            list.Display();

        }
    }
}
