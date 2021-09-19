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
    public partial class UpdateExpenseSubCategory : Form
    {
        public UpdateExpenseSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public UpdateExpenseSubCategory(Categories c_uxsc)
        {
            InitializeComponent();
            c = c_uxsc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateExpenseSubCategory_Load(object sender, EventArgs e)
        {   
            lblExpenseCategNameinSub.Text = "Xərc Kateqoriya Adı: " + c.dtgExpenseCatego.CurrentRow.Cells["Xərc Kateqoriyaları"].Value.ToString();
            txtExpenseSubCategName.Text = c.dtgExpenseSubCatego.CurrentRow.Cells["Xərc Alt Kateqoriyaları"].Value.ToString();
        }
        IstifadeciXercAltKateqoriyaORM ixakORM = new IstifadeciXercAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciXercAltKateqoriya ixak = new IstifadeciXercAltKateqoriya();
            XercAltKateqoriya xak = new XercAltKateqoriya();
            ixak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            ixak.xercAltKateqoriyaid = (int)c.dtgExpenseSubCatego.CurrentRow.Cells["ID"].Value;
            xak.altXercKateqoriyaAdi = txtExpenseSubCategName.Text;
            xak.xercKateqoriyaid= (int)c.dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
            bool result = ixakORM.UpdateCategori_Istifadeci_XercAltKateqoriya(ixak, xak);
            if (result)
            {
                MessageBox.Show("Düzəliş yerinə yetirildi");
                c.dtgExpenseSubCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Düzəliş yerinə yetirilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
