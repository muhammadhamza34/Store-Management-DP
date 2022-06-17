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
    public partial class s : Form
    {
        admins_update au;

        SqlConnection con;

        //public SqlConnection getconnection()
        //{
        //    con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    return con;
        //}
        public static int adminid;
        string buttonclick;
        public s()
        {
            InitializeComponent();
        }
        
        SqlDataAdapter adp;
        string conStr = @"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True";

        private void Admin_Load(object sender, EventArgs e)
        {
            adminid = Form1.id;

            try
            {//yahan pr
                //con = new SqlConnection(conStr);
                
                label5.Text = "Connection on";
            }
            catch (Exception)
            {

                label5.Text = "Connection off";
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(adminusername);
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 objform1 = new Form1();
            this.Hide();
            objform1.Show();
        }
        public void delete()
        {

            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);
            }
            catch (Exception)
            {

                MessageBox.Show("please select any row");
            }
           
        }
                                                                    /*
                                                                     * 
                                                                     * 
                                                                     * THIS IS SINGLE TON PATTERN USE FOR PROJCONN CLASSS
                                                                     * 
                                                                     * 
                                                                     */
             
        private void btnpurchases_Click(object sender, EventArgs e)
        {
            ProjConn.getcon();
            buttonclick = "purchases";
            dataGridView1.DataSource = ProjConn.display("Select * from purchases");
            /*
            //purchases objpurchases = new purchases();
            //this.Hide();
            //objpurchases.Show();
            buttonclick = "purchases";
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("Select * from purchases", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */
        }

        private void btnsalesmen_Click(object sender, EventArgs e)
        {
            ProjConn.getcon();
            buttonclick = "salesmen";
            dataGridView1.DataSource = ProjConn.display("Select * from salesmen");
            /*
            //salesmen objsalesmen = new salesmen();
            //this.Hide();
            //objsalesmen.Show();
            buttonclick = "salesmen";
            
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("Select * from salesmen", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */
        }

        private void btnpurchasemen_Click(object sender, EventArgs e)
        {
            ProjConn.getcon();
            buttonclick = "purchasemen";
            dataGridView1.DataSource = ProjConn.display("Select * from purchasemen");
            /*
            // purchasemen objpurchasemen = new purchasemen();
            //this.Hide();
            //objpurchasemen.Show();
            buttonclick = "purchasemen";
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("Select * from purchasemen", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

            ProjConn.getcon();
            buttonclick = "admins";
           // dataGridView1.DataSource = ProjConn.display("select persons.name,admins.username,admins.password,admins.admin_id ,persons.phone,persons.email,persons.dob,persons.designnation,persons.person_id from admins left outer join persons on admins.person_id = persons.person_id");
            dataGridView1.DataSource = ProjConn.display("select * from admins");            
            
            /*
             
            //  Admins objAdmins = new Admins();
            //this.Hide();
            //objAdmins.Show();
            buttonclick = "admins";
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("select persons.name,admins.username,admins.password,admins.admin_id ,persons.phone,persons.email,persons.dob,persons.designnation,persons.person_id from admins left outer join persons on admins.person_id = persons.person_id", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            ProjConn.getcon();
            buttonclick = "stock";
            dataGridView1.DataSource = ProjConn.display("Select * from stock");
            /*
            //stock objstock = new stock();
            //this.Hide();
            //objstock.Show();
            buttonclick = "stock";
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("Select * from stock", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */

        }

        private void btnsales_Click(object sender, EventArgs e)
        {

            ProjConn.getcon();
            buttonclick = "sales";
            dataGridView1.DataSource = ProjConn.display("Select * from sales");
            /*
               
            //    sales objsales = new sales();
            //    this.Hide();
            //   objsales.Show();
            buttonclick = "sales";
            con = new SqlConnection(conStr);
            con.Open();
            adp = new SqlDataAdapter("Select * from sales", con);
            DataTable dto = new DataTable();
            //dt.Clear();
            adp.Fill(dto);
            dataGridView1.DataSource = dto;
            con.Close();
             */
        }

        private void btnexpenses_Click(object sender, EventArgs e)
        {
            //expenses objexpenses = new expenses();
            //this.Hide();
            //objexpenses.Show();
            try
            {
                ProjConn.getcon();
                buttonclick = "expenses_type";
                dataGridView1.DataSource = ProjConn.display("Select * from expenses_type");
               
                /*
                
                con = new SqlConnection(conStr);
                con.Open();
                adp = new SqlDataAdapter("Select * from expenses_type", con);
                DataTable dto = new DataTable();
                //dt.Clear();
                adp.Fill(dto);
                dataGridView1.DataSource = dto;
                con.Close();
                 */
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            try
            {
                ProjConn.getcon();
                dataGridView1.DataSource = ProjConn.display("Select * from expenses");
                /*
                buttonclick = "expenses";
                con = new SqlConnection(conStr);
                con.Open();
                adp = new SqlDataAdapter("Select * from expenses", con);
                DataTable dto = new DataTable();
                //dt.Clear();
                adp.Fill(dto);
                dataGridView1.DataSource = dto;
                con.Close();
                 */
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            try
            {
                buttonclick = "items";
               
               
                ProjConn.getcon();
                dataGridView1.DataSource = ProjConn.display("Select * from items");
                //con = new SqlConnection(conStr);
                //con.Open(); DBA
               // adp = new SqlDataAdapter("Select * from items", con); DBA
                //DataTable dto = new DataTable(); DBA
                //dt.Clear();
               // adp.Fill(dto);
                //on.Close();
               

                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalary_payment_Click(object sender, EventArgs e)
        {
            try
            {
                buttonclick = "salary_payments";
                ProjConn.getcon();
                ProjConn.display("Select * from salary_payments");
                /*
                con = new SqlConnection(conStr);
                con.Open();
                adp = new SqlDataAdapter("Select * from salary_payments", con);
                DataTable dto = new DataTable();
                //dt.Clear();
                adp.Fill(dto);
                dataGridView1.DataSource = dto;
                con.Close();
                 */
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpersons_Click(object sender, EventArgs e)
        {
            try
            {
                ProjConn.getcon();
                buttonclick = "persons";
                /*
                con = new SqlConnection(conStr);
                con.Open();
                adp = new SqlDataAdapter("Select * from persons", con);
                DataTable dto = new DataTable();
                //dt.Clear();
                adp.Fill(dto);
                 */
                dataGridView1.DataSource = ProjConn.display("Select * from persons"); ;
                //con.Close();
                 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsales_items_Click(object sender, EventArgs e)
        {
            try
            {
                ProjConn.getcon();
                buttonclick = "sales_item";
                /*
                con = new SqlConnection(conStr);
                con.Open();
                adp = new SqlDataAdapter("Select * from sales_item", con);
                DataTable dto = new DataTable();
                //dt.Clear();
                adp.Fill(dto);
                 * con.Close();
                 */
                dataGridView1.DataSource = ProjConn.display("Select * from sales_item");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
                                                                        /*
                                                                        * 
                                                                        * 
                                                                        * THIS IS FASAAD PATTERN 
                                                                        * 
                                                                        * 
                                                                        * 
                                                                        */
        private void btnadd_Click(object sender, EventArgs e)
        {
            fasaad fm = new fasaad();
            if (buttonclick == "purchases")
            {
               
                this.Hide();

                fm.purchases();
                
            }
            else if (buttonclick == "salesmen")
            {   
                /*
                salesmen objsalesmen = new salesmen();
                this.Hide();
                objsalesmen.Show();
                 */
                this.Hide();
                fm.Salesman();
            }
            else if (buttonclick == "purchasemen")
            {  
                /*purchasemen objpurchasemen = new purchasemen();
                this.Hide();
                objpurchasemen.Show();
                 */
                this.Hide();
                fm.Purchaseman();
            }
            
            
            else if (buttonclick == "sales")
            {
                /*
                sales objsales = new sales();
                this.Hide();
                objsales.Show();
                 */
                this.Hide();
                fm.sell();
            }
            
            else if (buttonclick == "items")
            {
                /*
                items objitems = new items();
                this.Hide();
                objitems.Show();
                 */
                this.Hide();
                fm.item();
            }

            else if (buttonclick == "persons")
            {
                /*
                persons objpersons = new persons();
                this.Hide();
                objpersons.Show();
                 */
                try
                {
                    this.Hide();
                    fm.Person();

                }
                catch (Exception ex)
                {
                    
                    throw;
                }
                

            }

            else if (buttonclick == "admins")
            {
                /*
                Admins objAdmins = new Admins();
                this.Hide();
                objAdmins.Show();
                 */
                this.Hide();

            }

            else if (buttonclick == "stock")
            {
                /*
                stock objstock = new stock();
                this.Hide();
                objstock.Show();
                 */
            }

                else if (buttonclick == "expenses")
            {
                /*
                expenses objexpenses = new expenses();
                this.Hide();
                objexpenses.Show();
                 */
            }
            else if (buttonclick == "expenses_type")
            {
                /*
                expenses_type objexptype = new expenses_type();
                this.Hide();
                objexptype.Show();
                 */

            }
            else if (buttonclick == "salary_payments")
            {
                /*
                salary_payments objsp = new salary_payments();
                this.Hide();
                objsp.Show();
                 */
            }
            
            else if (buttonclick == "sales_item")
            {
                /*
                sales_items objsi = new sales_items();
                this.Hide();
                objsi.Show();
                 */
            }
            else
            {
                MessageBox.Show("select the table first");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (buttonclick == "admins")
            {
                au.Show();

            }
            else { MessageBox.Show("error"); }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (buttonclick == "admins")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from admins where admin_id like'%" + textBox1.Text + "%' or person_id like '%" + textBox1.Text + "%' or username like '%" + textBox1.Text + "%'" +
                    " or user_id like '%" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "expenses")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from expenses where expenses_id like'%" + textBox1.Text + "%' or billing_month like '%" + textBox1.Text + "%'or amount like '%" + textBox1.Text + "%' or user_id like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "expenses_type")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from expenses_type where  expenses_type_id  like'%" + textBox1.Text + "%' or name like '%" + textBox1.Text + "%'or user_id like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "items")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from items where  item_id  like'%" + textBox1.Text + "%' or name like '%" + textBox1.Text + "%' or purchase_price like '" + textBox1.Text + "' or selling_price like '" + textBox1.Text + "'or user_id like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "persons")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from persons where name like '%" + textBox1.Text + "%' or designnation like '%" + textBox1.Text + "%' or phone like '%" + textBox1.Text + "%' or email like '%" + textBox1.Text + "%' or person_id like '%" + textBox1.Text + "%'or user_id like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "purchasemen")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from purchasemen where purchasemen_id like '%" + textBox1.Text + "%' or person_id like '%" + textBox1.Text + "%' or username like '%" + textBox1.Text + "%'" +
                    " or user_id like '%" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "salary_payments")
            {


                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from salary_payments where salary_payment_id like'%" + textBox1.Text + "%' or person_id like '%" + textBox1.Text + "%' or salary like '%" + textBox1.Text + "%' or user_id like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "sales")
            {

                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from sales where sales_id like'%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "sales_item")
            {

                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from sales_item where sales_item_id =" + textBox1.Text + " or sales_id = " + textBox1.Text + " or item_id =" + textBox1.Text + " or quantity =" + textBox1.Text + " or sold_price =" + textBox1.Text + " or user_id =" + textBox1.Text + "", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "purchases")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from purchases where  purchase_id  like'%" + textBox1.Text + "%' or item_id like '%" + textBox1.Text + "%' or quantity like '" + textBox1.Text + "'or user_id like '%" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "salesmen")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from salesmen where salesmen_id like '%" + textBox1.Text + "%' or person_id like '%" + textBox1.Text + "%' or username like '%" + textBox1.Text + "%'" +
                    " or user_id like '%" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (buttonclick == "stock")
            {
                con = new SqlConnection(conStr);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from stock where  stock_id  like'%" + textBox1.Text + "%' or item_id like '%" + textBox1.Text + "%' or quantity like '" + textBox1.Text + "'or user_id like '%" + textBox1.Text + "%' ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("select any button from menu");
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonclick == "admins")
            {
                try
                {
                     au = new admins_update();
                    au.dgvr = dataGridView1.Rows[e.RowIndex];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonclick == "expenses")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "expenses_type")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "items")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "persons")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "purchasemen")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "salary_payments")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "sales")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "sales_item")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (buttonclick == "purchases")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "salesmen")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonclick == "stock")
            {
                try
                {

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("select any button from menu");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemDetails itd = new ItemDetails();
            this.Hide();
            itd.Show();
        }
    }
}
