using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class DeleteLastElementInLinkedList
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

            if (temp == null)
            {
                Console.WriteLine("The linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
        internal Node InsertionOfDataAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }

            if (position > 1)
            {
                var newnode = new Node(data);
                newnode.next = this.head;
                head = newnode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head;
                        head = node;
                        break;

                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position is out of range");
                }
            }
            return head;
        }
        internal void pop_first()
        {
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
            }
            Console.WriteLine("first element has been removed");
        }
        internal void DeletionOfLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("nothing to delete ");
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;

        }
    }
}

        



        












