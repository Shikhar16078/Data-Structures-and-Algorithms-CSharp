namespace Doubly_Linked_List
{
    // Node Class
    class Node
    {
        public Node previous;
        public int data;
        public Node next;

        public Node(Node previous, int data, Node next)
        {
            this.previous = previous;
            this.data = data;
            this.next = next;
        }
    }

    // Linked List Class
    internal class LinkedList
    {
        private Node ?head;
        private Node ?tail;
        public int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public LinkedList(int data)
        {
            Node node = new Node(null,data, null);
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

        public void AddFirst(int data)
        {
            Node newest = new Node(null, data, null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
                size = 1;
                return;
            }
            else
            {
                newest.next = head;
                head.previous = newest;
                head = newest;
                size++;
            }
        }

        public void Add(int data, int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid Size");
            }
            if (position == size)
            {
                AddLast(data);
                return;
            }
            else
            {
                Node iterator = head;
                Node newest = new Node(null, data, null);
                int counter = 1;
                while (counter < position - 1)
                {
                    iterator = iterator.next;
                    counter++;
                }

                newest.next = iterator.next;
                newest.next.previous = newest;
                iterator.next = newest;
                newest.previous = iterator;
                size++;
            }
        }

        public void AddLast(int data)
        {
            Node newest = new Node(null,data, null);
            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                newest.previous = tail;
                tail.next = newest;
            }
            tail = newest;
            size++;
        }

        public int DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty. Deletion cannot be performed.");
                return -1;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
                size = 0;
                return -1;
            }
            else
            {
                Node toDelete = head;
                head = head.next;
                head.previous = null;
                toDelete.next = null;
                size--;
                if (IsEmpty())
                {
                    head = null;
                    tail = null;
                }
                return toDelete.data;
            }
        }

        public int Delete(int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid position, deletion can not be performed.");
                return -1;
            }

            if (position == 1)
            {
                Console.WriteLine("Okay, You want to delete at head, sure...");
                return DeleteFirst();
            }

            if (position == size)
            {
                Console.WriteLine("So you want to delete the last element, sure...");
                return DeleteLast();
            }

            Node previous = head;

            int i = 1;
            while (i < position - 1)
            {
                previous = previous.next;
                i++;
            }

            Node toDelete = previous.next;
            previous.next = toDelete.next;
            toDelete.next.previous = previous;

            toDelete.next = null;
            toDelete.previous = null;
            size--;

            return toDelete.data;
        }

        public int DeleteLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty. Deletion cannot be performed.");
                return -1;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
                size = 0;
                return -1;
            }
            else
            {
                Node toDelete = head;

                tail = tail.previous;
                tail.next = null;

                size--;
                if (IsEmpty())
                {
                    tail = null;
                }
                return toDelete.data;
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
                result += "Head";

                while (p != null) {
                    result += $"-> {p.data} ";
                    p = p.next;
                }
            }
            Console.WriteLine(); 
            return result;
        }
    }
}
