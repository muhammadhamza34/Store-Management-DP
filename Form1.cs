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

    public partial class Form1 : Form
    {
        public static int id;
        Form1 f1 = null;

        public Form1()
        {
            InitializeComponent();
            
        }

      
        SqlConnection con;
        
        public SqlConnection getconnection()
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
                con.Open();
                label2.Text = "Conncection open";
                
            }
            catch (Exception)
            {

                label2.Text = "no connection";
            }
            return con;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getconnection();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
          //  this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //getconnection();

            

                                                                                /*
                                                                                  * 
                                                                                  * 
                                                                                  *FROM HERE STARTS FACTORY DEMO PATTERN
                                                                                  * 
                                                                                  * 
                                                                                  * 
                                                                                  */

             // this is LoginFactory (login CHecker) 
            LoginChecker l1 = new LoginChecker();
            Login lo;

            if (rbadmin.Checked)
            {
                lo = l1.radioButton("admin");

               // lo.F_Log(txtusername.Text, txtpassword.Text, con);
                 
                
                SqlDataAdapter adp = new SqlDataAdapter("Select * from admins where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count == 1)
                { 
                  // name = txtusername.Text;
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand("Select admin_id from admins where username='" + txtusername.Text + "'", con);
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                       
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader[0].ToString());
                            
                           // MessageBox.Show(Convert.ToString(id));
                        }
                        reader.Close();
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    //  objlogin.username = txtusername.Text.ToString();
                    //objlogin.admin = txtusername.Text.ToString();
                    //MessageBox.Show("Login Successfull");
                      s objAdmin = new s();
                   
                     this.Hide();
                    objAdmin.Show();
                  

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                 
            }
            else if (rbsalesmen.Checked)
            {
               lo =  l1.radioButton("sale");
               lo.F_Log(txtusername.Text, txtpassword.Text, con);
                /*
                SqlDataAdapter adp = new SqlDataAdapter("Select * from salesmen where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand("Select salesmen_id from salesmen where username='" + txtusername.Text + "'", con);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader[0].ToString());

                            // MessageBox.Show(Convert.ToString(id));
                        }
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Login Successfull");
                    Frmsalesmen objfrmsalesmen = new Frmsalesmen();
                    this.Hide();
                    objfrmsalesmen.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                 */
            }
            else if (rbpurchasemen.Checked)
            {
                lo = l1.radioButton("purchase");
                lo.F_Log(txtusername.Text, txtpassword.Text, con);
                
                //SqlDataAdapter adp = new SqlDataAdapter("Select * from purchasemen where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ", con);
                //DataTable dt = new DataTable();
                //adp.Fill(dt);
                //if (dt.Rows.Count == 1)
                //{
                //    try
                //    {
                //        SqlCommand sqlCommand = new SqlCommand("Select purchasemen_id from purchasemen where username='" + txtusername.Text + "'", con);
                //        SqlDataReader reader = sqlCommand.ExecuteReader();

                //        while (reader.Read())
                //        {
                //            id = Convert.ToInt32(reader[0].ToString());

                //            // MessageBox.Show(Convert.ToString(id));
                //        }
                //    }

                //    catch (SqlException ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }

                //    MessageBox.Show("Login Successfull");
                //    frmpurchasemen objFrmAdmin = new frmpurchasemen();
                //   this.Hide();
                //   objFrmAdmin.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Username or Password");
                //}
                
            }
            else { MessageBox.Show("Please Select any radio button"); }

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbpurchasemen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbsalesmen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void rbadmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }

                                                                                /*
                                                                                  * 
                                                                                  * 
                                                                                  * THIS LOGIN CHECKER IS FACTORY CLASS IN FACTORY PATTERN
                                                                                  * 
                                                                                  * 
                                                                                  * 
                                                                                  */
    public class LoginChecker 
    {
        public string loger;

        public Login radioButton(string btn)
        {
            if (btn == "admin")
            {
                return new AdminLogin();
            }

            else if (btn == "sale")
            {
                return new SalesmanLogin();
            }

            else if (btn =="purchase" )
            {

                return new PurchasemenLogin();
            }

            else
            {
                MessageBox.Show("please check anyone");
                return null;
            }
        }

        

        
        
        

        
       
       
    }
                                                                                /*
                                                                                  * 
                                                                                  * 
                                                                                  * THIS LOGIN CLASS IS ABSTRACT CLASS IN FACTORY PATTERN
                                                                                  * 
                                                                                  * 
                                                                                  * 
                                                                                  */

    public abstract class Login : Form
    {
        public static int id;
        public abstract void F_Log(string usr_n, string usr_pss, SqlConnection con);
        
    }


                                                                                /*
                                                                                  * 
                                                                                  * 
                                                                                  * THESE ARE THE CONCRETE CLASSES FOR ABOVE FACTORY ABS CLASS OF LOGIN
                                                                                  * 
                                                                                  * 
                                                                                  * 
                                                                                  */

    public  class AdminLogin: Login
    {
        public override void F_Log(string usr_n, string usr_pss, SqlConnection con)
        {


            SqlDataAdapter adp = new SqlDataAdapter("Select * from admins where username='" + usr_n + "' and password='" + usr_pss + "' ", con);
            DataTable dt = ProjConn.display("Select * from admins where username='" + usr_n + "' and password='" + usr_pss + "' ");
            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                // name = txtusername.Text;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("Select admin_id from admins where username='" + usr_n + "'", con);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0].ToString());

                        // MessageBox.Show(Convert.ToString(id));
                    }
                    reader.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //  objlogin.username = txtusername.Text.ToString();
                //objlogin.admin = txtusername.Text.ToString();
                //MessageBox.Show("Login Successfull");
                s objAdmin = new s();

                this.Hide();
                objAdmin.Show();


            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }

    public class PurchasemenLogin : Login
    {
        public override void F_Log(string usr_n, string usr_pss, SqlConnection con)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from purchasemen where username='" + usr_n + "' and password='" + usr_pss + "' ", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("Select purchasemen_id from purchasemen where username='" + usr_n + "'", con);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0].ToString());

                        // MessageBox.Show(Convert.ToString(id));
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Login Successfull");
               frmpurchasemen objFrmAdmin = new frmpurchasemen();
               this.Hide();
                objFrmAdmin.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }


    public  class SalesmanLogin : Login
    {
        public override void F_Log(string usr_n, string usr_pss, SqlConnection con)
        {

            SqlDataAdapter adp = new SqlDataAdapter("Select * from salesmen where username='" + usr_n + "' and password='" + usr_pss + "' ", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("Select salesmen_id from salesmen where username='" + usr_n + "'", con);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0].ToString());

                        // MessageBox.Show(Convert.ToString(id));
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Login Successfull");
                Frmsalesmen objfrmsalesmen = new Frmsalesmen();
                this.Hide();
                objfrmsalesmen.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
          
        }
    }
}
