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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public DeleteAccount(Form1 frm_da)
        {
            InitializeComponent();
            frm1 = frm_da;
        }
        HesablarORM hORM = new HesablarORM(); 
        private void btnOK_Click(object sender, EventArgs e)
        {
            Hesablar h = new Hesablar();
            h.ID = Convert.ToInt32(frm1.dtgAccount.CurrentRow.Cells["ID"].Value);
            bool result = hORM.Delete(h);
            if (result)
            {
                MessageBox.Show("Məlumat silindi");
                frm1.dtgAccountRefresh();
                frm1.AccountSearch();
                this.Close();
            }
            else
            {
                MessageBox.Show("Məlumat silinərkən səhv aşkarlandı", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            lblInformationDelete.Text = frm1.dtgAccount.CurrentRow.Cells["Hesab Adı"].Value.ToString() + ": hesabını silmək istədiyinizdən əminsiniz?";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
