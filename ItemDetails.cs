using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class ItemDetails : Form
    {
        public ItemDetails()
        {
            InitializeComponent();
        }

        public List<string> st = new List<string>();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

                                                                    /*
                                                                      * 
                                                                      * 
                                                                      * Here Strategy PAttern starts 
                                                                      * 
                                                                      * 
                                                                      * 
                                                                      */



            ContextStrategy Kontext;
            
            if (radioButton1.Checked)
            {
                int id = Convert.ToInt32(textBox1.Text);
                Kontext = new ContextStrategy(new purchases());
                dataGridView1.DataSource = Kontext.exeOP("select * from purchases where item_id =" , id);
                ProjConn.Close();
                st.Insert(0,"select * from purchases where item_id=" +id+"");
               
                //dataGridView1.DataSource = ProjConn.display("select * from purchases where item_id =" + id);

            }

            else if (radioButton2.Checked)
            {
                int id = Convert.ToInt32(textBox1.Text);
                Kontext = new ContextStrategy(new sales_items());
                dataGridView1.DataSource = Kontext.exeOP("select * from sales_item where item_id =", id);
                ProjConn.Close();
                st.Insert(0,"select * from sales_item where item_id=" + id + "");
                
                
            }
         


        }

         public UndoRedoRecv on = new UndoRedoRecv();
       // public CommandLister cml;


        /*
          * 
          * 
          *FROM You can seen proxy pattern and commmand pattern aswell
          * 
          * 
          * 
          */

        public CommanderListerInterface coml = new Proxy(); 
        Undo un = new Undo();
        Redo re = new Redo();
        
        
        private void ItemDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'store_management_systemDataSet6.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.store_management_systemDataSet6.items);
            st.Add("Select * from items");

             

            //cml = new CommandLister();
           


            dataGridView1.DataSource = ProjConn.display("select * from items");
            ProjConn.Close();
            // TODO: This line of code loads data into the 'oOAD_Store_management_systemDataSet1.items' table. You can move, or remove it, as needed.
           // this.itemsTableAdapter.Fill(this.store_management_systemDataSet6.items);
            // TODO: This line of code loads data into the 'oOAD_Store_management_systemDataSet.persons' table. You can move, or remove it, as needed.
           // this.personsTableAdapter.Fill(this.oOAD_Store_management_systemDataSet.persons);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {
                textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e) // UNDO
        {
            un.UndoBhai(on);
          // cml.addCommand(un);
                                    //cml.addCommand(ref st);
            coml.addCommand(ref st);
            dataGridView1.DataSource = coml.ExecCommand(un);
           //dataGridView1.DataSource =  cml.ExeCommand(un);
        }

        private void button4_Click(object sender, EventArgs e) // REDO
        {

           // re.RedoBhai(on);
            //coml.addCommand(ref st);
            //cml.addCommand(re);

            //dataGridView1.DataSource =  coml.ExeCommand(re);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
