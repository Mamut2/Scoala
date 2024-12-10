using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Location = new Point(rnd.Next(Form1.ActiveForm.Size.Width - 100), rnd.Next(Form1.ActiveForm.Size.Height - 100));
        }
    }
}
