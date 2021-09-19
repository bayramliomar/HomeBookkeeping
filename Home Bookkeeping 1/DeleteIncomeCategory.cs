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
    public partial class DeleteIncomeCategory : Form
    {
        public DeleteIncomeCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public DeleteIncomeCategory(Categories   c_dic)
        {
            InitializeComponent();
            c = c_dic;
        }
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iqk.qazancKateqoriyaid = (int)c.dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
            bool result = iqkORM.DeleteCategori_Istifadeci_QazancKateqoriya(iqk);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                c.dtgIncomeCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DeleteIncomeCategory_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = c.dtgIncomeCatego.CurrentRow.Cells["Qazanc Kateqoriyaları"].Value.ToString() + ": qazanc kateqoriyasını silmək istədiyinizdən əminsiniz?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
