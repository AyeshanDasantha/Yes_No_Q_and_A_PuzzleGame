using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using yes_no.Quection;
using System.Data.Odbc;
using System.Configuration;
using yes_no.yesno;

namespace yes_no.Answer
{
    public partial class Q4 : Form
    {
        public Q4()
        {
            InitializeComponent();
        }

        private void Q4_Load(object sender, EventArgs e)
        {
            string Source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");

            string sqlselectquert = "SELECT TOP 1 * FROM qection ORDER BY ID DESC ";
            SqlCommand cmd = new SqlCommand(sqlselectquert, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr["quection4"].ToString());
            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");

            string sqlselectquert = "SELECT TOP 1 answer4 from qection where answer4 like '0' ";
            SqlCommand cmd = new SqlCommand(sqlselectquert, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Close();
                yes P = new yes();
                P.Show();

            }
            else
            {
                this.Close();
                no P = new no();
                P.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");

            string sqlselectquert = "SELECT TOP 1 answer4 from qection where answer4 like '1' ";
            SqlCommand cmd = new SqlCommand(sqlselectquert, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Close();
                yes P = new yes();
                P.Show();

            }
            else
            {
                this.Close();
                no P = new no();
                P.Show();
            }
        }
    }
}
