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
    public partial class UpdateIncomeCategory : Form
    {
        public UpdateIncomeCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public UpdateIncomeCategory(Categories c_uic)
        {
            InitializeComponent();
            c = c_uic;
        }
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            QazancKateqoriya qk = new QazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iqk.qazancKateqoriyaid = (int)c.dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
            qk.qazancKateqoriyaAdi = txtIncomeCategName.Text;
            bool result = iqkORM.UpdateCategori_Istifadeci_QazancKateqoriya(iqk, qk);
            if (result)
            {
                MessageBox.Show("Düzəliş yerinə yetirildi");
                c.dtgIncomeCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Düzəliş yerinə yetirilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateIncomeCategory_Load(object sender, EventArgs e)
        {
           txtIncomeCategName.Text=c.dtgIncomeCatego.CurrentRow.Cells["Qazanc Kateqoriyaları"].Value.ToString();
        }
    }
}
