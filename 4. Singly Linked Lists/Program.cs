using System;

namespace CRUD_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.AddLast(1);
            list1.AddLast(4);
            list1.AddLast(3);

            //Console.WriteLine($"Current size of the linked list is {list1.Length()}.");
            //// 1 4 3
            //Console.WriteLine(list1);

            //Console.WriteLine("\nInserting 10 at 2nd Position.");
            //list1.AddMiddle(10, 2);
            //// 1 10 4 3
            //Console.WriteLine(list1);
            //Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");

            //Console.WriteLine("\nInserting 30 at 3rd Position.");
            //list1.AddMiddle(30,3);

            //// 1 10 4 3 30
            //Console.WriteLine(list1);
            //Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");

            //Console.WriteLine("\nDeleting First Element");
            //list1.DeleteFirst();
            //Console.WriteLine(list1);
            //Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");

            //Console.WriteLine("\n\nProgram Finished");


            LinkedList list2 = new LinkedList();
            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);
            list2.AddLast(11);
            Console.WriteLine(list2);
            Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");

            list2.InsertSorted(8);
            Console.WriteLine(list2);
            list2.InsertSorted(7);
            Console.WriteLine(list2);
        }
    }
}
