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
    public partial class Manage_user_accounts : Form
    {
        public Manage_user_accounts()
        {
            InitializeComponent();

        }
        private readonly Users usr;
        public Manage_user_accounts(Users mua1)
        {
            InitializeComponent();
            usr = mua1;
        }
        IstifadeciORM istORM = new IstifadeciORM();
        public void dgridRefresh()
        {
            dtgUsers.DataSource = istORM.Select();
            dtgUsers.Columns["ID"].Visible = false;
            if (dtgUsers != null)
            {
                dtgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgUsers.Columns[dtgUsers.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblUsersCount.Text = dtgUsers.RowCount.ToString();
        }
        private void Manage_user_accounts_Load(object sender, EventArgs e)
        {
            
            dgridRefresh();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            usr.cmbusersRefresh();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            IstifadeciKarti ik = new IstifadeciKarti(this);
            //if (ik.IsDisposed)
            //{
            //    ik = new IstifadeciKarti(this);
            //}
            ik.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Confirmation_Update c = new Confirmation_Update(this);
            if (dtgUsers.SelectedRows.Count > 0)
            {
                c.lblUserName.Text = dtgUsers.CurrentRow.Cells["istifadeciAd"].Value.ToString();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void Manage_user_accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            usr.cmbusersRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Confirmation_Delete cd = new Confirmation_Delete(this);
            if (dtgUsers.SelectedRows.Count > 0)
            {
                cd.lblUserName.Text = dtgUsers.CurrentRow.Cells["istifadeciAd"].Value.ToString();
                cd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }
    }
}
