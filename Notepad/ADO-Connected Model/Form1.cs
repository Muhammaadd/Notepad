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
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["syscon"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            Boolean status =false;
            cmd.CommandText = "select * from info";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (txt_username.Text.ToLower() == dr["username"].ToString().ToLower() && txt_password.Text == dr["password"].ToString())
                {
                    status = true;
                    f1.name = dr["username"].ToString();
                    f1.id = (int)dr["id"];
                    break;
                }
            }
            conn.Close();
            if(status)
            {
                f1.ShowDialog();
                lbl_invalid.Visible = false;
                txt_username.Text = txt_password.Text = "";
            }
            else
            {
               lbl_invalid.Visible = true;

            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
