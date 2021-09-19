namespace Home_Bookkeeping_1
{
    partial class IncomeCardDelete
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
            this.gBoxExpenseCardDeleteOKCAN = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMessageDeleteConfirmation = new System.Windows.Forms.Label();
            this.gBoxExpenseCardDeleteOKCAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxExpenseCardDeleteOKCAN
            // 
            this.gBoxExpenseCardDeleteOKCAN.BackColor = System.Drawing.SystemColors.Control;
            this.gBoxExpenseCardDeleteOKCAN.Controls.Add(this.btnCancel);
            this.gBoxExpenseCardDeleteOKCAN.Controls.Add(this.btnOk);
            this.gBoxExpenseCardDeleteOKCAN.Location = new System.Drawing.Point(0, 45);
            this.gBoxExpenseCardDeleteOKCAN.Name = "gBoxExpenseCardDeleteOKCAN";
            this.gBoxExpenseCardDeleteOKCAN.Size = new System.Drawing.Size(431, 46);
            this.gBoxExpenseCardDeleteOKCAN.TabIndex = 3;
            this.gBoxExpenseCardDeleteOKCAN.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(340, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Ləğv Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(259, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Bəli";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMessageDeleteConfirmation
            // 
            this.lblMessageDeleteConfirmation.AutoSize = true;
            this.lblMessageDeleteConfirmation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessageDeleteConfirmation.Location = new System.Drawing.Point(4, 9);
            this.lblMessageDeleteConfirmation.Name = "lblMessageDeleteConfirmation";
            this.lblMessageDeleteConfirmation.Size = new System.Drawing.Size(35, 15);
            this.lblMessageDeleteConfirmation.TabIndex = 2;
            this.lblMessageDeleteConfirmation.Text = "label1";
            // 
            // IncomeCardDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 92);
            this.Controls.Add(this.gBoxExpenseCardDeleteOKCAN);
            this.Controls.Add(this.lblMessageDeleteConfirmation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncomeCardDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qazanc Kartı";
            this.Load += new System.EventHandler(this.IncomeCardDelete_Load);
            this.gBoxExpenseCardDeleteOKCAN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxExpenseCardDeleteOKCAN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMessageDeleteConfirmation;
    }
}