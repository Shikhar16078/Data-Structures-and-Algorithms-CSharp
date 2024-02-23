namespace CRUD_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList(9);
            list1.AddLast(1);
            list1.AddLast(4);
            list1.AddLast(3);
            Console.WriteLine($"Current size of the linked list is {list1.Length()}.");
            Console.WriteLine(list1);
            list1.AddLast(11);
            list1.AddLast(34);
            list1.AddLast(59);
            Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");
            Console.WriteLine(list1);
        }
    }
}
