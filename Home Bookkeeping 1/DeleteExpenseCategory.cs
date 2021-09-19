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
    public partial class DeleteExpenseCategory : Form
    {
        public DeleteExpenseCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public DeleteExpenseCategory(Categories c_dec)
        {
            InitializeComponent();
            c = c_dec;
        }
        IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciXercKateqoriya ixk = new IstifadeciXercKateqoriya();
            ixk.istifadeciid =Convert.ToInt32(c.lblUserID.Text);
            ixk.xercKateqoriyaid= (int)c.dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
            bool result= ixkORM.DeleteCategori_Istifadeci_XercKateqoriya(ixk);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                c.dtgExpenseCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteExpenseCategory_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = c.dtgExpenseCatego.CurrentRow.Cells["Xərc Kateqoriyaları"].Value.ToString()+": xərc kateqoriyasını silmək istədiyinizdən əminsiniz?";
        }
    }
}
