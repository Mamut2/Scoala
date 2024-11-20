using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clase_dif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string departament = textBox3.Text;
            double venit = double.Parse(textBox4.Text);
            DateTime dn = dateTimePicker1.Value;
            Angajat a = new Angajat(nume, prenume, departament, venit, dn);
            Variabile.l.Add(a);
            label6.Text = "";
            foreach(Angajat an in Variabile.l)
            {
                label6.Text += an.nume + " " + an.prenume + '\n';
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (Angajat a in Variabile.l)
            {
                if (comboBox1.Items.Contains(a.departament) == false)
                    comboBox1.Items.Add(a.departament);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                string departament = comboBox1.SelectedItem.ToString();
                foreach (Angajat a in Variabile.l)
                    if (a.departament == departament)
                        label6.Text += a.nume + " " + a.prenume + "\n";
            }
        }
    }
}
