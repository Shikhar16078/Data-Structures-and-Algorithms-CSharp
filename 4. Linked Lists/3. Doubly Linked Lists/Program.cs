namespace Doubly_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.AddLast(5);
            list1.AddLast(9);
            list1.AddLast(13);
            list1.AddLast(15);
            Console.WriteLine(list1);
            Console.WriteLine($"\nCurrent size of the linked list is {list1.Length()}.");
        }
    }
}
