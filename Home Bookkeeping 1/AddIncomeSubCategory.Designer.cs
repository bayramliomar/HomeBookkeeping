namespace Home_Bookkeeping_1
{
    partial class AddIncomeSubCategory
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
            this.lblIncomeCategNameinSub = new System.Windows.Forms.Label();
            this.gBoxIncomeSubCategAddPros = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtIncomeSubCategName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxIncomeSubCategAddPros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncomeCategNameinSub
            // 
            this.lblIncomeCategNameinSub.AutoSize = true;
            this.lblIncomeCategNameinSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIncomeCategNameinSub.Location = new System.Drawing.Point(3, 9);
            this.lblIncomeCategNameinSub.Name = "lblIncomeCategNameinSub";
            this.lblIncomeCategNameinSub.Size = new System.Drawing.Size(130, 19);
            this.lblIncomeCategNameinSub.TabIndex = 10;
            this.lblIncomeCategNameinSub.Text = "Qazanc Kateqoriya:";
            // 
            // gBoxIncomeSubCategAddPros
            // 
            this.gBoxIncomeSubCategAddPros.Controls.Add(this.btnCancel);
            this.gBoxIncomeSubCategAddPros.Controls.Add(this.btnOK);
            this.gBoxIncomeSubCategAddPros.Location = new System.Drawing.Point(7, 98);
            this.gBoxIncomeSubCategAddPros.Name = "gBoxIncomeSubCategAddPros";
            this.gBoxIncomeSubCategAddPros.Size = new System.Drawing.Size(359, 62);
            this.gBoxIncomeSubCategAddPros.TabIndex = 9;
            this.gBoxIncomeSubCategAddPros.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(219, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Ləğv Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(17, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Daxil Et";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtIncomeSubCategName
            // 
            this.txtIncomeSubCategName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIncomeSubCategName.Location = new System.Drawing.Point(7, 64);
            this.txtIncomeSubCategName.MaxLength = 30;
            this.txtIncomeSubCategName.Name = "txtIncomeSubCategName";
            this.txtIncomeSubCategName.Size = new System.Drawing.Size(359, 25);
            this.txtIncomeSubCategName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bir Qazanc Alt Kateqoriya Adı Daxil Edin";
            // 
            // AddIncomeSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 164);
            this.Controls.Add(this.lblIncomeCategNameinSub);
            this.Controls.Add(this.gBoxIncomeSubCategAddPros);
            this.Controls.Add(this.txtIncomeSubCategName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncomeSubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qazanc Alt Kateqoriya Əlavə Etmə";
            this.Load += new System.EventHandler(this.AddIncomeSubCategory_Load);
            this.gBoxIncomeSubCategAddPros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomeCategNameinSub;
        private System.Windows.Forms.GroupBox gBoxIncomeSubCategAddPros;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtIncomeSubCategName;
        private System.Windows.Forms.Label label1;
    }
}