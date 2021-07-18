using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yes_no.Quection;

namespace yes_no.Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 P = new Form1();
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quection P = new quection();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();
        }
    }
}
