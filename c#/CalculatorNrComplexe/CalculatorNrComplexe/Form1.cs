using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorNrComplexe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex a = new Complex();
            Complex b = new Complex();
            a.Re = int.Parse(textBox1.Text);
            a.Im = int.Parse(textBox2.Text);
            b.Re = int.Parse(textBox4.Text);
            b.Im = int.Parse(textBox5.Text);
            Complex res = new Complex();
            res = a * b;
            textBox3.Text = res.Re + " + " + res.Im + "i";
            ClearAll();
        }

        private void butonSuma_Click(object sender, EventArgs e)
        {
            Complex a = new Complex();
            Complex b = new Complex();
            a.Re = int.Parse(textBox1.Text);
            a.Im = int.Parse(textBox2.Text);
            b.Re = int.Parse(textBox4.Text);
            b.Im = int.Parse(textBox5.Text);
            Complex res = new Complex();
            res = a + b;
            textBox3.Text = res.Re + " + " + res.Im + "i";
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex a = new Complex();
            a.Re = int.Parse(textBox1.Text);
            a.Im = int.Parse(textBox2.Text);
            textBox3.Text = a.Modul().ToString();
            ClearAll();
        }

        private void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
