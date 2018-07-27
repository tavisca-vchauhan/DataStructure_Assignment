using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack : IOperations
    {
        static int MAX = 100;
        static int top;
        int[] stack = new int[MAX];

        public Stack()
        {
            top = -1;
        }



       public void Sort()
        {
            int swap;
            for (int i=0;i<=top;i++)
            {
                for(int j=0;j<=top;j++)
                {
                    if(stack[i]>stack[j])
                    {
                        swap = stack[i];
                        stack[i] = stack[j];
                        stack[j] = swap;
                    }
                }
            }
            Console.Write("\nAfter sorting ");
            
        }


        public int TopValue()
        {
            int topElement = -1;
            if (top <= -1)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                topElement = stack[top];

            }
            return topElement;
        }


        public  void Add(int item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                stack[++top] = item;
                
            }
        }

       public void Delete()
        {
           
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                
            }
            else
            {
                Console.Write("After Deletion ");
                int value = stack[top--];
                
            }
        }

       public int Display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
                return 0;
            }
        }

    }
}
