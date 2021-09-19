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
    public partial class DeleteExpenseSubCategory : Form
    {
        public DeleteExpenseSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public DeleteExpenseSubCategory(Categories c_desc)
        {
            InitializeComponent();
            c = c_desc;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteExpenseSubCategory_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = c.dtgExpenseSubCatego.CurrentRow.Cells["Xərc Alt Kateqoriyaları"].Value.ToString() + ": xərc kateqoriyasını silmək istədiyinizdən əminsiniz?";
        }
        IstifadeciXercAltKateqoriyaORM ixakORM = new IstifadeciXercAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciXercAltKateqoriya ixak = new IstifadeciXercAltKateqoriya();
            XercAltKateqoriya xak = new XercAltKateqoriya();
            ixak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            ixak.xercAltKateqoriyaid = (int)c.dtgExpenseSubCatego.CurrentRow.Cells["ID"].Value;
            xak.xercKateqoriyaid= (int)c.dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
            bool result = ixakORM.DeleteCategori_Istifadeci_XercAltKateqoriya(ixak, xak);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                c.dtgExpenseSubCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
