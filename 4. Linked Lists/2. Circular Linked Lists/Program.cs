namespace CRUD_Circular_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast(8);
            list1.AddFirst(1);
            Console.WriteLine(list1);
            Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");
        }
    }
}
