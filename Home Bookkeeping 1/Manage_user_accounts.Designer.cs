namespace Home_Bookkeeping_1
{
    partial class Manage_user_accounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbox5manageusers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.gbox5manageusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox5manageusers
            // 
            this.gbox5manageusers.Controls.Add(this.btnExit);
            this.gbox5manageusers.Controls.Add(this.btnDelete);
            this.gbox5manageusers.Controls.Add(this.btnUpdate);
            this.gbox5manageusers.Controls.Add(this.btnInsert);
            this.gbox5manageusers.Location = new System.Drawing.Point(12, 322);
            this.gbox5manageusers.Name = "gbox5manageusers";
            this.gbox5manageusers.Size = new System.Drawing.Size(622, 54);
            this.gbox5manageusers.TabIndex = 0;
            this.gbox5manageusers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(470, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Bağla";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(316, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Düzəliş Et";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(8, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 29);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Əlavə Et";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AllowUserToDeleteRows = false;
            this.dtgUsers.AllowUserToResizeRows = false;
            this.dtgUsers.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgUsers.ColumnHeadersVisible = false;
            this.dtgUsers.Location = new System.Drawing.Point(12, 37);
            this.dtgUsers.MultiSelect = false;
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsers.Size = new System.Drawing.Size(622, 260);
            this.dtgUsers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "İstifadəçi Sayı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(12, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(622, 29);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "İstifadəçi Adları";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.BackColor = System.Drawing.Color.Linen;
            this.lblUsersCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsersCount.Location = new System.Drawing.Point(109, 295);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(0, 19);
            this.lblUsersCount.TabIndex = 4;
            // 
            // Manage_user_accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 383);
            this.Controls.Add(this.lblUsersCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.gbox5manageusers);
            this.Controls.Add(this.dtgUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manage_user_accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstifadəçi Hesablarını İdarə Etmə";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_user_accounts_FormClosing);
            this.Load += new System.EventHandler(this.Manage_user_accounts_Load);
            this.gbox5manageusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox5manageusers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsersCount;
        public System.Windows.Forms.DataGridView dtgUsers;
    }
}