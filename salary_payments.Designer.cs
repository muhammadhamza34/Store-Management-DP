namespace StoreManagementSystem
{
    partial class salary_payments
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.store_management_systemDataSet1 = new StoreManagementSystem.Store_management_systemDataSet1();
            this.personsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter1 = new StoreManagementSystem.Store_management_systemDataSet1TableAdapters.personsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(284, 428);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(56, 19);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(224, 428);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 19);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbid
            // 
            this.cbid.DataSource = this.personsBindingSource1;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(250, 101);
            this.cbid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(92, 21);
            this.cbid.TabIndex = 82;
            this.cbid.ValueMember = "person_id";
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(166, 106);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 13);
            this.name.TabIndex = 81;
            this.name.Text = "person id";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(249, 216);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 19);
            this.btnadd.TabIndex = 80;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(249, 128);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(76, 20);
            this.txtsalary.TabIndex = 84;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(185, 132);
            this.amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(34, 13);
            this.amount.TabIndex = 83;
            this.amount.Text = "salary";
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "yyyy-mm-dd";
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(230, 172);
            this.dtdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(151, 20);
            this.dtdate.TabIndex = 86;
            this.dtdate.Value = new System.DateTime(2019, 3, 24, 20, 38, 43, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "date";
            // 
            // store_management_systemDataSet1
            // 
            this.store_management_systemDataSet1.DataSetName = "Store_management_systemDataSet1";
            this.store_management_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource1
            // 
            this.personsBindingSource1.DataMember = "persons";
            this.personsBindingSource1.DataSource = this.store_management_systemDataSet1;
            // 
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // salary_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 468);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "salary_payments";
            this.Text = "salary_payments";
            this.Load += new System.EventHandler(this.salary_payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_management_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label label4;
        private Project_StoreManagementDataSet6 project_StoreManagementDataSet6;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private Project_StoreManagementDataSet6TableAdapters.personsTableAdapter personsTableAdapter;
        private Store_management_systemDataSet1 store_management_systemDataSet1;
        private System.Windows.Forms.BindingSource personsBindingSource1;
        private Store_management_systemDataSet1TableAdapters.personsTableAdapter personsTableAdapter1;
    }
}