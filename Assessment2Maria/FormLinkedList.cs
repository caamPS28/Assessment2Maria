using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2Maria
{
    public partial class formlinkedlist : Form
    {
        private DoublyLinkedList _list = new DoublyLinkedList();
        public formlinkedlist()
        {
            InitializeComponent();
            this.Text = "Doubly Linked List";
            this.StartPosition = FormStartPosition.CenterParent;
            lblResult.Text = "Results will appear here...";
        }
        private void formlinkedlist_Load(object sender, EventArgs e)
        {

        }

        private void btnShowForward_Click(object sender, EventArgs e)
        {
            if (_list.IsEmpty)
            {
                MessageBox.Show("Build the list first");
                return;
            }
            lblResult.Text = _list.ToForwardString();
        }

        private void btnShowBackward_Click(object sender, EventArgs e)
        {
            if (_list.IsEmpty)
            {
                MessageBox.Show("Build the list first");
                return;
            }
            lblResult.Text = _list.ToBackwardString();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string input = (txtImput.Text ?? "").Trim();

            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please type a suburb (example: turner)");
                txtImput.Focus();
                return;
            }
            //clear and rebuild the list frim typed characters
            _list.Clear();
            foreach (char ch in input)
                _list.AddLast(ch);

            lblResult.Text = $"Built List with {input.Length} characters";
        }
    }

    internal class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        public bool IsEmpty => head == null;

        public void AddLast(char value)
        {
            var node = new Node(value);
            if(head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
                tail = node;
            }
        }
        public void Clear()
        {
            head = null;
            tail = null;

        }
         public String ToForwardString()
        {
            var sb = new StringBuilder();
            var cur = head;
            while (cur != null)
            {
                sb.Append(cur.Value);
                cur = cur.Next;
            }
            return sb.ToString();
        }
        public String ToBackwardString()
        {
            var sb = new StringBuilder();
            var cur = tail;
            while (cur != null)
            {
                sb.Append(cur.Value);
                cur = cur.Prev;
            }
            return sb.ToString();
        }
        private class Node
        {
            public char Value;
            public Node Next;
            public Node Prev;
            public Node(char value) => Value = value;
        }
    }
}
