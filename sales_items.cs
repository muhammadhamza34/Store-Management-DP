using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace StoreManagementSystem

{
    public partial class sales_items : Form , StrategyInterface
    {
        public sales_items()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlDataAdapter adp;
        string conStr = @"Server=LAPTOP-VT6GN1TR\SQLEXPRESS;Database=Project_StoreManagement;Integrated Security=true;";
        public static int adminid;


       public DataTable Execute(string a, int id)
       {
           ProjConn.getcon();
           
           return ProjConn.Show(a, id);
       }

        private void sales_items_Load(object sender, EventArgs e)
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
    }
}
