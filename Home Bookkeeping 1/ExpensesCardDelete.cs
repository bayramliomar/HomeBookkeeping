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
    public partial class ExpensesCardDelete : Form
    {
        public ExpensesCardDelete()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public ExpensesCardDelete(Form1 frm_ecd)
        {
            InitializeComponent();
            frm1 = frm_ecd;
        }

        private void ExpensesCardDelete_Load(object sender, EventArgs e)
        {
            lblMessageDeleteConfirmation.Text = string.Format("{0}-{1}:{2} məlumat silinsin?",frm1.dtgExpenses.CurrentRow.Cells["Tarix"].Value, frm1.dtgExpenses.CurrentRow.Cells["Kateqoriya Adı"].Value, frm1.dtgExpenses.CurrentRow.Cells["Alt Kateqoriya Adı"].Value);

        }
        XerclerORM xORM = new XerclerORM();
        private void button1_Click(object sender, EventArgs e)
        {
            Xercler x = new Xercler();
            x.ID =(int)frm1.dtgExpenses.CurrentRow.Cells["ID"].Value;
            bool result = xORM.Delete(x);
            if (result)
            {
                frm1.cBoxFilter.Checked = false;
                MessageBox.Show("Məlumat silindi");
                frm1.dtgExpensesRefresh();
                frm1.dtgAccountRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkar edildi", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
