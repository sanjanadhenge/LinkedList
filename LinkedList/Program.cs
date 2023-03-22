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
            linkedListData.Search(30);
            linkedListData.Display();




        }
    }
}
