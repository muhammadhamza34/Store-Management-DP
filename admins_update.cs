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
    public partial class admins_update : Form
    {
        public admins_update()
        {
            InitializeComponent();
        }
        public DataGridViewRow dgvr;
        private void admins_update_Load(object sender, EventArgs e)
        {

            
            cbname.Text = dgvr.Cells[0].Value.ToString();
            txtusername.Text = dgvr.Cells[1].Value.ToString();
            txtpassword.Text = dgvr.Cells[2].Value.ToString();
            txtadmin_id.Text = dgvr.Cells[3].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        }

        //public void updateadmins()
        //{
        //    qlconnection con = new sqlconnection(@"server=laptop-vt6gn1tr\sqlexpress;database=project_storemanagement;integrated security=true;");
        //    con.open();
        //    sqlcommand up = new sqlcommand("update admins set username='" + txtusername.text + "',password='" + txtpassword.text + "',user_id=" + adminid + ",admin_id=" + txtadmin_id.text + " where person_id=" + txtperson_id.text + "", con);

        //    try
        //    {
        //        up.executenonquery();
        //        messagebox.show("insert successful");
        //    }
        //    catch (sqlexception ex)
        //    {
        //        messagebox.show(ex.message);
        //    }

        //    // objclass.command("update tbladminlogin set username='" + txtusername.text + "', password='" + txtpassword.text + "' where userid='" + txtuserid.text + "'");
        //}
    }
}
