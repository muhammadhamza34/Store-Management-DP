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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con;
        public SqlConnection getconnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            return con;
        }
        public static int adminid;
        public int item_id;

        private void btnback_Click(object sender, EventArgs e)
        {
            s objAdmin = new s();
            this.Hide();
            objAdmin.Show();

        }

        private void stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store_management_systemDataSet3.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.store_management_systemDataSet3.items);
            // TODO: This line of code loads data into the 'project_StoreManagementDataSet4.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.project_StoreManagementDataSet4.items);
            adminid = Form1.id;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
         //   display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
           // display();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //search();
          
        }

        //public void delete()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    String query = "delete from stock where item_id =" + textBox7.Text + "";
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
        //        SqlDataAdapter adp = new SqlDataAdapter("select * from stock where item_id=" + textBox7.Text + "", con);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("enter id to search");

        //    }
        //}
        //public void display()
        //{
        //    getconnection();
        //    SqlDataAdapter adp = new SqlDataAdapter("select * from stock", con);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Select item_id from items where name='" + comboBox1.Text + "'", con);
                SqlDataReader reader2 = sqlCommand.ExecuteReader();
                while (reader2.Read())
                {
                    item_id = Convert.ToInt32(reader2[0].ToString());

                    MessageBox.Show(Convert.ToString(item_id));
                }
                reader2.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand cmd = new SqlCommand("insert into stock(item_id,quantity,user_id)values(" + item_id + ", '" + txtquantity.Text + "'," + adminid + ")", con);
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
