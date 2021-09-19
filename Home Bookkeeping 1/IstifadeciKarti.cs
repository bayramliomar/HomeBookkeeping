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
    public partial class IstifadeciKarti : Form
    {
        public IstifadeciKarti()
        {
            InitializeComponent();

        }
        string transientName = "Istifadəçi Adı";
        private readonly Manage_user_accounts mua;
        public IstifadeciKarti(Manage_user_accounts ik1)
        {
            InitializeComponent();
            txtUserName.Text = transientName;
            txtUserName.ForeColor = Color.DarkGray;
            mua = ik1;
        }

        IstifadeciORM istORM = new IstifadeciORM();
        private void IstifadeciKarti_Load(object sender, EventArgs e)
        {
            PulVahidiORM pvORM = new PulVahidiORM();
            cmbMoney.DataSource = pvORM.Select();
            cmbMoney.DisplayMember = "Pul Vahidi";
            cmbMoney.ValueMember = "ID";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = transientName;
                txtUserName.ForeColor = Color.DarkGray;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == transientName)
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassRept.Text)
            {

                Istifadeci ist = new Istifadeci();
                ist.istifadeciAd = txtUserName.Text;
                ist.sifre = txtPassword.Text;
                bool result = istORM.Insert(ist);

                if (result)
                {

                    MessageBox.Show("Məlumatlar əlavə edildi");
                    mua.dgridRefresh();
                    IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
                    IstifadeciPulVahidiORM ipvORM = new IstifadeciPulVahidiORM();
                    if (cBoxInsertStandartCateg.Checked == true)
                    {
                        bool result1 = ixkORM.İnsertStandart();
                    }
                    IstifadeciPulVahidi ipv = new IstifadeciPulVahidi();
                    cmbMoney.ValueMember = "ID";
                    ipv.pulVahidiid =(int) cmbMoney.SelectedValue;
                    bool result2 = ipvORM.Insert(ipv);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Məlumat əlavə edilərkən səhv açkarlandı, bu məlumatı daha əvvəl daxil etmədiyinizdən əmin olun!!!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eyni şifrəni daxil edin!", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void IstifadeciKarti_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
