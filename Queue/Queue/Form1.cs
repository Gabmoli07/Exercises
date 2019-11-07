using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> peopleQueue = new Queue<string>();

        Stack<string> peopleStack = new Stack<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pArray = new string[] { "Tim", "Jonh", "Lisa", "Mary" };
            Queue<string> xQueue = new Queue<string>(pArray);
            Stack<string> xStack = new Stack<string>(pArray);


            peopleQueue.Enqueue("Tim");
            peopleQueue.Enqueue("Jonh");
            peopleQueue.Enqueue("Tracey");
            peopleQueue.Enqueue("Lisa");
            peopleQueue.Enqueue("Mary");
            foreach (string person in peopleQueue)
            {
                rtbStack.AppendText(person + Environment.NewLine);
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            string x = txtQueue.Text.Trim();
            if (x.Length > 0)
            {
                peopleQueue.Enqueue(x);
            }
            else
            {
                lblDisplay.Text = "Note: " + x + " is added to the queue";
            }    
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (peopleQueue.Count > 0)
            {
                lblDisplay.Text = "Note: " + peopleQueue.Dequeue() +
                    " is being removed from the queue.";
                rtbQueue.Clear();
                foreach (string person in peopleQueue)
                {
                    rtbQueue.AppendText (person + Environment.NewLine);
                }
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (peopleQueue.Count > 0)
            {
                lblDisplay.Text = "Who is the first on the queue" + peopleQueue.Peek() + " is the first!";
                rtbQueue.Clear();
                foreach (string person in peopleQueue)
                {
                    rtbQueue.AppendText(person + Environment.NewLine);
                }
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string x = txtStack.Text.Trim();
            if (x.Length > 0)
            {
                peopleStack.Push(x);
            }
            else
            {
                lblDisplay.Text = "Message: Nothing to be adde to the stack";
                return;
            }
            rtbStack.Clear();
            foreach (string person in peopleStack)
            {
                rtbStack.AppendText(person + Environment.NewLine);
            }
            lblDisplay.Text = "Note: " + x + " is added to the stack";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {

            if (peopleStack.Count > 0)
            {
                lblDisplay.Text = "Note: " + peopleStack.Pop() +
                    " is being removed from the stack.";
                rtbStack.Clear();
                foreach (string person in peopleStack)
                {
                    rtbStack.AppendText(person + Environment.NewLine);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (peopleStack.Count > 0)
            {
                lblDisplay.Text = "Who is the last on the stack? " + peopleStack.Peek() + " is the last!";
                rtbStack.Clear();
                foreach (string person in peopleStack)
                {
                    rtbStack.AppendText(person + Environment.NewLine);
                }
            }
        }

        private void txtStack_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
