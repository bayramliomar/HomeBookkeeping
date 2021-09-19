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
    public partial class DeleteIncomeSubCategory : Form
    {
        public DeleteIncomeSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public DeleteIncomeSubCategory(Categories c_disc)
        {
            InitializeComponent();
            c = c_disc;
        }
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancAltKateqoriya iqak = new IstifadeciQazancAltKateqoriya();
            QazancAltKateqoriya qak = new QazancAltKateqoriya();
            iqak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iqak.qazancAltKateqoriyaid = (int)c.dtgIncomeSubCatego.CurrentRow.Cells["ID"].Value;
            qak.qazancKateqoriyaid = (int)c.dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
            bool result = iqakORM.DeleteCategori_Istifadeci_QazancAltKateqoriya(iqak, qak);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                c.dtgIncomeSubCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DeleteIncomeSubCategory_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = c.dtgIncomeSubCatego.CurrentRow.Cells["Qazanc Alt Kateqoriyaları"].Value.ToString() + ": qazanc kateqoriyasını silmək istədiyinizdən əminsiniz?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
