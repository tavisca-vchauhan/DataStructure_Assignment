using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue : IOperations
    {

        private int[] value;
        private int front;
        private int rear;
        private int max ;

        public Queue()
        {
            value = new int[100];
            front = 0;
            rear = -1;
            max = 100;
        }

        public Queue(int size)
        {
            value = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }


        public void Add(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                value[++rear] = item;
            }
        }


        public void Delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                //return -1;
            }
            else
            {
                Console.WriteLine("Deleted element is: " + value[front]);
                front++;
            }
        }

        

        public int Display()
        {
           if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("Elements in Queue : ");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(value[i]+" ");
                    
                }
                return 0;
            }
        }

        public void Sort()
        {
           
            int swap;
            for (int i = front; i <= rear; i++)
            {
                for (int j = front; j <= rear-i-1; j++)
                {
                    if (value[j] > value[j+1])
                    {
                        swap = value[j];
                        value[j] = value[j+1];
                        value[j+1] = swap;
                    }
                }
            }
            Console.Write("\nAfter sorting ");

        }

        public Boolean isEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
           
        }



        public Boolean isFull()
        {
            if (front == 0 && rear + 1 >= max)
                return true;
            else
                return false;
        }



        public int Peek()
        {
            int peekValue = -1;
            if (front == -1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
                peekValue = value[front];
            return peekValue;
        }
    }
}
