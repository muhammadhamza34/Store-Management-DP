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
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter adp;
        string conStr = @"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True";
        public static int adminid;

        private void items_Load(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
                s objAdmin = new s();
                this.Hide();
                objAdmin.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");

            con.Open();
           
            SqlCommand cmd = new SqlCommand("insert into items(name,purchase_price,selling_price,user_id)values('" + txtname.Text + "', " + txtpp.Text + "," +
                " " + txtsp.Text + "," + adminid + ")", con);
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
                SqlCommand sqlCommand = new SqlCommand("Select item_id from items where name='" + txtname.Text + "'", con);
                SqlDataReader reader3 = sqlCommand.ExecuteReader();
                while (reader3.Read())
                {
                    id = Convert.ToInt32(reader3[0].ToString());

                    MessageBox.Show("item id is = " + Convert.ToString(id));
                }
                reader3.Close();
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

            SqlCommand cmd = new SqlCommand("insert into items(name,purchase_price,selling_price,user_id)values('" + txtname.Text + "', " + txtpp.Text + "," +
                " " + txtsp.Text + "," + adminid + ")", con);
        
        
        }

    }

    public abstract class Addingitems : Form
    {
        public string itname;
        public string p_p;
        public string s_p;

        public abstract void execute();

    }

    public class UndoAdditem : Addingitems
    {
        public void TakingVal(string itn, string pp, string sp)
        {
            this.itname = itn;
            this.p_p = pp;
            this.s_p = sp;

            
        }
        public override void execute()
        {
            items i1 = new items();
            i1.add();
        }
    
    }

    public class RedoAdditem : Addingitems
    {

        public void TakingVal(string itn, string pp, string sp)
        {
            this.itname = itn;
            this.p_p = pp;
            this.s_p = sp;        
        }
        public override void execute()
        {

        }
    
    }

    public class Cmd_handler
    {
        List<Addingitems> no_items = new List<Addingitems>();

        public void addItemToList(Addingitems it)
        {
            no_items.Add(it);
        
        }

        public void ExeuteItemsInListToDB(Addingitems it)
        { 
            
        
        }
    
    }
}
