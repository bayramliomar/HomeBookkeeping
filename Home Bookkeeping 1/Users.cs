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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        
        private void btnmanageuser_Click(object sender, EventArgs e)
        {
            Manage_user_accounts mua1 = new Manage_user_accounts(this);
            mua1.ShowDialog();

        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        IstifadeciORM istORM = new IstifadeciORM();
        public void cmbusersRefresh()
        {
            cmbusers.DataSource = istORM.Select();
           
          
        }

        private void Users_Load(object sender, EventArgs e)
        {
            cmbusers.DisplayMember = "istifadeciAd";
            cmbusers.ValueMember = "ID";
            cmbusersRefresh();
            

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {   
            Confirmation_Enter ce = new Confirmation_Enter();
            ce.lblUserName.Text = this.cmbusers.GetItemText(this.cmbusers.SelectedItem);
            ce.lblUserID.Text = this.cmbusers.GetItemText(this.cmbusers.SelectedValue);
            ce.Show();
            this.Hide();
           
        }
    }
}
