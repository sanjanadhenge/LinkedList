using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class program
    {
        static void Main(string[] args)
        {
            LinkedListData linkedListData = new LinkedListData();
             linkedListData.Add(56);
             linkedListData.Add(30);
             linkedListData.Add(70);
               // linkedListData.AddReverse(70);
              //linkedListData.AddReverse(30);
             //linkedListData.AddReverse(56);
            //linkedListData.Display();
            // linkedListData.Insert(1, 30);
            linkedListData.Display();
            //linkedListData.RemoveFirstElement();
            //linkedListData.Display();
            //linkedListData.RemoveLastNode();
          //  int position1=linkedListData.Search(30);
          //  linkedListData.Insert(position1, 40);
          //  int position2 = linkedListData.Search(40);
          //  linkedListData.DeleteNodeAtParticularPosition(position2-1);
          linkedListData.Sort();
            linkedListData.Display();




        }
    }
}
