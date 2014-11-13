//Developed by Kristoffer Olsson
//Finished 2014-09-08
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Datastrukturer_Algoritmer_Uppgift_1
{
    public partial class MainForm : Form
    { 

        //instance variables        
        private Stack myStack;
        private string userInput;                       
        
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads user input from txtBoxUserInput
        /// </summary>
        private void ReadUserInput()
        {            
            userInput = txtBoxUserInput.Text;            
        }

        /// <summary>
        /// Searches string.
        /// For each left value - [, ( and < - push to stack
        /// For each right value - ], ) and > - pop from stack
        /// Calls CheckCount-method to get number of items in stack
        /// </summary>
        private void SearchString()
        {
            ReadUserInput();
            myStack = new Stack();
            

            foreach (char item in userInput.ToCharArray())
            {
             
                if ((item == '<') || (item == '(') || item == '[')
                {
                    myStack.Push(item);                                        
                }

                else if ((item == '>') || (item == ')') || item == ']')
                {

                                        
                    object aValue = myStack.Pop();
                    if (aValue == null)
                    {
                        MessageBox.Show("Too many on the right");
                        break;
                    }

                    char compareValue = (char)aValue;                    

                    
                    if (item == '>' && compareValue != '<')                      
                    {                                                          
                        //faulty input
                        MessageBox.Show("Faulty input < or >");

                    }

                    if (item == ')' && compareValue != '(')
                    {
                        //faulty input
                        MessageBox.Show("Faulty input ( or )");
                    }

                    if (item == ']' && compareValue != '[')
                    {
                        //faulty input
                        MessageBox.Show("Faulty input [ or ]");
                    }

                }                                                    
             
                                      
            }


            //here
            if (myStack.Count != 0)
            {
                MessageBox.Show("Use of values not even - " + myStack.Count + " values not even");
            }
            
            if (myStack.Count == 0)
            {
                MessageBox.Show("Successful");
            }
            
        }
        
        //}
       
        /// <summary>
        /// Gets number of items in stack
        /// If values are uneven - gives error msg
        /// If stacks is empty - gives success msg
        /// </summary>
        //private void CheckCount()
        //{
            
        //}

        /// <summary>
        /// Go - Button
        /// Calls SearchString()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {               
            SearchString();
        }
    }
}
