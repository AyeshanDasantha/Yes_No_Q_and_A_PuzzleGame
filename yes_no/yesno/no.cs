using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yes_no.yesno
{
    public partial class no : Form
    {
        public no()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 P = new Form1();
            this.Hide();
        }

        private void no_Load(object sender, EventArgs e)
        {

        }
    }
}
