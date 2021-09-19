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
    public partial class Confirmation_Update : Form
    {
       
        public Confirmation_Update()
        {
            InitializeComponent();
        
                  
        }
        private readonly Manage_user_accounts mua1;
        public Confirmation_Update(Manage_user_accounts c1)
        {
            InitializeComponent();
            mua1 = c1;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            IstifadeciORM istORM = new IstifadeciORM();
            Istifadeci ist = new Istifadeci();
            ist.istifadeciAd = lblUserName.Text;
            ist.sifre = txtPassword.Text;
            Istifadeci aktiv= istORM.UserCatch(ist);
            if (aktiv == null)
            {
                MessageBox.Show("Şifrə yanlışdır","Diqqət",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                IstifadeciORM.aktivUser = aktiv;
                UserCardUpdate ucu = new UserCardUpdate(this);
                ucu.txtUserName.Text = IstifadeciORM.aktivUser.istifadeciAd;
                ucu.txtPassword.Text= IstifadeciORM.aktivUser.sifre;
                ucu.txtPassRept.Text = IstifadeciORM.aktivUser.sifre;
                ucu.lblID.Text = IstifadeciORM.aktivUser.ID.ToString();
                ucu.ShowDialog();
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mua1.dgridRefresh();
            this.Close();
        }

        private void Confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            mua1.dgridRefresh();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
