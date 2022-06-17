namespace StoreManagementSystem
{
    partial class persons
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(286, 515);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(205, 515);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(370, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 54;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(261, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 17);
            this.name.TabIndex = 53;
            this.name.Text = "name";
            // 
            // dtdob
            // 
            this.dtdob.Location = new System.Drawing.Point(315, 122);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(200, 22);
            this.dtdob.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "date of birth";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(379, 152);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(100, 22);
            this.txtdesignation.TabIndex = 61;
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Location = new System.Drawing.Point(270, 157);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(81, 17);
            this.designation.TabIndex = 60;
            this.designation.Text = "designation";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(379, 211);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 64;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(270, 216);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 63;
            this.email.Text = "email";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(379, 183);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "phone";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(343, 271);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 67;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 577);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.dtdob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnback);
            this.Name = "persons";
            this.Text = "persons";
            this.Load += new System.EventHandler(this.persons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
    }
}