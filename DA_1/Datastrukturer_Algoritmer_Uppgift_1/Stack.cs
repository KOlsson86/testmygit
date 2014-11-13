//Developed by Kristoffer Olsson
//Finished 2014-09-08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrukturer_Algoritmer_Uppgift_1
{
    class Stack
    {
        //instance varibles
        private ListNode firstNode = null;
        private int count = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public Stack()            
        {

        }

        /// <summary>
        /// Property
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        
        /// <summary>
        /// Push method.    
        /// Sets values for a new ListNode(aDataValue, firstnode)
        /// sets pointer to new node
        /// Adds 1 to count
        /// </summary>
        /// <param name="aDataValue"></param>
        /// <returns>firstNode</returns>
        public object Push(object aDataValue)          
        {
            
            ListNode newNode = new ListNode(aDataValue, firstNode);
            firstNode = newNode;
            
            count += 1;

            return firstNode;                                                    
        }

        /// <summary>
        /// Pop method
        /// Gets value and remove from stack
        /// </summary>
        /// <returns>returnValue or null</returns>
        public object Pop()
        {
            if (firstNode != null)
            {
                object popValue = firstNode.DataValue;
                firstNode = firstNode.NextNode;
                count += -1;
                return popValue;
            } 
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Show value without removing item from stack
        /// </summary>
        /// <param name="aDataValue"></param>
        /// <param name="aNextNode"></param>
        /// <returns></returns>
        public object Peek()
        {
            if (firstNode != null)
            {
                object peekValue = firstNode.DataValue;
                return peekValue;               
            }
            else return null;        
            
        }        

        

    }
}
