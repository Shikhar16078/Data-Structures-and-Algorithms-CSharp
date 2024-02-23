namespace CRUD_Linked_List
{
    // Node Class
    class Node
    {
        public int data;
        public Node next;

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    // Linked List Class
    internal class LinkedList
    {
        private Node head;
        private Node tail;
        public int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public LinkedList(int data)
        {
            Node node = new Node(data, null);
            head = node;
            tail = node;
            size = 1;
        }

        public int Length()
        {
            return size;
        }

        private bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(int data)
        {
            Node n = new Node(data, null);
            if (IsEmpty())
            {
                head = n;
                tail = n;
                size++;
            }
            else
            {
                tail.next = n;
                tail = n;
                size++;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (IsEmpty())
            {
                return "Linked List is Empty.";
            }
            else
            {
                Node p = head;
                while (p != null)
                {
                    result += $"-> {p.data} ";
                    p = p.next;
                }
            }
            Console.WriteLine();
            return result;
        }
    }
}
