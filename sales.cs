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
    public partial class sales : Form
    {
        SqlConnection con;

        public SqlConnection getconnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            return con;
        }
        public static int adminid;
        private int amt;

        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            adminid = Form1.id;
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
        public void display()
        {
            getconnection();
            SqlDataAdapter adp = new SqlDataAdapter("select * from sales_item", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void add()
        {
            SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into sales(date)" +
                "values('" + this.textBox1.Text + "')", con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand cmdd = new SqlCommand("insert into sales_item(sales_id,quantity,item_id,sold_price,user_id)" +
                           "values( " + amt + ", " + txtquantity.Text + ", " + txtsoldp.Text + "," + adminid + ")", con);
            try
            {
                cmdd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();


        }
        //       public void update()
        //       {
        //           SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //           con.Open();
        //           SqlCommand up = new SqlCommand("Update sales_item set item_id=" + txtitemid.Text + ", quantity=" + txtquantity.Text + ", user_id=" + adminid + ",sold_price=" + txtsoldp.Text + " where sales_id=" + txtsalesid.Text + "", con);

        //           try
        //           {
        //               up.ExecuteNonQuery();
        //               MessageBox.Show("insert successful");
        //           }
        //           catch (SqlException ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }
        //}
        //       public void delete()
        //       {
        //           SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //           con.Open();
        //           String query = "delete from sales_item where sales_id =" + txtsalesid.Text + "";
        //           SqlCommand cmd = new SqlCommand(query, con);
        //           try
        //           {
        //               cmd.ExecuteNonQuery();
        //               MessageBox.Show("delete successful");

        //           }
        //           catch (SqlException ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }
        //           String query2 = "delete from sales where sales_id =" + txtsalesid.Text + "";
        //           SqlCommand cmd2 = new SqlCommand(query2, con);
        //           try
        //           {
        //               cmd2.ExecuteNonQuery();
        //               MessageBox.Show("delete successful");

        //           }
        //           catch (SqlException ex)
        //           {
        //               MessageBox.Show(ex.Message);
        //           }

        //           con.Close();

        //       }
        public void search()
        {

            SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from sales_item where sales_id=" + textBox7.Text + "", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("enter id to search");

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
          // txtsalesid.Text = row.Cells[1].Value.ToString();
          //  txtquantity.Text = row.Cells[2].Value.ToString();
          //  txtitemid.Text = row.Cells[3].Value.ToString();
          //txtsoldp.Text = row.Cells[4].Value.ToString();
            //dtexpirydate.Text= row.Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete();
            //display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update();
            //display();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
 //           display();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
   //         search();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
           display();
        }
    }
}
