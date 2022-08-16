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

    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["syscon"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public string name { get; set; }
        public int id { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_hello.Text = "Hello " + this.name;
            cmd.CommandText = "select * from path where id = @id";
            cmd.Parameters.AddWithValue("id", this.id);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<FilesTable> files = new List<FilesTable>();
            Boolean x =false;
            while (dr.Read())
                {
                    dgv_loaded.Visible = true;
                    FilesTable f = new FilesTable();
                    f.FileName = dr["filename"].ToString();
                    files.Add(f);
                     x = true;
                }
            dgv_loaded.DataSource = files;
            conn.Close();
            if(!x)
            {
                dgv_loaded.Visible = false;
                lbl_here.Text = "";
            }
        }

        private void lbl_hello_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();

        }
    }
}
