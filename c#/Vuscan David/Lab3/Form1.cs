using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string n;
        bool ok = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = textBox1.Text;
            ok = true;
            foreach (char c in n)
            {
                if (!(c >= '0' && c <= '9')) ok = false;
            }
            if (!ok) label2.Visible = true;
            else label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ok) return;
            long prod = 1;
            textBox2.Text = "";
            for(int i = 2, nr = 0; nr < int.Parse(n); i+=2, nr++)
                if(i % 2 == 0) 
                {
                    textBox2.Text += i.ToString() + ' ';
                    prod *= i;
                }
            label3.Text = prod.ToString();
        }
    }
}
