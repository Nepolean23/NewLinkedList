using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class LinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node=new Node(data);
            if(this.head==null) 
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null) 
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in to linked list: ",node.data);
        }

    }
}
