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
    public partial class AddExpenseSubCategory : Form
    {
        public AddExpenseSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public AddExpenseSubCategory(Categories c_axsc)
        {
            InitializeComponent();
            c = c_axsc;
        }
        IstifadeciXercAltKateqoriyaORM ixakORM = new IstifadeciXercAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        { 
            IstifadeciXercAltKateqoriya ixak = new IstifadeciXercAltKateqoriya();
            XercAltKateqoriya xak = new XercAltKateqoriya();
            ixak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            xak.altXercKateqoriyaAdi = txtExpenseSubCategName.Text;
            xak.xercKateqoriyaid = (int)c.dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
            bool result = ixakORM.İnsertCategori_Istifadeci_XercAltKateqoriya(ixak, xak);
            if (result)
            {
                MessageBox.Show("Məlumatlar əlavə edildi");
                c.dtgExpenseSubCategoRefresh();
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

        private void AddExpenseSubCategory_Load(object sender, EventArgs e)
        {
            lblExpenseCategNameinSub.Text="Xərc Kateqoriya: "+ c.dtgExpenseCatego.CurrentRow.Cells["Xərc Kateqoriyaları"].Value.ToString();
        }
    }
}
