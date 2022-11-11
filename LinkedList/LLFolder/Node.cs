// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

namespace LinkedList.LLFolder{


    public class Node{

        public int Data {get; set; }

        public string pokeName {get; set; }

        public Node? Next {get; set;}
        public Node? Prev {get; set;}

        public void DisplayNode(){
            Console.WriteLine($"PokeNo.{Data} {pokeName}");
        }

    }
}