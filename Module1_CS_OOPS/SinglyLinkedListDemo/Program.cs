namespace SinglyLinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkList sl=new SinglyLinkList();
            //AddNodeFront(sl, 10);
            //AddNodeFront(sl, 20);
            //AddNodeFront(sl, 30);
            //AddNodeFront(sl, 40);
            //AddNodeFront(sl, 50);


            AddNodeLast(sl, 10);
            AddNodeLast(sl, 20);
            AddNodeLast(sl, 30);
            AddNodeLast(sl, 40);
            AddNodeLast(sl, 50);

            TraverseNodes(sl);
        }
        static void TraverseNodes(SinglyLinkList sl)
        {
            Node node = sl.head;

            while (node != null)
            {
                Console.WriteLine(node.GetData());
                node = node.next;
            }
        }
        static void AddNodeFront(SinglyLinkList sl,int data)
        {
            Node newNode = new Node(data);
            newNode.next = sl.head;
            sl.head = newNode;
        }
        static void AddNodeLast(SinglyLinkList sl, int data)
        {
            Node newNode = new Node(data);
            if (sl.head == null)
            {
                sl.head = newNode;
                return;
            }
            Node lastNode = TraverseLastNode(sl);
            lastNode.next = newNode;
        }
        static Node TraverseLastNode(SinglyLinkList sl)
        {
            Node node = sl.head;

            while(node.next!=null)
            {
                node = node.next;
            }
            return node;
        }

    }
}
