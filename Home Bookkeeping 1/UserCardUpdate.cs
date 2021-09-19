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
    public partial class UserCardUpdate : Form
    {
        public UserCardUpdate()
        {
            InitializeComponent();
        }
        private readonly Confirmation_Update c;
        public UserCardUpdate(Confirmation_Update ucu1)
        {
            InitializeComponent();
            c = ucu1;
        }
        IstifadeciORM istORM = new IstifadeciORM();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.Text == txtPassRept.Text)
            {
                Istifadeci ist = new Istifadeci();
                ist.istifadeciAd = txtUserName.Text;
                ist.sifre = txtPassword.Text;
                ist.ID = int.Parse(lblID.Text);
                bool result = istORM.Update(ist);
                if (result)
                {
                    MessageBox.Show("Düzəliş yerinə yetirildi");
                    c.lblUserName.Text = txtUserName.Text;
                    c.txtPassword.Text = txtPassword.Text;
                    this.Close();

                    
                }
                else
                {
                    MessageBox.Show("Düzəliş edilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eyni şifrəni daxil edin!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserCardUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
