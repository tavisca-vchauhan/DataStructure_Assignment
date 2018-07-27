using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Select
    {
        static void Main(string[] args)
        {
            bool result = true;
            bool secondChoice=true;
            int rs;
            while (result)
            {
                Console.WriteLine("Which Operation you want to operate :\n1 for Stack \n2 for Queue\n3 for Link List");
                int op = Convert.ToInt32(Console.ReadLine());          
                switch (op)
                {
                    case 1:
                        Stack myStack = new Stack();
                        while (secondChoice)
                        {
                            Console.WriteLine("\n1 for Add a number \n2 for Delete top element from stack\n3 for Sorting\n4 for Top Value\n5 for Display the Stack");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine("Enter Element to be Added");
                                    myStack.Add(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    rs=myStack.Display();
                                    if (rs == -1)
                                        break;
                                    myStack.Delete();
                                    myStack.Display();
                                    break;
                                case 3:
                                    myStack.Sort();
                                    myStack.Display();
                                    break;
                                case 4:
                                    //myStack.Peek();
                                   int topElement= myStack.TopValue();
                                   Console.WriteLine("Top Element in stack : {0}", topElement);
                                    break;
                                case 5:
                                    myStack.Display();
                                    break;
                                
                            }
                            Console.WriteLine("Do you want to continue : Y or N");
                            if (((Console.ReadLine()).ToUpper()).Equals("N"))
                            {
                                secondChoice = false;
                            }

                        }
                        break;

                    case 2:
                        Queue myQueue = new Queue();
                        while (secondChoice)
                        {
                            Console.WriteLine("\n1 for Add a number \n2 for Delete element from Queue\n3 for Sorting\n4 for Peek Value\n5 for Display the Queue \n6 To check Queue Full\n7 To check Queue is empty");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine("Enter Element to be Added");
                                    myQueue.Add(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    rs = myQueue.Display();
                                    if (rs == -1)
                                        break;
                                    myQueue.Delete();
                                    rs=myQueue.Display();
                                    break;
                                case 3:
                                    myQueue.Sort();
                                    myQueue.Display();
                                    break;
                                case 4:
                                    int first=myQueue.Peek();
                                    Console.WriteLine("Peek Value in Queue is : {0}",first);
                                    break;
                                case 5:
                                    myQueue.Display();
                                    break;
                                case 6:                                  
                                    if(myQueue.isEmpty())
                                    {
                                        Console.WriteLine("Queue is Empty");
                                    }
                                    else
                                        Console.WriteLine("Queue is full");
                                    break;
                                case 7:
                                    if(myQueue.isFull())
                                    {
                                        Console.WriteLine("Queue is full");
                                    }
                                    else
                                        Console.WriteLine("Queue is Empty");
                                    break;

                            }
                            Console.WriteLine("Do you want to continue : Y or N");
                            if (((Console.ReadLine()).ToUpper()).Equals("Y"))
                            {
                                secondChoice = true;

                            }
                            else
                                secondChoice = false;

                        }

                        break;

                    case 3:
                        LinkList myList = new LinkList();
                        while (secondChoice)
                        {
                            Console.WriteLine("\n1 For Add a number \n2 for Delete element from LinkList\n3 for Sorting\n4 To Insert at the specific position\n5 for Display the LinkList \n6 To Remove from the specific position and adjust list");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {

                                case 1:
                                    Console.WriteLine("Enter Element to be Added");
                                    myList.Add(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case 2:
                                    
                                    myList.Delete();
                                    
                                    break;
                                case 3:
                                    myList.Sort();
                                    myList.Display();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the Data You want to insert ");
                                    int insert = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the index where you want to insert ");
                                    int index = Convert.ToInt32(Console.ReadLine());
                                    myList.InsertAtIndex(insert,index);
                                    break;
                                case 5:
                                    rs=myList.Display();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the index where you want to delete the data from ");
                                    int delete = Convert.ToInt32(Console.ReadLine());
                                    myList.RemoveAtIndex(delete);
                                    break;

                            }
                            Console.WriteLine("Do you want to continue : Y or N");
                            if (((Console.ReadLine()).ToUpper()).Equals("Y"))
                            {
                                secondChoice = true;

                            }
                            else
                                secondChoice = false;

                        }
                        break;
                     default:
                        break;
                }
                Console.WriteLine("Do you want to continue : Y or N");
                if(((Console.ReadLine()).ToUpper()).Equals("Y"))
                {
                    result = true;
                }
                else
                    result=false ;


            }

           
            Console.ReadKey();
        }
    }
}
