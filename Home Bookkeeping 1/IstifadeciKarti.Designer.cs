namespace Home_Bookkeeping_1
{
    partial class IstifadeciKarti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.gBoxPWProt = new System.Windows.Forms.GroupBox();
            this.txtPassRept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxYEsNo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxInsertStandartCateg = new System.Windows.Forms.CheckBox();
            this.cmbMoney = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gBoxPWProt.SuspendLayout();
            this.gBoxYEsNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bir istifadeçi adı daxil edin";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(40, 29);
            this.txtUserName.MaxLength = 25;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(347, 25);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // gBoxPWProt
            // 
            this.gBoxPWProt.Controls.Add(this.txtPassRept);
            this.gBoxPWProt.Controls.Add(this.label3);
            this.gBoxPWProt.Controls.Add(this.txtPassword);
            this.gBoxPWProt.Controls.Add(this.label2);
            this.gBoxPWProt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBoxPWProt.Location = new System.Drawing.Point(40, 71);
            this.gBoxPWProt.Name = "gBoxPWProt";
            this.gBoxPWProt.Size = new System.Drawing.Size(347, 128);
            this.gBoxPWProt.TabIndex = 2;
            this.gBoxPWProt.TabStop = false;
            this.gBoxPWProt.Text = "Şifrə Təhlükəsizliyi";
            // 
            // txtPassRept
            // 
            this.txtPassRept.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassRept.ForeColor = System.Drawing.Color.Black;
            this.txtPassRept.Location = new System.Drawing.Point(11, 93);
            this.txtPassRept.MaxLength = 50;
            this.txtPassRept.Name = "txtPassRept";
            this.txtPassRept.Size = new System.Drawing.Size(317, 25);
            this.txtPassRept.TabIndex = 5;
            this.txtPassRept.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Təkrar şifrə";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(11, 44);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bir şifrə daxil edin";
            // 
            // gBoxYEsNo
            // 
            this.gBoxYEsNo.Controls.Add(this.button2);
            this.gBoxYEsNo.Controls.Add(this.button1);
            this.gBoxYEsNo.Location = new System.Drawing.Point(40, 279);
            this.gBoxYEsNo.Name = "gBoxYEsNo";
            this.gBoxYEsNo.Size = new System.Drawing.Size(347, 54);
            this.gBoxYEsNo.TabIndex = 3;
            this.gBoxYEsNo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(206, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ləğv Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Daxil Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxInsertStandartCateg
            // 
            this.cBoxInsertStandartCateg.AutoSize = true;
            this.cBoxInsertStandartCateg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxInsertStandartCateg.Location = new System.Drawing.Point(40, 249);
            this.cBoxInsertStandartCateg.Name = "cBoxInsertStandartCateg";
            this.cBoxInsertStandartCateg.Size = new System.Drawing.Size(373, 21);
            this.cBoxInsertStandartCateg.TabIndex = 4;
            this.cBoxInsertStandartCateg.Text = "Standart Kateqoriyaları (Alt Kateqoriyalar , Ölçü Vahidləri)";
            this.cBoxInsertStandartCateg.UseVisualStyleBackColor = true;
            // 
            // cmbMoney
            // 
            this.cmbMoney.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMoney.FormattingEnabled = true;
            this.cmbMoney.Location = new System.Drawing.Point(164, 212);
            this.cmbMoney.Name = "cmbMoney";
            this.cmbMoney.Size = new System.Drawing.Size(204, 25);
            this.cmbMoney.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pul Vahidinizi seçin";
            // 
            // IstifadeciKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMoney);
            this.Controls.Add(this.cBoxInsertStandartCateg);
            this.Controls.Add(this.gBoxYEsNo);
            this.Controls.Add(this.gBoxPWProt);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IstifadeciKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istifadeci Karti";
            this.Load += new System.EventHandler(this.IstifadeciKarti_Load);
            this.gBoxPWProt.ResumeLayout(false);
            this.gBoxPWProt.PerformLayout();
            this.gBoxYEsNo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxPWProt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxYEsNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassRept;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cBoxInsertStandartCateg;
        private System.Windows.Forms.ComboBox cmbMoney;
        private System.Windows.Forms.Label label4;
    }
}