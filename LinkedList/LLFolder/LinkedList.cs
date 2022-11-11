// using System.Collections;
// using System.Collections.Generic;
// using System;
// using System.Linq;

namespace LinkedList.LLFolder
{
    public class LLClass
    {
        public Node? First { get; set; }

        public void InsertFirst(int data, string nData)
        {
            //create the node
            Node newNode = new Node();
            //put the data in the node
            newNode.Data = data;
            newNode.pokeName = nData;
            //Put the old node in next
            newNode.Next = First;
            //make the head the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //assign the temporary variable
            Node tempVariable = First;
            //Assign the new head
            First = First.Next;

            return tempVariable;

        }

        public void DisplayList(){
            Console.WriteLine("Iterating through list...");
            Node current = First;
            while(current != null){
                current.DisplayNode();
                current = current.Next;
            }

        }

        public void InsertLast(int data, string nData){
            Node current = First;
            while(current.Next != null){
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            newNode.pokeName = nData;
            current.Next = newNode;
        }

        public void nthFromLast(int data, string nData){
            
        }
    }
}