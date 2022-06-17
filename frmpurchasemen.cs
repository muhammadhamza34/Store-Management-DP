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
    public partial class frmpurchasemen : Form
    {
        public frmpurchasemen()
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

        private void frmpurchasemen_Load(object sender, EventArgs e)
        {

            adminid = Form1.id;

        }

        private void btnback_Click(object sender, EventArgs e)
        {

            s objAdmin = new s();
            this.Hide();
            objAdmin.Show();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            // String query = "";
            SqlCommand cmd = new SqlCommand("insert into purchases(item_id, quantity,user_id)" +
                "values(" + txtitemid.Text + ", " + txtquantity.Text + ", " + adminid + ")", con);
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
        public void addstock()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            // String query = "";
            SqlCommand cmd = new SqlCommand("insert into stock(item_id, quantity,user_id)" +
                "values(" + txtitemid.Text + ", " + txtquantity.Text + ", " + adminid + ")", con);
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

        public void additems()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            // String query = "";
            SqlCommand cmd = new SqlCommand("insert into items(name, purchase_price, selling_price,user_id)" +
                "values('" + txtname.Text + "', " + txtpurchasep.Text + ", " + txtsellingp.Text + "," + adminid + ")", con);
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
        public void update()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            SqlCommand up = new SqlCommand("Update purchases set item_id=" + txtitemid.Text + ",user_id=" + adminid + ", quantity=" + txtquantity.Text + " where purchase_id=" + txtpurchaseid.Text + "", con);

            try
            {
                up.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateitems()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            SqlCommand up = new SqlCommand("Update items set name='" + txtname.Text + "',user_id=" + adminid + ", purchase_price=" + txtpurchasep.Text + ",selling_price=" + txtsellingp.Text + " where item_id=" + txtitemid.Text + "", con);

            try
            {
                up.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // objclass.command("Update tblAdminLogin set username='" + txtUsername.Text + "', password='" + txtPassword.Text + "' where userid='" + txtUserId.Text + "'");
        }
        public void deleteitems()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            String query = "delete from items where item_id =" + txtitemid.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete successful");
                display();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public void delete()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            String query = "delete from purchases where purchase_id =" + txtpurchaseid.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete successful");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
        public void search()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from purchases where purchase_id=" + textBox7.Text + "", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("enter id to search");

            }
        }
        public void searchitems()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from items where item_id=" + textBox1.Text + "", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("enter id to search");

            }
        }

        public void display()
        {
            getconnection();
            SqlDataAdapter adp = new SqlDataAdapter("select * from purchases", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void showitems()
        {
            getconnection();
            SqlDataAdapter adp = new SqlDataAdapter("select * from items", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
            addstock();
            display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            display();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
            display();

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            display();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search();

        }

        private void additem_Click(object sender, EventArgs e)
        {
            additems();
            showitems();

        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            deleteitems();
            showitems();

        }

        private void updateitem_Click(object sender, EventArgs e)
        {
            updateitems();
            showitems();

        }

        private void displayitem_Click(object sender, EventArgs e)
        {

            showitems();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            searchitems();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
