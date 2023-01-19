using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class AppendingOfLinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in to linked list: ", node.data);
        }


        internal void Display()
        {
            Node temp = this.head;

            if(temp==null)
            {
                Console.WriteLine("The linked list is empty");
                return;
            }
            while(temp!= null) 
            {
                Console.Write(temp.data+ " ");
                temp= temp.next;
            }

        }
    }
}

