namespace StoreManagementSystem
{
    partial class purchases
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.additem = new System.Windows.Forms.Button();
            this.deleteitem = new System.Windows.Forms.Button();
            this.updateitem = new System.Windows.Forms.Button();
            this.displayitem = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.project_StoreManagementDataSet3 = new StoreManagementSystem.Project_StoreManagementDataSet3();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new StoreManagementSystem.Project_StoreManagementDataSet3TableAdapters.itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.project_StoreManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(135, 444);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(216, 444);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(106, 116);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 17);
            this.name.TabIndex = 3;
            this.name.Text = "item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = " date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(191, 138);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 22);
            this.txtquantity.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, -318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(499, -241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(641, -641);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dtdate
            // 
            this.dtdate.CustomFormat = "yyyy-mm-dd";
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdate.Location = new System.Drawing.Point(151, 164);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(200, 22);
            this.dtdate.TabIndex = 10;
            this.dtdate.Value = new System.DateTime(2019, 3, 24, 20, 38, 43, 0);
            this.dtdate.ValueChanged += new System.EventHandler(this.dtexpirydate_ValueChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(191, 201);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(758, 138);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 25);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(758, 109);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 25);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(758, 160);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 25);
            this.btndisplay.TabIndex = 11;
            this.btndisplay.Text = "display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Visible = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(758, 367);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(737, 192);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(142, 23);
            this.additem.TabIndex = 12;
            this.additem.Text = "add items";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Visible = false;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.Location = new System.Drawing.Point(737, 238);
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(146, 23);
            this.deleteitem.TabIndex = 12;
            this.deleteitem.Text = "delete item";
            this.deleteitem.UseVisualStyleBackColor = true;
            this.deleteitem.Visible = false;
            this.deleteitem.Click += new System.EventHandler(this.deleteitem_Click);
            // 
            // updateitem
            // 
            this.updateitem.Location = new System.Drawing.Point(737, 284);
            this.updateitem.Name = "updateitem";
            this.updateitem.Size = new System.Drawing.Size(142, 23);
            this.updateitem.TabIndex = 12;
            this.updateitem.Text = "update item";
            this.updateitem.UseVisualStyleBackColor = true;
            this.updateitem.Visible = false;
            this.updateitem.Click += new System.EventHandler(this.updateitem_Click);
            // 
            // displayitem
            // 
            this.displayitem.Location = new System.Drawing.Point(737, 322);
            this.displayitem.Name = "displayitem";
            this.displayitem.Size = new System.Drawing.Size(118, 23);
            this.displayitem.TabIndex = 12;
            this.displayitem.Text = "display items";
            this.displayitem.UseVisualStyleBackColor = true;
            this.displayitem.Visible = false;
            this.displayitem.Click += new System.EventHandler(this.displayitem_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(758, 396);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "search items";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.itemsBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "name";
            // 
            // project_StoreManagementDataSet3
            // 
            this.project_StoreManagementDataSet3.DataSetName = "Project_StoreManagementDataSet3";
            this.project_StoreManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
//            this.itemsBindingSource.DataSource = this.project_StoreManagementDataSet3;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.displayitem);
            this.Controls.Add(this.updateitem);
            this.Controls.Add(this.deleteitem);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Name = "purchases";
            this.Text = "purchases";
            this.Load += new System.EventHandler(this.purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_StoreManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.Button deleteitem;
        private System.Windows.Forms.Button updateitem;
        private System.Windows.Forms.Button displayitem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private Project_StoreManagementDataSet3 project_StoreManagementDataSet3;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private Project_StoreManagementDataSet3TableAdapters.itemsTableAdapter itemsTableAdapter;
    }
}