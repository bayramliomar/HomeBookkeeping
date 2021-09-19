using HomeBookkeeping.ORM.Entity;
using HomeBookkeeping.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Bookkeeping_1
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public AddAccount(Form1 frm_aa)
        {
            InitializeComponent();
            frm1 = frm_aa;
        }
        int sira = 0;
        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool sum = false;
            int count = 0;
            for (int i = 0; i < (sender as TextBox).Text.Length; i++)
            {
                if (sum == true)
                {
                    count++;
                }
                if ((sender as TextBox).Text.Substring(i, 1) == ".")
                {
                    sum = true;
                    sira = (sender as TextBox).Text.IndexOf('.');
                }
            }
            if (sum == false || count < 2 || (sender as TextBox).SelectionStart <= sira)
            {
                if (sum = true && (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 && (sender as TextBox).SelectionStart > sira)
                {
                    count++;
                }
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && (sender as TextBox).SelectionStart < (sender as TextBox).Text.Length - 2)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((int)e.KeyChar != 127 && (int)e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSum_Leave(object sender, EventArgs e)
        {
            if (txtSum.Text != "" && txtSum.Text != ".")
            {
                txtSum.Text = string.Format("{0:F2}", (Convert.ToDouble(txtSum.Text))).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        HesablarORM hORM = new HesablarORM();
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value <= DateTime.Now && (txtSum.Text != "" && txtSum.Text != ".")
                && txtAccountName.Text != "")
            {
                Hesablar h = new Hesablar();
                h.hesabAdi = txtAccountName.Text;
                h.hesabMebleg = Convert.ToDecimal(txtSum.Text);
                h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
                h.hesabTarix = dtpDate.Value;
                h.qeyd = txtNote.Text;
                bool result = hORM.Insert(h);
                if (result)
                {
                    MessageBox.Show("Məlumatlar əlavə edildi");
                  //  frm1.dtgExpensesRefresh();
                    frm1.dtgAccountRefresh();
                    frm1.AccountSearch();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Məlumat əlavə edilərkən səhv açkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            else if (txtAccountName.Text == "")
            {
                MessageBox.Show("Hesab adını daxil edin");
                return;
            }
            else if (dtpDate.Value > DateTime.Now)
            {
                MessageBox.Show("Bu günün tarixindən böyük tarix girilə bilməz");
                return;
            }
            else if (txtSum.Text == ""|| txtSum.Text == ".")
            {
                MessageBox.Show("Məbləği daxil edin");
                return;
            }
            else
            {
                MessageBox.Show("Məlumatların daxil edilməsində səhv aşkarlandı.Məlumatlarınızın düzgünlüyünə riayət edin");
                return;
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            txtSum.Text = "0";
            txtSum.Text = string.Format("{0:F2}", (Convert.ToDouble(txtSum.Text))).ToString();
        }
    }
}
