namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Tree
            BinarySearchTree tree = new BinarySearchTree();
            // Insert Few Values using Iterative Function
            tree.InsertIterative(tree.root, 5);
            tree.InsertIterative(tree.root, 10);
            tree.InsertIterative(tree.root, 8);
            tree.InsertIterative(tree.root, 30);
            tree.InsertIterative(tree.root, 25);

            // Insert Few Values using Recursive Function
            tree.InsertRecursive(tree.root, 31);
            tree.InsertRecursive(tree.root, 46);
            tree.InsertRecursive(tree.root, 2);
            tree.InsertRecursive(tree.root, 3);
            tree.InsertRecursive(tree.root, 4);

            // Search via Iteration
            Console.WriteLine($"Value 25 is present in the Tree ? {tree.SearchIterative(25)}");
            
            // Search via Recursion
            Console.WriteLine($"Value 3 is present in the Tree ? {tree.SearchRecursive(tree.root,3)}");

            // Tree Traversals
            Console.Write("In Order Traversal : ");
            tree.InOrderTraversal(tree.root);
            Console.Write("\nPre Order Traversal : ");
            tree.PreOrderTraversal(tree.root);
            Console.Write("\nPost Order Traversal : ");
            tree.PostOrderTraversal(tree.root);

            Console.WriteLine();
        }
    }
}
