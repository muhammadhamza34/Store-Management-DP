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
    public partial class expenses : Form
    {
        public expenses()
        {
            InitializeComponent();
        }
        SqlConnection con;

        public SqlConnection getconnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            return con;
        }
        public static int adminid;

        private void btnback_Click(object sender, EventArgs e)
        {
            s objAdmin = new s();
            this.Hide();
            objAdmin.Show();

        }

        private void expenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store_management_systemDataSet4.expenses_type' table. You can move, or remove it, as needed.
            this.expenses_typeTableAdapter1.Fill(this.store_management_systemDataSet4.expenses_type);
            // TODO: This line of code loads data into the 'project_StoreManagementDataSet5.expenses_type' table. You can move, or remove it, as needed.
            this.expenses_typeTableAdapter.Fill(this.project_StoreManagementDataSet5.expenses_type);
            adminid = Form1.id;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        //public void display()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    // SqlDataAdapter adp = new SqlDataAdapter("select * from salesmen", con);
        //    SqlDataAdapter adp = new SqlDataAdapter("select expenses.expenses_id,expenses_type.name,expenses.amount,billing_month,billpaid_date,expenses.user_id from expenses left outer join expenses_type on expenses.expenses_type_id = expenses_type.expenses_type_id", con);

        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}
        public void add()
        {
            int id=0;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();

          
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("Select expenses_type_id from expenses_type where name='" + comboBox1.Text + "'", con);
                    SqlDataReader reader1 = sqlCommand.ExecuteReader();

                    while (reader1.Read())
                    {
                        id = Convert.ToInt32(reader1[0].ToString());

                        MessageBox.Show(Convert.ToString(id));
                    }
                reader1.Close();
            }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
            
            SqlCommand cmd = new SqlCommand("insert into expenses(expenses_type_id,amount,billing_month,user_id)values( " + id + ","+txtamount.Text+",'" + txtbillmonth.Text + "', " + adminid + ")", con);
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
        //public void delete()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    String query = "delete from expenses where expenses_id =" + txtexpenseid.Text + "";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("delete successful");
        //        display();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    con.Close();
        //}
        //public void search()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    try
        //    {
        //        SqlDataAdapter adp = new SqlDataAdapter("select * from expenses where expenses_id=" + textBox7.Text + "", con);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("enter id to search");

        //    }

        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
           // display();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete();
            //display();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
        //    display();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
          //  search();
        }
    }
}
