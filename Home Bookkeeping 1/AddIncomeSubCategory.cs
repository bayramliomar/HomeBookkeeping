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
    public partial class AddIncomeSubCategory : Form
    {
        public AddIncomeSubCategory()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public AddIncomeSubCategory(Categories c_aisc)
        {
            InitializeComponent();
            c = c_aisc;
        }
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciQazancAltKateqoriya iqak = new IstifadeciQazancAltKateqoriya();
            QazancAltKateqoriya qak = new QazancAltKateqoriya();
            iqak.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            qak.altQazancKateqoriyaAdi = txtIncomeSubCategName.Text;
            qak.qazancKateqoriyaid = (int)c.dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
            bool result = iqakORM.İnsertCategori_Istifadeci_QazancAltKateqoriya(iqak, qak);
            if (result)
            {
                MessageBox.Show("Məlumatlar əlavə edildi");
                c.dtgIncomeSubCategoRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat əlavə edilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void AddIncomeSubCategory_Load(object sender, EventArgs e)
        {
            lblIncomeCategNameinSub.Text = "Qazanc Kateqoriya: " + c.dtgIncomeCatego.CurrentRow.Cells["Qazanc Kateqoriyaları"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
