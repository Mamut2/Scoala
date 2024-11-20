using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Elev[] el = new Elev[100];
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            el[i] = new Elev();
            el[i].Nume = textBox1.Text;
            el[i].Clasa = textBox2.Text;
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int k = 0; k < i; k++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (el[j].Clasa.CompareTo(el[k].Clasa) == 1)
                    {
                        Elev temp = el[j];
                        el[j] = el[k];
                        el[k] = temp;
                    }
                }
            }
            string clasa = el[0].Clasa;
            int nr = 0;
            label5.Text = "";
            for (int j = 0; j < i; j++)
            {
                if (el[j].Clasa.CompareTo(clasa) == 0)
                {
                    nr++;
                }
                else
                {
                    label5.Text += clasa + ": " + nr.ToString() + "\n";
                    nr = 1;
                    clasa = el[j].Clasa;
                }

                if (j == i - 1) label5.Text += clasa + ": " + nr.ToString() + "\n";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
