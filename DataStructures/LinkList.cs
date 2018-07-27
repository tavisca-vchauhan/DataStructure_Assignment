using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    

    class LinkList : Node , IOperations
    {
        static Node head;

        public LinkList()
        {
            head = null;
           
        }

        public void Add(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;
            head = toAdd;
        }

        public void Delete()
        {
            head = head.Next;
            
        }

        public void Sort()
        {
            int temp;
            int size = Length();
            for (int i = 0; i < size; i++)
            {
                
                Node newNode = head;
                Node next = head.Next;
                for (int j = 0; j < size - 1; j++)
                {
                    if (newNode.Data > next.Data)
                    {
                        temp = newNode.Data;
                        newNode.Data = next.Data;
                        next.Data = temp;
                    }
                    newNode = next;
                    next = next.Next;

                }
            }
        }

        public static int Length()
        {
            int length = 0;
            Node newNode = head;
            while (newNode != null)
            {
                length++;
                newNode = newNode.Next;
            }
            return length;
        }

        
        public int Display()
        {
            Node current = head;
            Console.WriteLine("Elements in Stack are :");
            while (current != null)
            {
                Console.WriteLine(current.data+" ");
                current = current.next;
            }
            return 0;
        }

        public void InsertAtIndex(int data, int index)
        {
            if (head == null)
            {
                Add(data);
                return;
            }
            Node newNode = head;
            while (index > 1)
            {
                newNode = newNode.Next;
                index--;
            }
            Node addNode = newNode.Next;
            newNode.Next = new Node(data);
            newNode.Next.Next = addNode;
        }


        public int RemoveAtIndex(int index)
        {
            Node newNode = head;
            int deletedData = -1;
            if (index < 1)
            {
                Console.WriteLine("Wrong index");
                return -1;
            }
            if (index == 1)
            {
                deletedData = head.Data;
                head = head.Next;
                return deletedData;
            }
            while (index > 0)
            {
                if (newNode == null)
                    return -1;

                newNode = newNode.Next;
                index--;
            }
            deletedData = newNode.Data;
            newNode.Data = newNode.Next.Data;
            newNode.Next = newNode.Next.Next;
            return deletedData;
        }


    }
}
