namespace Binary_Search_Tree
{
    class Node
    {
        public Node? left;
        public int data;
        public Node? right;

        public Node(Node? left, int value, Node? right)
        {
            this.left = left;
            data = value;
            this.right = right;
        }
    }

    internal class BinarySearchTree
    {
        public Node? root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertIterative(Node? passedRoot, int value)
        {
            Node? parentInsertPosition = null;
            while (passedRoot != null)
            {
                parentInsertPosition = passedRoot;
                if (passedRoot.data == value)
                {
                    Console.WriteLine("The value is alread present in the tree. Can not insert duplicate value.");
                    return;
                }
                else if (passedRoot.data > value)
                {
                    passedRoot = passedRoot.left;
                }
                else if (passedRoot.data < value)
                {
                    passedRoot = passedRoot.right;
                }
            }

            Node newestNode = new Node(null, value, null);
            if (root != null)
            {
                if (parentInsertPosition.data > value)
                {
                    parentInsertPosition.left = newestNode;
                }
                else
                {
                    parentInsertPosition.right = newestNode;
                }
            }
            else
            {
                root = newestNode;
            }
        }

        public Node InsertRecursive(Node? passedRoot, int value)
        {
            if (passedRoot != null)
            {
                if (passedRoot.data > value)
                {
                    passedRoot.left = InsertRecursive(passedRoot.left, value);
                }
                else if (passedRoot.data < value)
                {
                    passedRoot.right = InsertRecursive(passedRoot.right, value);
                }
            }
            else
            {
                passedRoot = new Node(null, value, null);
            }
            return passedRoot;
        }
        public bool SearchIterative(int searchValue)
        {
            Node? iterator = root;
            while (iterator != null)
            {
                if(iterator.data == searchValue)
                {
                    return true;
                }
                else if (iterator.data > searchValue)
                {
                    iterator = iterator.left; 
                }
                else if (iterator.data < searchValue)
                {
                    iterator = iterator.right;
                }
            }
            return false;
        }

        public bool SearchRecursive(Node? passedRoot, int searchValue)
        {
            if (passedRoot != null)
            {
                if (passedRoot.data == searchValue)
                {
                    return true;
                }
                else if (passedRoot.data > searchValue)
                {
                    return SearchRecursive(passedRoot.left, searchValue);
                }
                else 
                {
                    return SearchRecursive(passedRoot.right, searchValue);
                }
            }
            else {
                return false;
            }
        }

        public void InOrderTraversal(Node? rootNode)
        {
            if (rootNode != null)
            {
                InOrderTraversal(rootNode.left);
                Console.Write($"{rootNode.data} ");
                InOrderTraversal(rootNode.right);
            }
        }

        public void PreOrderTraversal(Node? rootNode)
        {
            if (rootNode != null)
            {
                Console.Write($"{rootNode.data} ");
                PreOrderTraversal(rootNode.left);
                PreOrderTraversal(rootNode.right);
            }
        }

        public void PostOrderTraversal(Node? rootNode)
        {
            if (rootNode != null)
            {
                PostOrderTraversal(rootNode.left);
                PostOrderTraversal(rootNode.right);
                Console.Write($"{rootNode.data} ");
            }
        }
    }
}
