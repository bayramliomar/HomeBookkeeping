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
    public partial class IncomeCardDelete : Form
    {
        public IncomeCardDelete()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public IncomeCardDelete(Form1 frm_icd)
        {
            InitializeComponent();
            frm1 = frm_icd;
        }
        QazanclarORM qORM = new QazanclarORM();
        private void IncomeCardDelete_Load(object sender, EventArgs e)
        {
            lblMessageDeleteConfirmation.Text = string.Format("{0}-{1}:{2} məlumat silinsin?", frm1.dtgIncome.CurrentRow.Cells["Tarix"].Value, frm1.dtgIncome.CurrentRow.Cells["Kateqoriya Adı"].Value, frm1.dtgIncome.CurrentRow.Cells["Alt Kateqoriya Adı"].Value);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Qazanclar q = new Qazanclar();
            q.ID = (int)frm1.dtgIncome.CurrentRow.Cells["ID"].Value;
            bool result = qORM.Delete(q);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                frm1.dtgExpensesRefresh();
                frm1.dtgAccountRefresh();
                frm1.dtgIncomeRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkar edildi", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
