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

namespace StoreManagementSystem
{
    public partial class expenses_type : Form
    {
        public expenses_type()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            s objAdmin = new s();
            this.Hide();
            objAdmin.Show();
        }
        SqlConnection con;
        SqlDataAdapter adp;
        string conStr = @"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True";
        public static int adminid;
        private void expenses_type_Load(object sender, EventArgs e)
        {

            adminid = Form1.id;

            try
            {//yahan pr
                con = new SqlConnection(conStr);
                label5.Text = "Connection on";
            }
            catch (Exception)
            {

                label5.Text = "Connection off";
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into expenses_type(name,user_id)values('" + txtname.Text + "'," + adminid + ")", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }
