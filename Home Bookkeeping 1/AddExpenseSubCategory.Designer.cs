namespace Home_Bookkeeping_1
{
    partial class AddExpenseSubCategory
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
            this.gBoxExpenseSubCategAddPros = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtExpenseSubCategName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpenseCategNameinSub = new System.Windows.Forms.Label();
            this.gBoxExpenseSubCategAddPros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxExpenseSubCategAddPros
            // 
            this.gBoxExpenseSubCategAddPros.Controls.Add(this.btnCancel);
            this.gBoxExpenseSubCategAddPros.Controls.Add(this.btnOK);
            this.gBoxExpenseSubCategAddPros.Location = new System.Drawing.Point(7, 98);
            this.gBoxExpenseSubCategAddPros.Name = "gBoxExpenseSubCategAddPros";
            this.gBoxExpenseSubCategAddPros.Size = new System.Drawing.Size(332, 62);
            this.gBoxExpenseSubCategAddPros.TabIndex = 5;
            this.gBoxExpenseSubCategAddPros.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(194, 19);
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
            // txtExpenseSubCategName
            // 
            this.txtExpenseSubCategName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpenseSubCategName.Location = new System.Drawing.Point(7, 64);
            this.txtExpenseSubCategName.MaxLength = 30;
            this.txtExpenseSubCategName.Name = "txtExpenseSubCategName";
            this.txtExpenseSubCategName.Size = new System.Drawing.Size(332, 25);
            this.txtExpenseSubCategName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bir Xərc Alt Kateqoriya Adı Daxil Edin";
            // 
            // lblExpenseCategNameinSub
            // 
            this.lblExpenseCategNameinSub.AutoSize = true;
            this.lblExpenseCategNameinSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpenseCategNameinSub.Location = new System.Drawing.Point(3, 9);
            this.lblExpenseCategNameinSub.Name = "lblExpenseCategNameinSub";
            this.lblExpenseCategNameinSub.Size = new System.Drawing.Size(114, 19);
            this.lblExpenseCategNameinSub.TabIndex = 6;
            this.lblExpenseCategNameinSub.Text = "Xərc Kateqoriya:";
            // 
            // AddExpenseSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 164);
            this.Controls.Add(this.lblExpenseCategNameinSub);
            this.Controls.Add(this.gBoxExpenseSubCategAddPros);
            this.Controls.Add(this.txtExpenseSubCategName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExpenseSubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xərc Alt Kateqoriya Əlavə Etmə";
            this.Load += new System.EventHandler(this.AddExpenseSubCategory_Load);
            this.gBoxExpenseSubCategAddPros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxExpenseSubCategAddPros;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtExpenseSubCategName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpenseCategNameinSub;
    }
}