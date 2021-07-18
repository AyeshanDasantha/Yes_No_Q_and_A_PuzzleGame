using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yes_no.Answer;
using yes_no.Quection;
using yes_no.Main;

namespace yes_no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Q1 P = new Q1();
            P.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Q2 P = new Q2();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Q3 P = new Q3();
            P.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            Q4 P = new Q4();
            P.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            Q5 P = new Q5();
            P.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            Q6 P = new Q6();
            P.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            Q7 P = new Q7();
            P.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            Q8 P = new Q8();
            P.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            Q9 P = new Q9();
            P.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Home P = new Home();
            this.Hide();
        }

        
    }
}
