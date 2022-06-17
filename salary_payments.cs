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
    public partial class salary_payments : Form
    {
        public salary_payments()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter adp;
        string conStr = @"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True";
        public static int adminid;

        private void salary_payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store_management_systemDataSet1.persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter1.Fill(this.store_management_systemDataSet1.persons);
            // TODO: This line of code loads data into the 'project_StoreManagementDataSet6.persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.project_StoreManagementDataSet6.persons);
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
            add();   
        }
        public void add()
        {
          
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into salary_payments(person_id,salary,user_id)values( " + cbid.Text + "," + txtsalary.Text + ", " + adminid + ")", con);
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
