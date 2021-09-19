namespace Home_Bookkeeping_1
{
    partial class ExpensesCardDelete
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
            this.lblMessageDeleteConfirmation = new System.Windows.Forms.Label();
            this.gBoxExpenseCardDeleteOKCAN = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gBoxExpenseCardDeleteOKCAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessageDeleteConfirmation
            // 
            this.lblMessageDeleteConfirmation.AutoSize = true;
            this.lblMessageDeleteConfirmation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessageDeleteConfirmation.Location = new System.Drawing.Point(4, 9);
            this.lblMessageDeleteConfirmation.Name = "lblMessageDeleteConfirmation";
            this.lblMessageDeleteConfirmation.Size = new System.Drawing.Size(35, 15);
            this.lblMessageDeleteConfirmation.TabIndex = 0;
            this.lblMessageDeleteConfirmation.Text = "label1";
            // 
            // gBoxExpenseCardDeleteOKCAN
            // 
            this.gBoxExpenseCardDeleteOKCAN.BackColor = System.Drawing.SystemColors.Control;
            this.gBoxExpenseCardDeleteOKCAN.Controls.Add(this.button2);
            this.gBoxExpenseCardDeleteOKCAN.Controls.Add(this.button1);
            this.gBoxExpenseCardDeleteOKCAN.Location = new System.Drawing.Point(0, 45);
            this.gBoxExpenseCardDeleteOKCAN.Name = "gBoxExpenseCardDeleteOKCAN";
            this.gBoxExpenseCardDeleteOKCAN.Size = new System.Drawing.Size(433, 46);
            this.gBoxExpenseCardDeleteOKCAN.TabIndex = 1;
            this.gBoxExpenseCardDeleteOKCAN.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(341, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ləğv Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(260, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bəli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpensesCardDelete
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
            this.Name = "ExpensesCardDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xərc Kartı";
            this.Load += new System.EventHandler(this.ExpensesCardDelete_Load);
            this.gBoxExpenseCardDeleteOKCAN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageDeleteConfirmation;
        private System.Windows.Forms.GroupBox gBoxExpenseCardDeleteOKCAN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}