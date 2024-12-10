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

        SortedDictionary<string, List<Elev>> elevi = new SortedDictionary<string, List<Elev>>();
        List<int> medii = new List<int>();
        List<string> optionale = new List<string>();
        int nrChecked = 0;

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox2.Text != "")
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
                medii.Add(int.Parse(textBox2.Text));
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked) optionale.Add("Romana");
            if (checkBox2.Checked) optionale.Add("Info");
            if (checkBox3.Checked) optionale.Add("Matematica");
            Elev el = new Elev(textBox3.Text, textBox4.Text, medii, radioButton1.Checked, optionale, monthCalendar1.SelectionRange.Start);
            if(!elevi.ContainsKey(el.clasa)) elevi.Add(el.clasa, new List<Elev>());
            elevi[el.clasa].Add(el);
            medii.Clear();
            optionale.Clear();

            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            textBox1.Text = "1";

            UpdateListBox();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var key in elevi.Keys.Reverse())
                comboBox1.Items.Add(key);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            foreach (var item in elevi)
                if (item.Key == (string)comboBox1.SelectedItem)
                    foreach (Elev el in item.Value.Reverse<Elev>())
                    {
                        ListViewItem li = new ListViewItem(el.nume);
                        li.SubItems.Add(el.prenume);
                        li.SubItems.Add(el.clasa);
                        if(el.sex) li.SubItems.Add("M");
                        else li.SubItems.Add("F");
                        li.SubItems.Add(el.dn.Day + "." + el.dn.Month + "." + el.dn.Year);
                        if (el.bursier) li.SubItems.Add("Da");
                        else li.SubItems.Add("Nu");
                        string op = "";
                        foreach (string s in el.optionale) op += s + " ";
                        li.SubItems.Add(op);
                        string medii = "";
                        foreach (int s in el.medii) medii += s + " ";
                        li.SubItems.Add(medii);
                        li.SubItems.Add(el.mediaGenerala.ToString("F"));
                        listView1.Items.Add(li);
                    }
            foreach (var item in elevi.Reverse())
            {
                foreach (Elev el in item.Value.Reverse<Elev>())
                {
                    ListViewItem li = new ListViewItem(el.nume);
                    li.SubItems.Add(el.prenume);
                    li.SubItems.Add(el.clasa);
                    if (el.sex) li.SubItems.Add("M");
                    else li.SubItems.Add("F");
                    li.SubItems.Add(el.dn.Day + "." + el.dn.Month + "." + el.dn.Year);
                    if (el.bursier) li.SubItems.Add("Da");
                    else li.SubItems.Add("Nu");
                    string op = "";
                    foreach (string s in el.optionale) op += s + " ";
                    li.SubItems.Add(op);
                    string medii = "";
                    foreach (int s in el.medii) medii += s + " ";
                    li.SubItems.Add(medii);
                    li.SubItems.Add(el.mediaGenerala.ToString("F"));
                    listView2.Items.Add(li);
                }
            }
            foreach (var item in elevi)
                foreach (Elev el in item.Value.Reverse<Elev>())
                {
                    if (((string)comboBox2.SelectedItem == "M" && el.sex) || ((string)comboBox2.SelectedItem == "F" && !el.sex))
                    {
                        ListViewItem li = new ListViewItem(el.nume);
                        li.SubItems.Add(el.prenume);
                        li.SubItems.Add(el.clasa);
                        if (el.sex) li.SubItems.Add("M");
                        else li.SubItems.Add("F");
                        li.SubItems.Add(el.dn.Day + "." + el.dn.Month + "." + el.dn.Year);
                        if (el.bursier) li.SubItems.Add("Da");
                        else li.SubItems.Add("Nu");
                        string op = "";
                        foreach (string s in el.optionale) op += s + " ";
                        li.SubItems.Add(op);
                        string medii = "";
                        foreach (int s in el.medii) medii += s + " ";
                        li.SubItems.Add(medii);
                        li.SubItems.Add(el.mediaGenerala.ToString("F"));
                        listView3.Items.Add(li);
                    }
                }
            foreach (var item in elevi.Reverse())
            {
                foreach (Elev el in item.Value.Reverse<Elev>())
                {
                    if (!el.bursier) continue;
                    ListViewItem li = new ListViewItem(el.nume);
                    li.SubItems.Add(el.prenume);
                    li.SubItems.Add(el.clasa);
                    if (el.sex) li.SubItems.Add("M");
                    else li.SubItems.Add("F");
                    li.SubItems.Add(el.dn.Day + "." + el.dn.Month + "." + el.dn.Year);
                    if (el.bursier) li.SubItems.Add("Da");
                    else li.SubItems.Add("Nu");
                    string op = "";
                    foreach (string s in el.optionale) op += s + " ";
                    li.SubItems.Add(op);
                    string medii = "";
                    foreach (int s in el.medii) medii += s + " ";
                    li.SubItems.Add(medii);
                    li.SubItems.Add(el.mediaGenerala.ToString("F"));
                    listView4.Items.Add(li);
                }
            }
            foreach (var item in elevi.Reverse())
            {
                foreach (Elev el in item.Value.Reverse<Elev>())
                {
                    if (el.dn.AddYears(18).CompareTo(DateTime.Today) < 1) continue;
                    ListViewItem li = new ListViewItem(el.nume);
                    li.SubItems.Add(el.prenume);
                    li.SubItems.Add(el.clasa);
                    if (el.sex) li.SubItems.Add("M");
                    else li.SubItems.Add("F");
                    li.SubItems.Add(el.dn.Day + "." + el.dn.Month + "." + el.dn.Year);
                    if (el.bursier) li.SubItems.Add("Da");
                    else li.SubItems.Add("Nu");
                    string op = "";
                    foreach (string s in el.optionale) op += s + " ";
                    li.SubItems.Add(op);
                    string medii = "";
                    foreach (int s in el.medii) medii += s + " ";
                    li.SubItems.Add(medii);
                    li.SubItems.Add(el.mediaGenerala.ToString("F"));
                    listView5.Items.Add(li);
                }
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("F");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            if (c.Checked) nrChecked++;
            else nrChecked--;
            if (nrChecked > 2 && c.Checked) c.Checked = false;
        }
    }
}
