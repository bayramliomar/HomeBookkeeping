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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public Categories(Form1 fc)
        {
            InitializeComponent();
            frm1 = fc;
        }
        IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
        IstifadeciXercAltKateqoriyaORM ixakORM = new IstifadeciXercAltKateqoriyaORM();
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        IstifadeciQazancAltKateqoriyaORM iqakORM = new IstifadeciQazancAltKateqoriyaORM();
        IstifadeciOlcuVahidiORM iovORM = new IstifadeciOlcuVahidiORM();
        public void dtgExpenseCategoRefresh()
        {
            IstifadeciXercKateqoriya ixk = new IstifadeciXercKateqoriya();
            ixk.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            dtgExpenseCatego.DataSource = ixkORM.Select(ixk);
            dtgExpenseCatego.Columns["ID"].Visible = false;
            if (dtgExpenseCatego != null)
            {
                dtgExpenseCatego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgExpenseCatego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgExpenseCatego.Columns[dtgExpenseCatego.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblExpenseCategCount.Text = dtgExpenseCatego.RowCount.ToString();
        }
        public void dtgExpenseSubCategoRefresh()
        {
            if (dtgExpenseCatego.SelectedRows.Count > 0)
            {
                IstifadeciXercAltKateqoriya ixak = new IstifadeciXercAltKateqoriya();
                XercAltKateqoriya xak = new XercAltKateqoriya();
                ixak.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
                xak.xercKateqoriyaid = (int)dtgExpenseCatego.CurrentRow.Cells["ID"].Value;
                dtgExpenseSubCatego.DataSource = ixakORM.Select(ixak, xak);
                dtgExpenseSubCatego.Columns["ID"].Visible = false;
                if (dtgExpenseSubCatego != null)
                {
                    dtgExpenseSubCatego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgExpenseSubCatego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dtgExpenseSubCatego.Columns[dtgExpenseSubCatego.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                lblExpenseSubCategCount.Text = dtgExpenseSubCatego.RowCount.ToString();
            }
            else
            {
                dtgExpenseSubCatego.DataSource = null;
            }
        }
        public void dtgIncomeCategoRefresh()
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            dtgIncomeCatego.DataSource = iqkORM.Select(iqk);
            dtgIncomeCatego.Columns["ID"].Visible = false;
            if (dtgIncomeCatego != null)
            {
                dtgIncomeCatego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgIncomeCatego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgIncomeCatego.Columns[dtgIncomeCatego.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblIncomeCategCount.Text = dtgIncomeCatego.RowCount.ToString();
        }
        public void dtgIncomeSubCategoRefresh()
        {
            if (dtgIncomeCatego.SelectedRows.Count > 0)
            {
                IstifadeciQazancAltKateqoriya iqak = new IstifadeciQazancAltKateqoriya();
                QazancAltKateqoriya qak = new QazancAltKateqoriya();
                iqak.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
                qak.qazancKateqoriyaid = (int)dtgIncomeCatego.CurrentRow.Cells["ID"].Value;
                dtgIncomeSubCatego.DataSource = iqakORM.Select(iqak, qak);
                dtgIncomeSubCatego.Columns["ID"].Visible = false;
                if (dtgIncomeSubCatego != null)
                {
                    dtgIncomeSubCatego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgIncomeSubCatego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dtgIncomeSubCatego.Columns[dtgIncomeSubCatego.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                lblIncomeSubCategCount.Text = dtgIncomeSubCatego.RowCount.ToString();
            }
            else
            {
                dtgIncomeSubCatego.DataSource = null;
            }
        }
        public void dtgUnitsRefresh()
        {
            IstifadeciOlcuVahidi iov = new IstifadeciOlcuVahidi();
            iov.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            dtgUnits.DataSource = iovORM.Select(iov);
            dtgUnits.Columns["ID"].Visible = false;
            if (dtgUnits != null)
            {
                dtgUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgUnits.Columns[dtgUnits.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblUnitsCount.Text = dtgUnits.RowCount.ToString();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            lblUserID.Text = frm1.lblUserID.Text;
            dtgExpenseCategoRefresh();
            dtgIncomeCategoRefresh();
            dtgUnitsRefresh();
        }

        private void btnInsertCateg_Click(object sender, EventArgs e)
        {
            AddExpenseCategory aec = new AddExpenseCategory(this);
            aec.ShowDialog();
        }

        private void btnUpdateCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenseCatego.SelectedRows.Count > 0)
            {
                UpdateExpenseCategory uec = new UpdateExpenseCategory(this);
                uec.Show();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenseCatego.SelectedRows.Count > 0)
            {
                DeleteExpenseCategory dec = new DeleteExpenseCategory(this);
                dec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }



        private void dtgExpenseCatego_SelectionChanged(object sender, EventArgs e)
        {
            dtgExpenseSubCategoRefresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.dtgExpensesRefresh();
            frm1.dtgIncomeRefresh();
            frm1.ExpenseCategorySearch();
            frm1.IncomeCategorySearch();
            frm1.AccountSearch();
        }

        private void btnİnsertSubCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenseCatego.SelectedRows.Count > 0)
            {
                AddExpenseSubCategory axsc = new AddExpenseSubCategory(this);
                axsc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alt kateqoriya əlavə edə bilmək üçün bir kateqoriya seçin");
            }
        }

        private void btnUpdateSubCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenseSubCatego.SelectedRows.Count > 0)
            {
                UpdateExpenseSubCategory uxsc = new UpdateExpenseSubCategory(this);
                uxsc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alt kateqoriya seçili deyil");
            }
        }

        private void btnDeleteSubCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenseSubCatego.SelectedRows.Count > 0)
            {
                DeleteExpenseSubCategory dxsc = new DeleteExpenseSubCategory(this);
                dxsc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alt kateqoriya seçili deyil");
            }
        }

        private void dtgIncomeCatego_SelectionChanged(object sender, EventArgs e)
        {
            dtgIncomeSubCategoRefresh();
        }

        private void btnIncomeCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertIncomeCateg_Click(object sender, EventArgs e)
        {
            AddIncomeCategory aic = new AddIncomeCategory(this);
            aic.ShowDialog();
        }

        private void btnUpdateIncomeCateg_Click(object sender, EventArgs e)
        {
            if (dtgIncomeCatego.SelectedRows.Count > 0)
            {
                UpdateIncomeCategory uic = new UpdateIncomeCategory(this);
                uic.ShowDialog();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDeleteIncomeCateg_Click(object sender, EventArgs e)
        {
            if (dtgIncomeCatego.SelectedRows.Count > 0)
            {
                DeleteIncomeCategory dic = new DeleteIncomeCategory(this);
                dic.ShowDialog();
            }
            else
            {
                MessageBox.Show("Heç bir məlumat seçili deyil", "Diqqət", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
           
        }

        private void btnInsertIncomeSubCateg_Click(object sender, EventArgs e)
        {
            AddIncomeSubCategory aisc = new AddIncomeSubCategory(this);
            aisc.ShowDialog();
        }

        private void btnUpdateIncomeSubCateg_Click(object sender, EventArgs e)
        {
            if (dtgIncomeSubCatego.SelectedRows.Count > 0)
            {
                UpdateIncomeSubCategory uisc = new UpdateIncomeSubCategory(this);
                uisc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alt kateqoriya seçili deyil");
            }
           
        }

        private void btnDeleteIncomeSubCateg_Click(object sender, EventArgs e)
        {
            if (dtgIncomeSubCatego.SelectedRows.Count > 0)
            {
                DeleteIncomeSubCategory disc = new DeleteIncomeSubCategory(this);
                disc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alt kateqoriya seçili deyil");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUnits au = new AddUnits(this);
            au.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtgUnits.SelectedRows.Count > 0)
            {
                UpdateUnits uu = new UpdateUnits(this);
                uu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ölçü Vahidi seçili deyil");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgUnits.SelectedRows.Count > 0)
            {
                DeleteUnits du = new DeleteUnits(this);
                du.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ölçü Vahidi seçili deyil");
            }
        }
    }
}
