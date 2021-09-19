namespace Home_Bookkeeping_1
{
    partial class IncomeCardInsert
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cBoxMultiplyIncome = new System.Windows.Forms.CheckBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbMoney = new System.Windows.Forms.ComboBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.cmbSubCategoriya = new System.Windows.Forms.ComboBox();
            this.cmbCategoriya = new System.Windows.Forms.ComboBox();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 55);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Ləğv Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(93, 18);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(143, 31);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Daxil Et";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNote.Location = new System.Drawing.Point(175, 249);
            this.txtNote.MaxLength = 150;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNote.Size = new System.Drawing.Size(256, 76);
            this.txtNote.TabIndex = 40;
            // 
            // cBoxMultiplyIncome
            // 
            this.cBoxMultiplyIncome.AutoSize = true;
            this.cBoxMultiplyIncome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxMultiplyIncome.Location = new System.Drawing.Point(175, 219);
            this.cBoxMultiplyIncome.Name = "cBoxMultiplyIncome";
            this.cBoxMultiplyIncome.Size = new System.Drawing.Size(140, 21);
            this.cBoxMultiplyIncome.TabIndex = 39;
            this.cBoxMultiplyIncome.Text = "Qazanc ilə vurulma";
            this.cBoxMultiplyIncome.UseVisualStyleBackColor = true;
            // 
            // cmbUnits
            // 
            this.cmbUnits.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(301, 188);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(130, 25);
            this.cmbUnits.TabIndex = 38;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.Location = new System.Drawing.Point(175, 188);
            this.txtQuantity.MaxLength = 14;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(114, 25);
            this.txtQuantity.TabIndex = 37;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // cmbMoney
            // 
            this.cmbMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoney.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMoney.FormattingEnabled = true;
            this.cmbMoney.Location = new System.Drawing.Point(301, 151);
            this.cmbMoney.Name = "cmbMoney";
            this.cmbMoney.Size = new System.Drawing.Size(130, 25);
            this.cmbMoney.TabIndex = 35;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSum.Location = new System.Drawing.Point(175, 151);
            this.txtSum.MaxLength = 15;
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(114, 25);
            this.txtSum.TabIndex = 34;
            this.txtSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSum_KeyPress);
            this.txtSum.Leave += new System.EventHandler(this.txtSum_Leave);
            // 
            // cmbSubCategoriya
            // 
            this.cmbSubCategoriya.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSubCategoriya.FormattingEnabled = true;
            this.cmbSubCategoriya.Location = new System.Drawing.Point(175, 114);
            this.cmbSubCategoriya.Name = "cmbSubCategoriya";
            this.cmbSubCategoriya.Size = new System.Drawing.Size(256, 25);
            this.cmbSubCategoriya.TabIndex = 32;
            // 
            // cmbCategoriya
            // 
            this.cmbCategoriya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriya.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategoriya.FormattingEnabled = true;
            this.cmbCategoriya.Location = new System.Drawing.Point(175, 79);
            this.cmbCategoriya.Name = "cmbCategoriya";
            this.cmbCategoriya.Size = new System.Drawing.Size(256, 25);
            this.cmbCategoriya.TabIndex = 31;
            this.cmbCategoriya.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriya_SelectedIndexChanged);
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(175, 44);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(256, 25);
            this.cmbAccountName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(114, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Qeyd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(115, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Miqdar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(114, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Məbləğ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(70, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Alt Kateqoriya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kateqoriya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hesab Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tarix";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(175, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 25);
            this.dtpDate.TabIndex = 21;
            // 
            // IncomeCardInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cBoxMultiplyIncome);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbMoney);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.cmbSubCategoriya);
            this.Controls.Add(this.cmbCategoriya);
            this.Controls.Add(this.cmbAccountName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncomeCardInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qazanc Kartı";
            this.Load += new System.EventHandler(this.IncomeCardInsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.CheckBox cBoxMultiplyIncome;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbMoney;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ComboBox cmbSubCategoriya;
        private System.Windows.Forms.ComboBox cmbCategoriya;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}