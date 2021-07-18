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
    public partial class Q5 : Form
    {
        public Q5()
        {
            InitializeComponent();
        }

        private void Q5_Load(object sender, EventArgs e)
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
                textBox1.Text = (dr["quection5"].ToString());
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");

            string sqlselectquert = "SELECT TOP 1 answer5 from qection where answer5 like '1' ";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Source = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
            SqlConnection con = new SqlConnection(Source);
            con.Open();
            //MessageBox.Show("ok");

            string sqlselectquert = "SELECT TOP 1 answer5 from qection where answer5 like '0' ";
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
