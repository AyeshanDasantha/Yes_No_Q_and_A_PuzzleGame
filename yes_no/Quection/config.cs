 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data;

namespace yes_no.Quection
{
    class config
    {
        public SqlConnection con;
        public string str;
        public config()
        {
            try
            {
                //Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True
                str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True;User Instance=True";
                con = new SqlConnection(str);
                con.Open();
                //MessageBox.Show("Database connected");
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            
            }


          }
            



    }
}
