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
    public partial class UpdateIncomeSubCategory : Form
    {
        public UpdateIncomeSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public UpdateIncomeSubCategory(Categories c_uisc)
        {
            InitializeComponent();
            c = c_uisc;
        }
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancAltKateqoriya iqak = new IstifadeciQazancAltKateqoriya();
            QazancAltKateqoriya qak = new QazancAltKateqoriya();
            iqak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iqak.qazancAltKateqoriyaid = (int)c.dtgIncomeSubCatego.CurrentRow.Cells["ID"].Value;
            qak.altQazancKateqoriyaAdi = txtIncomeSubCategName.Text;
            qak.qazancKateqoriyaid = (int)c.dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
            bool result = iqakORM.UpdateCategori_Istifadeci_QazancAltKateqoriya(iqak, qak);
            if (result)
            {
                MessageBox.Show("Düzəliş yerinə yetirildi");
                c.dtgIncomeSubCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Düzəliş yerinə yetirilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void UpdateIncomeSubCategory_Load(object sender, EventArgs e)
        {
            lblIncomeCategNameinSub.Text = "Qazanc Kateqoriya Adı: " + c.dtgIncomeCatego.CurrentRow.Cells["Qazanc Kateqoriyaları"].Value.ToString();
            txtIncomeSubCategName.Text = c.dtgIncomeSubCatego.CurrentRow.Cells["Qazanc Alt Kateqoriyaları"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
