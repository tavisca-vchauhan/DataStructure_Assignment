using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {
        public Node next;
        public int data;
    
        //int data;

        public Node()
        {
            next = null;
            data = 0;
        }
        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node(int data)
        {
            this.data = data;
        }
        public Node(int data, Node link)
        {
            this.data = data;
            next = link;
        }


    }
}
