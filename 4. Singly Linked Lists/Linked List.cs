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

        public void AddFirst(int data)
        {
            Node n = new Node(data, null);
            if (IsEmpty())
            {
                head = n;
                tail = n;
                size = 1;
            }
            else
            {
                n.next = head;
                head = n;
                size++;
            }
        }

        public void Add(int data, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Size");
            }
            else
            {
                Node iterator = head;
                Node newest = new Node(data, null);
                int counter = 1;
                while (counter < position - 1)
                {
                    iterator = iterator.next;
                    counter++;
                }

                newest.next = iterator.next;
                iterator.next = newest;
                size++;
            }
        }

        public void AddLast(int data)
        {
            Node n = new Node(data, null);
            if (IsEmpty())
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
            size++;
        }

        public void InsertSorted(int data)
        {
            if (IsEmpty() || head.data > data)
            {
                AddFirst(data);
                return;
            }
            else if(tail.data < data)
            {
                AddLast(data);
                return;
            }
            else
            {
                Node n = new Node(data, null);
                Node iterator = head;
                while (iterator.next != null)
                {
                    if (iterator.data < data && iterator.next.data > data) {
                        n.next = iterator.next;
                        iterator.next = n;
                        size++;
                        return;
                    }
                    iterator = iterator.next;
                }
            }
        }

        public int DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty. Deletion cannot be performed.");
                return -1;
            }
            else
            {
                Node toDelete = head;
                head = head.next;
                size--;
                if (IsEmpty())
                {
                    tail = null;
                }
                return toDelete.data;
            }
        }

        public int Delete(int position)
        {
            if (position <=0 || position >= size)
            {
                Console.WriteLine("Invalid position, deletion can not be performed.");
                return -1;
            }

            if (position == 1)
            {
                Console.WriteLine("Okay, You want to delete at head, sure...");
                return DeleteFirst();
            }

            Node previous = head;
            Node toDelete = head;

            int i = 1;
            while(i < position - 1)
            {
                previous = previous.next;
                i++;
            }

            toDelete = previous.next;
            previous.next = previous.next.next;
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
            else
            {
                Node toDelete = head;
                Node previous = head;
                while (toDelete.next != null)
                {
                    previous = toDelete;
                    toDelete = toDelete.next;
                }

                previous.next = null;
                tail = previous;
                size--;
                if (IsEmpty())
                {
                    tail = null;
                }
                return toDelete.data;
            }
        }

        public int Search(int value)
        {
            Node iterator = head;
            int position = 1;
            while (iterator != null) {
                if (iterator.data == value)
                {
                    return position;
                }
                iterator = iterator.next;
                position++;
            }
            Console.WriteLine("Element not Found.");
            return -1;
        }

        // Reversing a Linked List
        public void Reverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty linked list can not be reversed.");
                return;
            }

            Node previous = null;
            Node current = head;

            while(current != null)
            {
                Node next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head = previous;
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
