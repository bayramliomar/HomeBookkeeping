namespace Home_Bookkeeping_1
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.gbox4userok = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbox3users = new System.Windows.Forms.GroupBox();
            this.btnmanageuser = new System.Windows.Forms.Button();
            this.cmbusers = new System.Windows.Forms.ComboBox();
            this.lblselectusers = new System.Windows.Forms.Label();
            this.gbox4userok.SuspendLayout();
            this.gbox3users.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox4userok
            // 
            this.gbox4userok.Controls.Add(this.btnExit);
            this.gbox4userok.Controls.Add(this.btnOk);
            this.gbox4userok.Location = new System.Drawing.Point(12, 128);
            this.gbox4userok.Name = "gbox4userok";
            this.gbox4userok.Size = new System.Drawing.Size(457, 69);
            this.gbox4userok.TabIndex = 4;
            this.gbox4userok.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(258, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(74, 23);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Daxil ol";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbox3users
            // 
            this.gbox3users.Controls.Add(this.btnmanageuser);
            this.gbox3users.Controls.Add(this.cmbusers);
            this.gbox3users.Controls.Add(this.lblselectusers);
            this.gbox3users.Location = new System.Drawing.Point(12, 12);
            this.gbox3users.Name = "gbox3users";
            this.gbox3users.Size = new System.Drawing.Size(457, 110);
            this.gbox3users.TabIndex = 3;
            this.gbox3users.TabStop = false;
            // 
            // btnmanageuser
            // 
            this.btnmanageuser.Image = ((System.Drawing.Image)(resources.GetObject("btnmanageuser.Image")));
            this.btnmanageuser.Location = new System.Drawing.Point(395, 49);
            this.btnmanageuser.Name = "btnmanageuser";
            this.btnmanageuser.Size = new System.Drawing.Size(53, 30);
            this.btnmanageuser.TabIndex = 3;
            this.btnmanageuser.UseVisualStyleBackColor = true;
            this.btnmanageuser.Click += new System.EventHandler(this.btnmanageuser_Click);
            // 
            // cmbusers
            // 
            this.cmbusers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbusers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbusers.FormattingEnabled = true;
            this.cmbusers.Location = new System.Drawing.Point(74, 52);
            this.cmbusers.Name = "cmbusers";
            this.cmbusers.Size = new System.Drawing.Size(308, 25);
            this.cmbusers.TabIndex = 2;
            // 
            // lblselectusers
            // 
            this.lblselectusers.AutoSize = true;
            this.lblselectusers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblselectusers.Location = new System.Drawing.Point(70, 30);
            this.lblselectusers.Name = "lblselectusers";
            this.lblselectusers.Size = new System.Drawing.Size(139, 19);
            this.lblselectusers.TabIndex = 1;
            this.lblselectusers.Text = "Bir istifadəçi adı seçin";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 202);
            this.Controls.Add(this.gbox4userok);
            this.Controls.Add(this.gbox3users);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstifadəçilər";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.gbox4userok.ResumeLayout(false);
            this.gbox3users.ResumeLayout(false);
            this.gbox3users.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox4userok;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbox3users;
        private System.Windows.Forms.Button btnmanageuser;
        private System.Windows.Forms.Label lblselectusers;
        public System.Windows.Forms.ComboBox cmbusers;
    }
}