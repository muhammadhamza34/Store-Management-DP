﻿using System;
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
    public partial class purchasemen : Form
    {
        SqlConnection con;

        public SqlConnection getconnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
            con.Open();
            return con;
        }
        public purchasemen()
        {
            InitializeComponent();
        }
        public static int adminid;
        public static int person_id;

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

        private void btnsearch_Click(object sender, EventArgs e)
        {


            //SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

            //con.Open();
            //try
            //{
            //    SqlDataAdapter adp = new SqlDataAdapter("select * from purchasemen where purchasemen_id=" + textBox7.Text + "", con);
            //    DataTable dt = new DataTable();
            //    adp.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            //catch
            //{
            //    MessageBox.Show("enter id to search");

            //}
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            //display();
        }
        //public void display()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    // SqlDataAdapter adp = new SqlDataAdapter("select * from salesmen", con);
        //    SqlDataAdapter adp = new SqlDataAdapter("select purchasemen.purchasemen_id,persons.name, persons.phone,persons.email,purchasemen.username,purchasemen.password,persons.dob,persons.designnation,purchasemen.user_id,persons.person_id from purchasemen left outer join persons on purchasemen.person_id = persons.person_id", con);

        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}
        //public void addpersons()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("insert into persons(name,designnation,phone,email,user_id)" +
        //        "values('" + txtname.Text + "', '" + txtdesignation.Text + "'," + txtphone.Text + ",'" + txtemail.Text + "', " + adminid + ")", con);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("insert successful");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("Select person_id from persons where phone=" + txtphone.Text + "", con);
        //        SqlDataReader reader = sqlCommand.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            person_id = Convert.ToInt32(reader[0].ToString());

        //            MessageBox.Show(Convert.ToString(person_id));
        //        }
        //    }

        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    con.Close();


        //}
        //public void addpurchasemen()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

        //    con.Open();
        //    // String query = "";
        //    SqlCommand cmd = new SqlCommand("insert into purchasemen(person_id,username,password,user_id)values(" + person_id + ", '" + txtusername.Text + "', '" + txtpassword.Text + "', " + adminid + ")", con);
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
        //public void updatepersons()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    SqlCommand up = new SqlCommand("Update persons set name='" + txtname.Text + "',designnation='" + txtdesignation.Text + "',phone=" + txtphone.Text + ",email='" + txtemail.Text + "',user_id= " + adminid + " where person_id=" + txtperson_id.Text + "", con);

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
        //public void updatepurchasemen()
        //{
        //    SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");
        //    con.Open();
        //    SqlCommand up = new SqlCommand("Update purchasemen set username='" + txtusername.Text + "',password='" + txtpassword.Text + "',user_id=" + adminid + " where person_id=" + txtperson_id.Text + "", con);

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




        private void btndelete_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;");

            //con.Open();
            //String query = "delete from purchasemen where username ='" + txtusername.Text + "'";
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

        private void purchasemen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store_management_systemDataSet2.persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter1.Fill(this.store_management_systemDataSet2.persons);
            // TODO: This line of code loads data into the 'project_StoreManagementDataSet1.persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.project_StoreManagementDataSet1.persons);
            adminid = Form1.id;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //txtname.Text = row.Cells[1].Value.ToString();
            //txtphone.Text = row.Cells[2].Value.ToString();
            //txtemail.Text = row.Cells[3].Value.ToString();
            //txtusername.Text = row.Cells[4].Value.ToString();
            //txtpassword.Text = row.Cells[5].Value.ToString();
            //txtdesignation.Text = row.Cells[7].Value.ToString();
            ////txtadmin_id.Text = row.Cells[8].Value.ToString();
            //txtperson_id.Text = row.Cells[9].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
            //addpersons();
            //addpurchasemen();
            //display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        //    updatepersons();
        //    updatepurchasemen();
        //    display();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Select person_id from persons where name='" + cbname.Text + "'", con);
                SqlDataReader reader2 = sqlCommand.ExecuteReader();
                while (reader2.Read())
                {
                    person_id = Convert.ToInt32(reader2[0].ToString());

                    MessageBox.Show(Convert.ToString(person_id));
                }
                reader2.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand cmd = new SqlCommand("insert into purchasemen(person_id,username,password,user_id)values(" + person_id + ", '" + txtusername.Text + "'," +
                " '" + txtpassword.Text + "'," + adminid + ")", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                int id;
                SqlCommand sqlCommand = new SqlCommand("Select purchasemen_id from purchasemen where username='" + txtusername.Text + "'", con);
                SqlDataReader reader3 = sqlCommand.ExecuteReader();
                while (reader3.Read())
                {
                    id = Convert.ToInt32(reader3[0].ToString());

                    MessageBox.Show("purchasemen id is = "+Convert.ToString(id));
                }
                reader3.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }

    }
}
