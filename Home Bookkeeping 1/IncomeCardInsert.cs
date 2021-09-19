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
    public partial class IncomeCardInsert : Form
    {
        public IncomeCardInsert()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public IncomeCardInsert(Form1 frm_ici)
        {
            InitializeComponent();
            frm1 = frm_ici;
        }
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        IstifadeciPulVahidiORM ipvORM = new IstifadeciPulVahidiORM();
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        HesablarORM hORM = new HesablarORM();
        QazanclarORM qORM = new QazanclarORM();
        private void IncomeCardInsert_Load(object sender, EventArgs e)
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbCategoriya.DataSource = iqkORM.Select(iqk);
            cmbCategoriya.DisplayMember = "Qazanc Kateqoriyaları";
            cmbCategoriya.ValueMember = "ID";
            IstifadeciPulVahidi ipv = new IstifadeciPulVahidi();
            ipv.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbMoney.DataSource = ipvORM.Select(ipv);
            cmbMoney.DisplayMember = "Pul Vahidi";
            cmbMoney.ValueMember = "ID";
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbAccountName.DataSource = hORM.Select(h, "prc_HesablarCombobox_Select");
            cmbAccountName.DisplayMember = "Hesab Adı";
            cmbAccountName.ValueMember = "ID";
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            cmbUnits.DataSource = iovORM.Select(iov);
            cmbUnits.DisplayMember = "Ölçü Vahidi";
            cmbUnits.ValueMember = "ID";
            txtQuantity.Text = "1";
            txtSum.Text = "0";
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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(dtpDate.Value <= DateTime.Now && (txtSum.Text != "0.00" && txtSum.Text != "" && txtSum.Text != ".") && (txtQuantity.Text != "0.000" && txtQuantity.Text != "" && txtQuantity.Text != ".")
                && cmbAccountName.Text != "" && cmbCategoriya.Text != "")
            {
                Qazanclar q = new Qazanclar();
                q.qazancTarix = dtpDate.Value;
                q.hesabid = Convert.ToInt32(cmbAccountName.SelectedValue);
                q.kateqoriyaid = Convert.ToInt32(cmbCategoriya.SelectedValue);
                q.altKateqoriyaid = Convert.ToInt32(cmbSubCategoriya.SelectedValue);
                if (q.altKateqoriyaid == 0)
                {
                    q.altKateqoriyaid= null;
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
                bool result = qORM.Insert(q);
                if (result)
                {
                    MessageBox.Show("Məlumatlar əlavə edildi");
                    frm1.dtgExpensesRefresh();
                    frm1.dtgAccountRefresh();
                    frm1.dtgIncomeRefresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Məlumat əlavə edilərkən səhv açkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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
            else if (txtSum.Text == "" || txtSum.Text == "0.00"||txtSum.Text==".")
            {
                MessageBox.Show("Məbləğ 0-dan fərqli bir qiymət olmalıdır");
                return;
            }
            else if (txtQuantity.Text == "" || txtQuantity.Text == "0.000"||txtQuantity.Text==".")
            {
                MessageBox.Show("Miqdarı daxil edin");
                return;
            }
            else
            {
                MessageBox.Show("Məlumatların daxil edilməsində səhv aşkarlandı.Məlumatlarınızın düzgünlüyünə riayət edin");
                return;
            }
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

        private void txtSum_Leave(object sender, EventArgs e)
        {
            if (txtSum.Text != ""&&txtSum.Text!=".")
            {
                txtSum.Text = string.Format("{0:F2}", (Convert.ToDouble(txtSum.Text))).ToString();
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtQuantity.Text != ".")
            {
                txtQuantity.Text = string.Format("{0:F3}", (Convert.ToDouble(txtQuantity.Text))).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
