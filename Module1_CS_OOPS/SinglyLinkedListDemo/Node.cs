using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListDemo
{
    class Node
    {
        int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
        public int GetData()
        {         
            return data;
        }
    }

}
