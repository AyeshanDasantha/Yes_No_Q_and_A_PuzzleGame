using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yes_no.Quection
{
    public partial class quection : Form
    {
        public quection()
        {
            InitializeComponent();
        }

        config o = new config();
        string answer1;
        string answer2;
        string answer3;
        string answer4;
        string answer5;
        string answer6;
        string answer7;
        string answer8;
        string answer9;
        SqlConnection con;
        string str;
        private void quection_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;
            panel9.Enabled = false;



            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();



        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" 
                && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                textBox9.Text != "" )
            {
                try
                {

                    //string qry = "INSERT INTO qection(id,quection1,quection2,quection3,quection4,quection5,quection6,quection7,quection8,quection9,answer1,answer2,answer3,answer4,answer5,answer6,answer7,answer8,answer9) VALUES('" + textBox11.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + answer1 + "','" + answer2 + "','" + answer3 + "','" + answer4 + "','" + answer5 + "','" + answer6 + "','" + answer7 + "','" + answer8 + "','" + answer9 + "')";
                    //SqlCommand cmd = new SqlCommand(qry, o.con);
                    //cmd.ExecuteNonQuery();                    
                    //MessageBox.Show("Your Quection Added Successfully");


                    string insertStmt = "INSERT INTO qection(id, quection1, quection2, quection3, quection4,quection5,quection6,quection7,quection8,quection9,answer1,answer2,answer3,answer4,answer5,answer6,answer7,answer8,answer9) " +
                    "VALUES(@id, @quection1, @quection2,@quection3, @quection4,@quection5,@quection6,@quection7,@quection8,@quection9,@answer1,@answer2,@answer3,@answer4,@answer5,@answer6,@answer7,@answer8,@answer9)";

                    // define connection and command
                    using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True"))
                    using (SqlCommand cmd = new SqlCommand(insertStmt, conn))
                    {
                        // define parameters and set their values
                        cmd.Parameters.Add("@id", SqlDbType.NVarChar, 100).Value = textBox11.Text.Trim();
                        cmd.Parameters.Add("@quection1", SqlDbType.NVarChar, 100).Value = textBox1.Text.Trim();
                        cmd.Parameters.Add("@quection2", SqlDbType.NVarChar, 100).Value = textBox2.Text.Trim();
                        cmd.Parameters.Add("@quection3", SqlDbType.NVarChar, 100).Value = textBox3.Text.Trim();
                        cmd.Parameters.Add("@quection4", SqlDbType.NVarChar, 250).Value = textBox4.Text.Trim();
                        cmd.Parameters.Add("@quection5", SqlDbType.NVarChar, 250).Value = textBox5.Text.Trim();
                        cmd.Parameters.Add("@quection6", SqlDbType.NVarChar, 250).Value = textBox6.Text.Trim();
                        cmd.Parameters.Add("@quection7", SqlDbType.NVarChar, 250).Value = textBox7.Text.Trim();
                        cmd.Parameters.Add("@quection8", SqlDbType.NVarChar, 250).Value = textBox8.Text.Trim();
                        cmd.Parameters.Add("@quection9", SqlDbType.NVarChar, 250).Value = textBox9.Text.Trim();
                        cmd.Parameters.Add("@answer1", SqlDbType.NVarChar, 250).Value = answer1.Trim();
                        cmd.Parameters.Add("@answer2", SqlDbType.NVarChar, 250).Value = answer2.Trim();
                        cmd.Parameters.Add("@answer3", SqlDbType.NVarChar, 250).Value = answer3.Trim();
                        cmd.Parameters.Add("@answer4", SqlDbType.NVarChar, 250).Value = answer4.Trim();
                        cmd.Parameters.Add("@answer5", SqlDbType.NVarChar, 250).Value = answer5.Trim();
                        cmd.Parameters.Add("@answer6", SqlDbType.NVarChar, 250).Value = answer6.Trim();
                        cmd.Parameters.Add("@answer7", SqlDbType.NVarChar, 250).Value = answer7.Trim();
                        cmd.Parameters.Add("@answer8", SqlDbType.NVarChar, 250).Value = answer8.Trim();
                        cmd.Parameters.Add("@answer9", SqlDbType.NVarChar, 250).Value = answer9.Trim();

                        MessageBox.Show("Your Quection Added Successfully");

                        // open connection, execute query, close connection
                        conn.Open();
                        int rowsInserted = cmd.ExecuteNonQuery();
                        conn.Close();
                    }


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;

                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel7.Enabled = false;
                    panel8.Enabled = false;
                    panel9.Enabled = false;
                    

                   
                }
                catch (Exception x)
                {
                    
                    MessageBox.Show("Something Wrong");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Datas !!");
            }
        }

        public string s { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer1 = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer1 = "0";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer2 = "1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer2 = "0";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answer3 = "1";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answer3 = "0";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            answer4 = "1";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            answer4 = "0";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            answer5 = "1";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            answer5 = "0";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            answer6 = "1";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            answer6 = "0";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            answer7 = "1";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            answer7 = "0";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            answer8 = "1";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            answer8 = "0";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            answer9 = "1";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            answer9 = "0";
        }

              

        private void button3_Click(object sender, EventArgs e)
        {


            string deleteqry = "DELETE FROM qection where id ='" + textBox10.Text + "'";
            SqlCommand cmd2 = new SqlCommand(deleteqry, o.con);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Last Quections Delete Successfully.Enter Your New Quections Now");

            textBox1.Enabled = true ;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;

            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
        }
        
                

        

    }
}
