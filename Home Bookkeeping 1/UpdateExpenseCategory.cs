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
    public partial class UpdateExpenseCategory : Form
    {
        public UpdateExpenseCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public UpdateExpenseCategory(Categories c_uec)
        {
            InitializeComponent();
            c = c_uec;
        }
        IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciXercKateqoriya ixk = new IstifadeciXercKateqoriya();
            XercKateqoriya xk = new XercKateqoriya();
            ixk.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            ixk.xercKateqoriyaid =(int)c.dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
            xk.xercKateqoriyaAdi = txtExpenseCategName.Text;
            bool result = ixkORM.UpdateCategori_Istifadeci_XercKateqoriya(ixk, xk);
            if (result)
            {
                MessageBox.Show("Düzəliş yerinə yetirildi");
                c.dtgExpenseCategoRefresh();
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

        private void UpdateExpenseCategory_Load(object sender, EventArgs e)
        {
            txtExpenseCategName.Text = c.dtgExpenseCatego.CurrentRow.Cells["Xərc Kateqoriyaları"].Value.ToString();
        }
    }
}
