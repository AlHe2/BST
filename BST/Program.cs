using System;

namespace BST
{
    class Program
    {
        static public bool Running { get; set; }
        private Node BST = null;

        static void Main(string[] args) {
            Running = true;
            Program P = new Program();
            P.Run();
        }

        private void Run() {
            while (Running) {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("0 : Initialize");
                Console.WriteLine("1 : Insert");
                Console.WriteLine("2 : InOrder visit");
                Console.WriteLine("3 : PreOrder visit");
                Console.WriteLine("4 : PostOrder visit");
                Console.WriteLine("9 : Exit");
                Console.Write("Enter your choice : ");
                int answer = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine("\n------------------------------------------------------");
                switch (answer) {
                    case 0: Init(); break;
                    case 1: Insert(); break;
                    case 2: InOrder(BST); break;
                    case 3: PreOrder(BST); break;
                    case 4: PostOrder(BST); break;
                    case 9: Running = false; break;
                }
                Console.WriteLine();
            }
        }

        private void Init() {
            Insert(5, ref BST);
            Insert(3, ref BST);
            Insert(8, ref BST);
            Insert(8, ref BST);
            Insert(10, ref BST);
        }

        private void InOrder(Node root) {
            if (root != null) {
                InOrder(root.left);
                Console.Write(root.Data + ", ");
                InOrder(root.right);
            }
        }

        private void PreOrder(Node root) {
            if (root != null) {
                Console.Write(root.Data + ", ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

 
        private void PostOrder(Node root) {
            if (root != null) {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.Data + ", ");
            }
        }

        private void Insert() {
            Console.Write("Enter value : ");
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Insert(val, ref BST);
        }

        private void Insert(int val, ref Node root) {
            if (root == null) {
                root = new Node(val);
            }
            else {
                if (val > root.Data) {
                    Insert(val, ref root.right);
                }
                else {
                    Insert(val, ref root.left);
                }
            }
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node left;
        public Node right;

        public Node(int val) {
            Data = val;
            left = null;
            right = null;
        }
    }
}
