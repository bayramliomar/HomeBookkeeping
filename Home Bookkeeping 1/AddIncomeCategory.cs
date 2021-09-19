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
    public partial class AddIncomeCategory : Form
    {
        public AddIncomeCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public AddIncomeCategory(Categories c_aic)
        {
            InitializeComponent();
            c = c_aic;
        }
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            QazancKateqoriya qk = new QazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            qk.qazancKateqoriyaAdi = txtIncomeCategName.Text;
            bool result = iqkORM.İnsertCategori_Istifadeci_QazancKateqoriya(iqk, qk);
            if (result)
            {
                MessageBox.Show("Məlumatlar əlavə edildi");
                c.dtgIncomeCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat əlavə edilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
