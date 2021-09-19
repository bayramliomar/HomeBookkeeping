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
    public partial class IncomeCardUpdate : Form
    {
        public IncomeCardUpdate()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public IncomeCardUpdate(Form1 frm_icu)
        {
            InitializeComponent();
            frm1 = frm_icu;
        }
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        IstifadeciPulVahidiORM ipvORM = new IstifadeciPulVahidiORM();
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        HesablarORM hORM = new HesablarORM();
        QazanclarORM qORM = new QazanclarORM();
        private void IncomeCardUpdate_Load(object sender, EventArgs e)
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbCategoriya.DataSource = iqkORM.Select(iqk);
            cmbCategoriya.DisplayMember = "Qazanc Kateqoriyaları";
            cmbCategoriya.ValueMember = "ID";
            cmbCategoriya.Text = frm1.dtgIncome.CurrentRow.Cells["Kateqoriya Adı"].Value.ToString();
            IstifadeciPulVahidi ipv = new IstifadeciPulVahidi();
            ipv.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbMoney.DataSource = ipvORM.Select(ipv);
            cmbMoney.DisplayMember = "Pul Vahidi";
            cmbMoney.ValueMember = "ID";
            cmbMoney.Text = frm1.dtgIncome.CurrentRow.Cells["Pul Vahidi"].Value.ToString();
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbAccountName.DataSource = hORM.Select(h, "prc_HesablarCombobox_Select");
            cmbAccountName.DisplayMember = "Hesab Adı";
            cmbAccountName.ValueMember = "ID";
            cmbAccountName.Text = frm1.dtgIncome.CurrentRow.Cells["Hesab"].Value.ToString();
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbUnits.DataSource = iovORM.Select(iov);
            cmbUnits.DisplayMember = "Ölçü Vahidi";
            cmbUnits.ValueMember = "ID";
            dtpDate.Value = Convert.ToDateTime(frm1.dtgIncome.CurrentRow.Cells["Tarix"].Value.ToString());
            cmbUnits.Text = frm1.dtgIncome.CurrentRow.Cells["Ölçü Vahidi"].Value.ToString();
            txtSum.Text = frm1.dtgIncome.CurrentRow.Cells["Məbləğ"].Value.ToString();
            txtQuantity.Text = frm1.dtgIncome.CurrentRow.Cells["Miqdar"].Value.ToString();
            txtNote.Text = frm1.dtgIncome.CurrentRow.Cells["Qeyd"].Value.ToString();
            txtSum.Text = string.Format("{0:F2}", (Convert.ToDouble(txtSum.Text))).ToString();
            txtQuantity.Text = string.Format("{0:F3}", (Convert.ToDouble(txtQuantity.Text))).ToString();


        }

        private void cmbCategoriya_SelectedIndexChanged(object sender, EventArgs e)
        {
            QazancAltKateqoriya qak = new QazancAltKateqoriya();
            cmbCategoriya.ValueMember = "ID";
            IstifadeciQazancAltKateqoriya iqak = new IstifadeciQazancAltKateqoriya();
            iqak.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            qak.qazancKateqoriyaid = (int)cmbCategoriya.SelectedValue;
            cmbSubCategoriya.DataSource = iqakORM.Select(iqak, qak);
            cmbSubCategoriya.DisplayMember = "Qazanc Alt Kateqoriyaları";
            cmbSubCategoriya.ValueMember = "ID";
            cmbSubCategoriya.Text = frm1.dtgIncome.CurrentRow.Cells["Alt Kateqoriya Adı"].Value.ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value <= DateTime.Now && (txtSum.Text != "0.00" && txtSum.Text != "" && txtSum.Text != ".") && (txtQuantity.Text != "0.000" && txtQuantity.Text != "" && txtQuantity.Text != ".")
                && cmbAccountName.Text != "" && cmbCategoriya.Text != "")
            {
                Qazanclar q = new Qazanclar();
                q.ID = (int)frm1.dtgIncome.CurrentRow.Cells["ID"].Value;
                q.qazancTarix = dtpDate.Value;
                q.hesabid = Convert.ToInt32(cmbAccountName.SelectedValue);
                q.kateqoriyaid = Convert.ToInt32(cmbCategoriya.SelectedValue);
                q.altKateqoriyaid = Convert.ToInt32(cmbSubCategoriya.SelectedValue);
                if (q.altKateqoriyaid == 0)
                {
                    q.altKateqoriyaid = null;
                }
                if (cBoxMultiplyIncome.Checked)
                {
                    q.qazancMebleg = Convert.ToDecimal((Convert.ToDouble(txtSum.Text)) * Convert.ToDouble(txtQuantity.Text));
                }
                else
                {
                    q.qazancMebleg = Convert.ToDecimal(Convert.ToDouble(txtSum.Text));
                }
                q.pulVahidiid = Convert.ToInt32(cmbMoney.SelectedValue);
                q.miqdar = Convert.ToDouble(txtQuantity.Text);
                q.olcuVahidiid = Convert.ToInt32(cmbUnits.SelectedValue);
                if (q.olcuVahidiid == 0)
                {
                    q.olcuVahidiid = null;
                }
                q.qeyd = txtNote.Text;
                bool result = qORM.Update(q);
                if (result)
                {
                    MessageBox.Show("Düzəliş yerinə yetirildi");
                    frm1.dtgExpensesRefresh();
                    frm1.dtgAccountRefresh();
                    frm1.dtgIncomeRefresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Düzəliş edilərkən səhv açkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            else if (dtpDate.Value > DateTime.Now)
            {
                MessageBox.Show("Bu günün tarixindən böyük tarix girilə bilməz");
                return;
            }
            else if (cmbAccountName.Text == "")
            {
                MessageBox.Show("Hesab adını daxil edin");
                return;
            }
            else if (cmbCategoriya.Text == "")
            {
                MessageBox.Show("Kateqoriya adını daxil edin");
                return;
            }
            else if (txtSum.Text == "" || txtSum.Text == "0.00" || txtSum.Text == ".")
            {
                MessageBox.Show("Məbləğ 0-dan fərqli bir qiymət olmalıdır");
                return;
            }
            else if (txtQuantity.Text == "" || txtQuantity.Text == "0.000" || txtQuantity.Text == ".")
            {
                MessageBox.Show("Miqdarı daxil edin");
                return;
            }
            else
            {
                MessageBox.Show("Məlumatların düzəlişində səhv aşkarlandı.Məlumatlarınızın düzgünlüyünə riayət edin");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sira=0;
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
                if (sum = true && (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57&& (sender as TextBox).SelectionStart > sira)
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
                else if(e.KeyChar == '.' && (sender as TextBox).SelectionStart < (sender as TextBox).Text.Length - 2)
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
            if (txtSum.Text != ""&&txtSum.Text != ".")
            {
                txtSum.Text = string.Format("{0:F2}", (Convert.ToDouble(txtSum.Text))).ToString();
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
            if (sum == false || count < 3 || (sender as TextBox).SelectionStart <= sira)
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
                else if (e.KeyChar == '.' && (sender as TextBox).SelectionStart < (sender as TextBox).Text.Length - 3)
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

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtQuantity.Text != ".")
            {
                txtQuantity.Text = string.Format("{0:F3}", (Convert.ToDouble(txtQuantity.Text))).ToString();
            }
        }
    }
}
