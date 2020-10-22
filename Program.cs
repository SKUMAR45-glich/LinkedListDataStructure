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

            Console.WriteLine("After Entering element at requied position:\n");
            list.InsertAtParticularPosition(3, 40);
            list.Display();

        }
    }
}
