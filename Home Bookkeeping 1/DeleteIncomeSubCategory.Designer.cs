namespace Home_Bookkeeping_1
{
    partial class DeleteIncomeSubCategory
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
            this.gBoxIncomeSubCategAddPros = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInformationDelete = new System.Windows.Forms.Label();
            this.gBoxIncomeSubCategAddPros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIncomeSubCategAddPros
            // 
            this.gBoxIncomeSubCategAddPros.Controls.Add(this.btnCancel);
            this.gBoxIncomeSubCategAddPros.Controls.Add(this.btnOK);
            this.gBoxIncomeSubCategAddPros.Location = new System.Drawing.Point(16, 31);
            this.gBoxIncomeSubCategAddPros.Name = "gBoxIncomeSubCategAddPros";
            this.gBoxIncomeSubCategAddPros.Size = new System.Drawing.Size(399, 64);
            this.gBoxIncomeSubCategAddPros.TabIndex = 7;
            this.gBoxIncomeSubCategAddPros.TabStop = false;
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
            this.btnOK.Text = "Bəli";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInformationDelete
            // 
            this.lblInformationDelete.AutoSize = true;
            this.lblInformationDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInformationDelete.Location = new System.Drawing.Point(3, 9);
            this.lblInformationDelete.Name = "lblInformationDelete";
            this.lblInformationDelete.Size = new System.Drawing.Size(243, 15);
            this.lblInformationDelete.TabIndex = 6;
            this.lblInformationDelete.Text = "Bu məlumatı silmək istədiyinizdən əminsiniz?";
            // 
            // DeleteIncomeSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 107);
            this.Controls.Add(this.gBoxIncomeSubCategAddPros);
            this.Controls.Add(this.lblInformationDelete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteIncomeSubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qazanc Alt Kateqoriya Silmə";
            this.Load += new System.EventHandler(this.DeleteIncomeSubCategory_Load);
            this.gBoxIncomeSubCategAddPros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIncomeSubCategAddPros;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInformationDelete;
    }
}