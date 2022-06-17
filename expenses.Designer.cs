namespace StoreManagementSystem
{
    partial class expenses
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.txtbillmonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.dtpaydate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.expensestypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.store_management_systemDataSet4 = new StoreManagementSystem.Store_management_systemDataSet4();
            this.expensestypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expenses_typeTableAdapter1 = new StoreManagementSystem.Store_management_systemDataSet4TableAdapters.expenses_typeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.expensestypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensestypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(432, 314);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(56, 19);
            this.btnsearch.TabIndex = 40;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(212, 349);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(56, 19);
            this.btnclose.TabIndex = 37;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(151, 349);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 36;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(432, 267);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(56, 19);
            this.btndisplay.TabIndex = 44;
            this.btndisplay.Text = "display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Visible = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(432, 291);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 43;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(184, 162);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 19);
            this.btnadd.TabIndex = 41;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(133, 40);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 45;
            this.name.Text = "name";
            // 
            // txtbillmonth
            // 
            this.txtbillmonth.Location = new System.Drawing.Point(196, 107);
            this.txtbillmonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbillmonth.Name = "txtbillmonth";
            this.txtbillmonth.Size = new System.Drawing.Size(76, 20);
            this.txtbillmonth.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "billing month";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(196, 63);
            this.txtamount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(76, 20);
            this.txtamount.TabIndex = 50;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(133, 67);
            this.amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(42, 13);
            this.amount.TabIndex = 49;
            this.amount.Text = "amount";
            // 
            // dtpaydate
            // 
            this.dtpaydate.CustomFormat = "yyyy-mm-dd";
            this.dtpaydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpaydate.Location = new System.Drawing.Point(174, 130);
            this.dtpaydate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpaydate.Name = "dtpaydate";
            this.dtpaydate.Size = new System.Drawing.Size(151, 20);
            this.dtpaydate.TabIndex = 52;
            this.dtpaydate.Value = new System.DateTime(2019, 3, 24, 20, 38, 43, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "paying date";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.expensestypeBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.ValueMember = "name";
            // 
            // expensestypeBindingSource
            // 
            this.expensestypeBindingSource.DataMember = "expenses_type";
            // 
            // store_management_systemDataSet4
            // 
            this.store_management_systemDataSet4.DataSetName = "Store_management_systemDataSet4";
            this.store_management_systemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensestypeBindingSource1
            // 
            this.expensestypeBindingSource1.DataMember = "expenses_type";
            this.expensestypeBindingSource1.DataSource = this.store_management_systemDataSet4;
            // 
            // expenses_typeTableAdapter1
            // 
            this.expenses_typeTableAdapter1.ClearBeforeFill = true;
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 395);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpaydate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.txtbillmonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "expenses";
            this.Text = "expenses";
            this.Load += new System.EventHandler(this.expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expensestypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensestypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtbillmonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.DateTimePicker dtpaydate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private Project_StoreManagementDataSet5 project_StoreManagementDataSet5;
        private System.Windows.Forms.BindingSource expensestypeBindingSource;
        private Project_StoreManagementDataSet5TableAdapters.expenses_typeTableAdapter expenses_typeTableAdapter;
        private Store_management_systemDataSet4 store_management_systemDataSet4;
        private System.Windows.Forms.BindingSource expensestypeBindingSource1;
        private Store_management_systemDataSet4TableAdapters.expenses_typeTableAdapter expenses_typeTableAdapter1;
    }
}