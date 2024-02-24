using System;

namespace CRUD_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);

            // Reversing
            list1.Reverse();
            
            Console.WriteLine(list1);
            Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");
            Console.WriteLine("\n\nProgram Finished");

        }
    }
}
