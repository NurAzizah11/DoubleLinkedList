using System;

namespace DoubleLinkedList
{
    class Node
    {
        /*Node class represents the node of double linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
 
}