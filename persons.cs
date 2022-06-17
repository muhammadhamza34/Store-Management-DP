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
    public partial class persons : Form
    {
        public persons()
        {
            InitializeComponent();
        }
        SqlConnection con;
        //SqlDataAdapter adp;
        string conStr = @"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True";
        public static int adminid;

        private void persons_Load(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into persons(name,nic,phone,email,user_id) values('" + txtname.Text + "','"+   txtdesignation.Text + "','" + txtphone.Text + "','" + txtemail.Text + "', '" + adminid + "')", con);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
