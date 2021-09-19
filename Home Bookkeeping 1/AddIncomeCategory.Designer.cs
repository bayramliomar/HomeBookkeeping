namespace Home_Bookkeeping_1
{
    partial class AddIncomeCategory
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
            this.gBoxIncomeCategAddPros = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtIncomeCategName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxIncomeCategAddPros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxIncomeCategAddPros
            // 
            this.gBoxIncomeCategAddPros.Controls.Add(this.btnCancel);
            this.gBoxIncomeCategAddPros.Controls.Add(this.btnOK);
            this.gBoxIncomeCategAddPros.Location = new System.Drawing.Point(7, 67);
            this.gBoxIncomeCategAddPros.Name = "gBoxIncomeCategAddPros";
            this.gBoxIncomeCategAddPros.Size = new System.Drawing.Size(332, 62);
            this.gBoxIncomeCategAddPros.TabIndex = 5;
            this.gBoxIncomeCategAddPros.TabStop = false;
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
            // txtIncomeCategName
            // 
            this.txtIncomeCategName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIncomeCategName.Location = new System.Drawing.Point(7, 33);
            this.txtIncomeCategName.MaxLength = 30;
            this.txtIncomeCategName.Name = "txtIncomeCategName";
            this.txtIncomeCategName.Size = new System.Drawing.Size(332, 25);
            this.txtIncomeCategName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bir Qazanc Kateqoriya Adı Daxil Edin";
            // 
            // AddIncomeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 139);
            this.Controls.Add(this.gBoxIncomeCategAddPros);
            this.Controls.Add(this.txtIncomeCategName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncomeCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qazanc Kateqoriya Əlavə Etmə";
            this.gBoxIncomeCategAddPros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxIncomeCategAddPros;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtIncomeCategName;
        private System.Windows.Forms.Label label1;
    }
}