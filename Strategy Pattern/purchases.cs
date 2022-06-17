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
    public partial class purchases : Form , StrategyInterface
    {
        SqlConnection con;


        public DataTable Execute(string a, int id)
        {
            ProjConn.getcon();
            return ProjConn.Show(a, id);

        }

        public SqlConnection getconnection()
        {
            con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
            con.Open();
            return con;
        }
        public static int adminid;
        public int item_id;

        public purchases()
        {
            InitializeComponent();
        }

        private void purchases_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_StoreManagementDataSet3.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.project_StoreManagementDataSet3.items);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP-PC\HAQUE;Initial Catalog=OOAD_Store_management_system;Integrated Security=True");

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
            SqlCommand cmd = new SqlCommand("insert into purchases(item_id,quantity,user_id)values(" + item_id + ", '" + txtquantity.Text + "'," + adminid + ")", con);
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

        }  //public void addstock()
           //{
           //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    // String query = "";
        //    SqlCommand cmd = new SqlCommand("insert into stock(item_id, quantity,user_id)" +
        //        "values(" + txtitemid.Text + ", " + txtquantity.Text + ", " + adminid + ")", con);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("insert successful");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    con.Close();


        //}

        //public void additems()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    // String query = "";
        //    SqlCommand cmd = new SqlCommand("insert into items(name, purchase_price, selling_price,user_id,expiry_date)" +
        //        "values('" + txtname.Text + "', " + txtpurchasep.Text + ", " + txtsellingp.Text + "," + adminid + ",'"+this.dtdate.Text+"')", con);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("insert successful");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    con.Close();


        //}
        //public void update()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    SqlCommand up = new SqlCommand("Update purchases set item_id=" + txtitemid.Text + ",user_id=" + adminid + ", quantity=" + txtquantity.Text + " where purchase_id=" + txtpurchaseid.Text + "", con);

        //    try
        //    {
        //        up.ExecuteNonQuery();
        //        MessageBox.Show("insert successful");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //public void updateitems()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    SqlCommand up = new SqlCommand("Update items set name='" + txtname.Text + "',user_id=" + adminid + ", purchase_price=" + txtpurchasep.Text + ",selling_price=" + txtsellingp.Text + " where item_id=" + txtitemid.Text + "",con);

        //    try
        //    {
        //        up.ExecuteNonQuery();
        //        MessageBox.Show("insert successful");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    // objclass.command("Update tblAdminLogin set username='" + txtUsername.Text + "', password='" + txtPassword.Text + "' where userid='" + txtUserId.Text + "'");
        //}
        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
            //addstock();
            //display();
            //addP();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update();
            //display();
            ////MessageBox.Show("hahahahaha");
        }
        public void deleteitems()
        {
            //SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

            //con.Open();
            //String query = "delete from items where item_id =" + txtitemid.Text + "";
            //SqlCommand cmd = new SqlCommand(query, con);
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("delete successful");
            //    display();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();

        }
        //public void delete()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    String query = "delete from purchases where purchase_id =" + txtpurchaseid.Text + "";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("delete successful");
             
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    con.Close();

        //}

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete();
            //display();
        }
        //public void search()
        //{

        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    try
        //    {
        //        SqlDataAdapter adp = new SqlDataAdapter("select * from purchases where purchase_id=" + textBox7.Text + "", con);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("enter id to search");

        //    }
        //}
        //public void searchitems()
        //{

        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    try
        //    {
        //        SqlDataAdapter adp = new SqlDataAdapter("select * from items where item_id=" + textBox1.Text + "", con);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        dataGridView2.DataSource = dt;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("enter id to search");

        //    }
        //}

        private void btndisplay_Click(object sender, EventArgs e)
        {
           // display();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //search();
        }
       
        //public void display()
        //    {
        //        getconnection();
        //        SqlDataAdapter adp = new SqlDataAdapter("select * from purchases", con);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //        con.Close();
        //    }
        //public void showitems()
        //{
        //    getconnection();
        //    SqlDataAdapter adp = new SqlDataAdapter("select * from items", con);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    dataGridView2.DataSource = dt;
        //    con.Close();
        //}

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtexpirydate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //txtitemid.Text = row.Cells[1].Value.ToString();

            //txtname.Text = row.Cells[2].Value.ToString();
            //txtpurchasep.Text = row.Cells[3].Value.ToString();

            //txtsellingp.Text = row.Cells[4].Value.ToString();
            //txtquantity.Text = row.Cells[0].Value.ToString();
            //dtexpirydate.Text= row.Cells[5].Value.ToString();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            //additems();
            //showitems();
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            //deleteitems();
            //showitems();
        }

        private void updateitem_Click(object sender, EventArgs e)
        {
            //updateitems();
            //showitems();
           
        }

        private void displayitem_Click(object sender, EventArgs e)
        {

            //showitems();

        }

        private void button8_Click(object sender, EventArgs e)
        {
           // searchitems();
        }
    }
    
}
