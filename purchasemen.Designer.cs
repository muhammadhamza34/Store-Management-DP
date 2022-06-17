namespace StoreManagementSystem
{
    partial class purchasemen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtadmin_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.store_management_systemDataSet2 = new StoreManagementSystem.Store_management_systemDataSet2();
            this.personsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter1 = new StoreManagementSystem.Store_management_systemDataSet2TableAdapters.personsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(909, 414);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(56, 19);
            this.btndisplay.TabIndex = 40;
            this.btndisplay.Text = "display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Visible = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(909, 382);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(909, 335);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(56, 19);
            this.btnupdate.TabIndex = 42;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(638, 74);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 19);
            this.btnadd.TabIndex = 43;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(863, 436);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(56, 19);
            this.btnsearch.TabIndex = 39;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(662, 437);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(181, 20);
            this.textBox7.TabIndex = 38;
            this.textBox7.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 283);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(274, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(423, 440);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(56, 19);
            this.btnclose.TabIndex = 36;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(362, 440);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 35;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbname
            // 
            this.cbname.DataSource = this.personsBindingSource1;
            this.cbname.DisplayMember = "name";
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(432, 58);
            this.cbname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(92, 21);
            this.cbname.TabIndex = 79;
            this.cbname.ValueMember = "name";
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            // 
            // txtadmin_id
            // 
            this.txtadmin_id.Location = new System.Drawing.Point(836, 305);
            this.txtadmin_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadmin_id.Name = "txtadmin_id";
            this.txtadmin_id.Size = new System.Drawing.Size(76, 20);
            this.txtadmin_id.TabIndex = 78;
            this.txtadmin_id.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "admin id";
            this.label3.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(432, 113);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(76, 20);
            this.txtpassword.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(432, 90);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(76, 20);
            this.txtusername.TabIndex = 76;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(350, 94);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 73;
            this.username.Text = "username";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(349, 63);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 74;
            this.name.Text = "name";
            // 
            // store_management_systemDataSet2
            // 
            this.store_management_systemDataSet2.DataSetName = "Store_management_systemDataSet2";
            this.store_management_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource1
            // 
            this.personsBindingSource1.DataMember = "persons";
            this.personsBindingSource1.DataSource = this.store_management_systemDataSet2;
            // 
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // purchasemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 501);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.txtadmin_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "purchasemen";
            this.Text = "purchasemen";
            this.Load += new System.EventHandler(this.purchasemen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.TextBox txtadmin_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label name;
        private Project_StoreManagementDataSet1 project_StoreManagementDataSet1;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private Project_StoreManagementDataSet1TableAdapters.personsTableAdapter personsTableAdapter;
        private Store_management_systemDataSet2 store_management_systemDataSet2;
        private System.Windows.Forms.BindingSource personsBindingSource1;
        private Store_management_systemDataSet2TableAdapters.personsTableAdapter personsTableAdapter1;
    }
}