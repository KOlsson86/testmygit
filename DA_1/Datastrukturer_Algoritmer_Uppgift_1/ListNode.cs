//Developed by Kristoffer Olsson
//Finished 2014-09-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrukturer_Algoritmer_Uppgift_1
{
    class ListNode
    {

        /// <summary>
        /// Property
        /// </summary>
        public ListNode NextNode
        {
            get;
            private set;
        }

        /// <summary>
        /// Property
        /// </summary>        
        public object DataValue
        {
            get;
            private set ;
        }
                             

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataValue"></param>
        /// <param name="nextNode"></param>
        public ListNode (object dataValue, ListNode nextNode)
        {
            DataValue = dataValue;
            NextNode = nextNode;
        }        


    }
}

