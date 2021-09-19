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
    public partial class UpdateUnits : Form
    {
        public UpdateUnits()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public UpdateUnits(Categories c_uu)
        {
            InitializeComponent();
            c = c_uu;
        }
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            OlcuVahidi ov = new OlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iov.olcuVahidiid = (int)c.dtgUnits.CurrentRow.Cells["ID"].Value;
            ov.olcuVahidAd = txtUnitsName.Text;
            bool result = iovORM.UpdateCategori_Istifadeci_OlcuVahidi(iov, ov);
            if (result)
            {
                MessageBox.Show("Düzəliş yerinə yetirildi");
                c.dtgUnitsRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Düzəliş yerinə yetirilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void UpdateUnits_Load(object sender, EventArgs e)
        {
         txtUnitsName.Text = c.dtgUnits.CurrentRow.Cells["Ölçü Vahidi"].Value.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
