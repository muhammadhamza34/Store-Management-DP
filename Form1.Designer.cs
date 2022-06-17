namespace StoreManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.rbsalesmen = new System.Windows.Forms.RadioButton();
            this.rbpurchasemen = new System.Windows.Forms.RadioButton();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(20, 24);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(46, 16);
            this.username.TabIndex = 0;
            this.username.Text = "name";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(114, 23);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(219, 20);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbadmin.Location = new System.Drawing.Point(18, 114);
            this.rbadmin.Margin = new System.Windows.Forms.Padding(2);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(68, 20);
            this.rbadmin.TabIndex = 3;
            this.rbadmin.TabStop = true;
            this.rbadmin.Text = "admin";
            this.rbadmin.UseVisualStyleBackColor = true;
            this.rbadmin.CheckedChanged += new System.EventHandler(this.rbadmin_CheckedChanged);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(92, 195);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(82, 35);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(114, 46);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(219, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(20, 47);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 16);
            this.password.TabIndex = 4;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // rbsalesmen
            // 
            this.rbsalesmen.AutoSize = true;
            this.rbsalesmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsalesmen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbsalesmen.Location = new System.Drawing.Point(99, 114);
            this.rbsalesmen.Margin = new System.Windows.Forms.Padding(2);
            this.rbsalesmen.Name = "rbsalesmen";
            this.rbsalesmen.Size = new System.Drawing.Size(93, 20);
            this.rbsalesmen.TabIndex = 4;
            this.rbsalesmen.TabStop = true;
            this.rbsalesmen.Text = "salesmen";
            this.rbsalesmen.UseVisualStyleBackColor = true;
            this.rbsalesmen.CheckedChanged += new System.EventHandler(this.rbsalesmen_CheckedChanged);
            // 
            // rbpurchasemen
            // 
            this.rbpurchasemen.AutoSize = true;
            this.rbpurchasemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpurchasemen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbpurchasemen.Location = new System.Drawing.Point(201, 114);
            this.rbpurchasemen.Margin = new System.Windows.Forms.Padding(2);
            this.rbpurchasemen.Name = "rbpurchasemen";
            this.rbpurchasemen.Size = new System.Drawing.Size(119, 20);
            this.rbpurchasemen.TabIndex = 5;
            this.rbpurchasemen.TabStop = true;
            this.rbpurchasemen.Text = "purchasemen";
            this.rbpurchasemen.UseVisualStyleBackColor = true;
            this.rbpurchasemen.CheckedChanged += new System.EventHandler(this.rbpurchasemen_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(188, 195);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(82, 35);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.rbadmin);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.rbpurchasemen);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.rbsalesmen);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Location = new System.Drawing.Point(315, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 265);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(230, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Store Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.RadioButton rbadmin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.RadioButton rbsalesmen;
        private System.Windows.Forms.RadioButton rbpurchasemen;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

