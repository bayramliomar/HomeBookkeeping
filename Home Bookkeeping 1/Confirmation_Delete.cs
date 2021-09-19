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
    public partial class Confirmation_Delete : Form
    {
        public Confirmation_Delete()
        {
            InitializeComponent();
        }
        private readonly Manage_user_accounts mua;
        public Confirmation_Delete(Manage_user_accounts mc)
        {
            InitializeComponent();
            mua = mc;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IstifadeciORM istORM = new IstifadeciORM();
            Istifadeci ist = new Istifadeci();
            ist.istifadeciAd = lblUserName.Text;
            ist.sifre = txtPassword.Text;
            Istifadeci aktiv = istORM.UserCatch(ist);
            if (aktiv == null)
            {
                MessageBox.Show("Şifrə yanlışdır", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                IstifadeciORM.aktivUser = aktiv;
                ist.ID = IstifadeciORM.aktivUser.ID;
                bool result = istORM.Delete(ist);
                if (result)
                {
                    MessageBox.Show("Məlumat silindi");
                    mua.dgridRefresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Məlumat silinərkən səhv aşkar edildi", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
