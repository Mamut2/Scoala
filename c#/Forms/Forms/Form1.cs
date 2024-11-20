using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nr1, nr2;
        bool ok = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nr1 = textBox1.Text;
            ok = true;
            if (nr2 != null)
            {
                foreach (char c in nr2)
                {
                    if (!(c >= '0' && c <= '9')) ok = false;
                }
            }
            foreach (char c in nr1)
            {
                if (!(c >= '0' && c <= '9')) ok = false;
            }
            if (!ok) label2.Visible = true;
            else label2.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nr2 = textBox2.Text;
            ok = true;
            foreach (char c in nr2)
            {
                if (!(c >= '0' && c <= '9')) ok = false;
            }
            if (nr1 != null)
            {
                foreach (char c in nr1)
                {
                    if (!(c >= '0' && c <= '9')) ok = false;
                }
            }
            if (!ok) label2.Visible = true;
            else label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ok) return;
            char carry = '0';
            string temp = nr1;
            if (nr1.Length > nr2.Length)
            {
                nr1 = nr2;
                nr2 = temp;
            }
            while (nr1.Length != nr2.Length) nr1 += '0';

        }

    }
}
