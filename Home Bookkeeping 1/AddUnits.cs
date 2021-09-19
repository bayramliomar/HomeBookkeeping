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
    public partial class AddUnits : Form
    {
        public AddUnits()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public AddUnits(Categories c_au)
        {
            InitializeComponent();
            c = c_au;
        }
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            OlcuVahidi ov = new OlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            ov.olcuVahidAd = txtUnitsName.Text;
            bool result = iovORM.İnsertCategori_Istifadeci_OlcuVahidi(iov, ov);
            if (result)
            {
                MessageBox.Show("Məlumatlar əlavə edildi");
                c.dtgUnitsRefresh();
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
