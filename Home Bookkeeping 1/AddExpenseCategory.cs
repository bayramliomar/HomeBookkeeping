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
    public partial class AddExpenseCategory : Form
    {
        public AddExpenseCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public AddExpenseCategory(Categories aec_c)
        {
            InitializeComponent();
            c = aec_c;
        }
        IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciXercKateqoriya ixk = new IstifadeciXercKateqoriya();
            XercKateqoriya xk = new XercKateqoriya();
            ixk.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            xk.xercKateqoriyaAdi = txtExpenseCategName.Text;
            bool result = ixkORM.İnsertCategori_Istifadeci_XercKateqoriya(ixk, xk);
            if (result)
            {
                MessageBox.Show("Məlumatlar əlavə edildi");
                c.dtgExpenseCategoRefresh();
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
