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
    public partial class Confirmation_Enter : Form
    {
        public Confirmation_Enter()
        {
            InitializeComponent();
        }
        //private readonly Users u;
        //public Confirmation_Enter(Users u_ce)
        //{
        //    InitializeComponent();
        //    u = u_ce;
        //}
        int clickCount;
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
                Form1 frm1 = new Form1(this);
                clickCount += 1;
                frm1.Show();
                this.Close();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmation_Enter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clickCount ==0)
            {
                Users u = new Users();
                u.Show();
            }

        }
    }
}
