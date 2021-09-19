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
    public partial class DeleteUnits : Form
    {
        public DeleteUnits()
        {
            InitializeComponent();
        }
        private readonly Categories c;
        public DeleteUnits(Categories c_du)
        {
            InitializeComponent();
            c = c_du;
        }
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        private void btnOK_Click(object sender, EventArgs e)
        {
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(c.lblUserID.Text);
            iov.olcuVahidiid = (int)c.dtgUnits.CurrentRow.Cells["ID"].Value;
            bool result = iovORM.DeleteCategori_Istifadeci_OlcuVahidi(iov);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                c.dtgUnitsRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void DeleteUnits_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = c.dtgUnits.CurrentRow.Cells["Ölçü Vahidi"].Value.ToString() + ": ölçü vahidini silmək istədiyinizdən əminsiniz?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
