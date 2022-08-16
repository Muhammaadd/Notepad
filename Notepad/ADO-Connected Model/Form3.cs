using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_Connected_Model
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["syscon"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Boolean status = false;
            string username = txt_newusername.Text.ToString();
            string password = txt_newpassword.Text.ToString();
            if (username == "")
                lbl_userfill.Visible = true;
            else
            {
                status = true;
                lbl_userfill.Visible = false;
            }
            if (password == "")
            {
                lbl_passfill.Visible = true;
                status = false;
            }
            else { status = true;
                lbl_passfill.Visible = false;
            }
            if (status)
            {
                Boolean status1 = false;
                cmd.CommandText = "select * from info";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (username.ToLower() == dr["username"].ToString().ToLower())
                    {
                        status1 = true;
                        break;
                    }
                }
                conn.Close();
                if (status1)
                {
                    lbl_passfill.Visible = lbl_userfill.Visible = false;
                    lbl_alreadyexist.Visible = true;

                }
                else
                {
                    lbl_alreadyexist.Visible = false;
                    cmd.CommandText = "insert into info values(@username,@password)";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Connection = conn;
                    conn.Open();
                    int x = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (x == 0)
                        MessageBox.Show("error");
                    else
                    {

                        MessageBox.Show("Successfully Registeration");
                        this.Close();
                    }

                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_passfill.Visible = lbl_userfill.Visible = lbl_alreadyexist.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
