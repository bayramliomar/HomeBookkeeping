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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Confirmation_Enter ce;
        public Form1(Confirmation_Enter ce1)
        {
            InitializeComponent();
            ce = ce1;
        }
        Users usr = new Users();
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (usr.IsDisposed)
            {
                usr = new Users();
            }
            usr.Show();
            this.Hide();
        }
        HesablarORM hORM = new HesablarORM();
        XerclerORM xORM = new XerclerORM();
        QazanclarORM qORM = new QazanclarORM();
        IstifadeciXercKateqoriyaORM ixkORM = new IstifadeciXercKateqoriyaORM();
        IstifadeciQazancKateqoriyaORM iqkORM = new IstifadeciQazancKateqoriyaORM();
        public void dtgAccountRefresh()
        {   
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            lblUserID.Text = h.istifadeciid.ToString();
            dtgAccount.DataSource = hORM.Select(h, "prc_Hesablar_Select");
            dtgAccount.Columns["ID"].Visible = false;
            dtgAccount.Columns["Seçim"].Visible = false;
            dtgAccount.Columns["Tarix"].Visible = false;
            dtgAccount.Columns["Xərc Məbləği"].DefaultCellStyle.Format = "F";
            dtgAccount.Columns["Qazanc Məbləği"].DefaultCellStyle.Format = "F";
            dtgAccount.Columns["Hesab Məbləği"].DefaultCellStyle.Format = "F";
            dtgAccount.Columns["Toplam Məbləğ"].DefaultCellStyle.Format = "F";
            for (int i = 0; i < dtgAccount.RowCount; i++)
            {
                if (Convert.ToDouble(dtgAccount.Rows[i].Cells["Toplam Məbləğ"].Value) < 0)
                {
                    dtgAccount.Rows[i].Cells["Toplam Məbləğ"].Style.ForeColor = Color.Red;
                }
            }
            if (dtgAccount != null)
            {
                dtgAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgAccount.Columns[dtgAccount.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblAccountCount.Text = dtgAccount.RowCount.ToString();
            string pulTip="";
            if (dtgExpenses.RowCount > 0)
            {
                pulTip = dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString();
            }
            else if (dtgIncome.RowCount > 0)
            {
                pulTip = dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString();
            }
            if (hORM.Select(h, "prc_Hesablar_AccountSum").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblAccountSum.Text =pulTip+string.Format("{0:F}", hORM.Select(h, "prc_Hesablar_AccountSum").Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblAccountSum.Text = pulTip + "0.00";
            }
            if (hORM.Select(h, "prc_Hesablar_TotalSum").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                
                lblTotalSum.Text = pulTip + string.Format("{0:F}", hORM.Select(h, "prc_Hesablar_TotalSum").Rows[0]["Toplam Məbləğ"]);
                if (Convert.ToDouble(hORM.Select(h, "prc_Hesablar_TotalSum").Rows[0]["Toplam Məbləğ"]) < 0)
                {
                    lblTotalSum.ForeColor = Color.Red;
                }
                else
                {
                    lblTotalSum.ForeColor = Color.Black;
                }
            }
            else
            {
                lblTotalSum.Text = pulTip + "0.00";
            }
            if (hORM.Select(h, "prc_Hesablar_ExpenseSum").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblExpenseSumAccount.Text = pulTip + string.Format("{0:F}", hORM.Select(h, "prc_Hesablar_ExpenseSum").Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblExpenseSumAccount.Text = pulTip + "0.00";
            }
            if (hORM.Select(h, "prc_Hesablar_IncomeSum").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblIncomeSumAccount.Text = pulTip + string.Format("{0:F}", hORM.Select(h, "prc_Hesablar_IncomeSum").Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblIncomeSumAccount.Text = pulTip+"0.00";
            }
        }
        public void dtgExpensesRefresh()
        {
            Istifadeci i = new Istifadeci();
            i.ID = Convert.ToInt32(ce.lblUserID.Text);
            lblUserID.Text = i.ID.ToString();
            dtgExpenses.DataSource = xORM.Select(i);
            dtgExpenses.Columns["ID"].Visible = false;
            dtgExpenses.Columns["endirim"].Visible = false;
            dtgExpenses.Columns["Məbləğ"].DefaultCellStyle.Format = "F";
            if (dtgExpenses != null)
            {
                dtgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgExpenses.Columns[dtgExpenses.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblExpenseCount.Text = dtgExpenses.RowCount.ToString();
            if (xORM.SelectSum(i).Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblExpenseSum.Text = dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.SelectSum(i).Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblExpenseSum.Text = "0.00";
            }
            ExpenseDateValue();
        }
        public void ExpenseDateValue()
        {
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            if ((xORM.ExpenseSum(h,"Daily").Rows[0]["Günlük Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseDaily.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.ExpenseSum(h, "Daily").Rows[0]["Günlük Xərc Məbləği"]));
            }
            else
            {
                lblExpenseDaily.Text = "0.00";
            }
            if ((xORM.ExpenseSum(h, "Weekly").Rows[0]["Son 1 Həftəlik Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseWeekly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.ExpenseSum(h, "Weekly").Rows[0]["Son 1 Həftəlik Xərc Məbləği"]));
            }
            else
            {
                lblExpenseWeekly.Text = "0.00";
            }
            if ((xORM.ExpenseSum(h, "Monthly").Rows[0]["Son 1 Aylıq Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseMonthly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.ExpenseSum(h, "Monthly").Rows[0]["Son 1 Aylıq Xərc Məbləği"]));
            }
            else
            {
                lblExpenseMonthly.Text = "0.00";
            }
            if ((xORM.ExpenseSum(h, "Yearly").Rows[0]["Son 1 İllik Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseYearly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.ExpenseSum(h, "Yearly").Rows[0]["Son 1 İllik Xərc Məbləği"]));
            }
            else
            {
                lblExpenseYearly.Text = "0.00";
            }

        }
        public void dtgExpensesSearch()
        {
            Istifadeci i = new Istifadeci();
            Xercler x = new Xercler();
            XercKateqoriya xk = new XercKateqoriya();
            Hesablar h = new Hesablar();
            i.ID = Convert.ToInt32(ce.lblUserID.Text);
            lblUserID.Text = i.ID.ToString();
            if (mstBoxFromDate.Text == "  /  /")
            {
                xORM.xercTarixStart = null;
            }
            else
            {
                xORM.xercTarixStart = Convert.ToDateTime(mstBoxFromDate.Text);
            }
            if (mstBoxTillDate.Text == "  /  /")
            {
                xORM.xercTarixEnd = null;
            }
            else
            {
                xORM.xercTarixEnd = Convert.ToDateTime(mstBoxTillDate.Text);
            }
            xk.xercKateqoriyaAdi = cmbExpenseCategorySearch.GetItemText(cmbExpenseCategorySearch.SelectedItem); /*Convert.ToInt32(cmbExpenseCategorySearch.SelectedValue);*/
            h.hesabAdi = cmbAccountSearch.GetItemText(cmbAccountSearch.SelectedItem); /*Convert.ToInt32(cmbAccountSearch.SelectedValue);*/
            dtgExpenses.DataSource = xORM.All_Search(i, x, xk, h, "prc_Xercler_Search");
            dtgExpenses.Columns["ID"].Visible = false;
            dtgExpenses.Columns["endirim"].Visible = false;
            dtgExpenses.Columns["Məbləğ"].DefaultCellStyle.Format = "F";
            if (dtgExpenses != null)
            {
                dtgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgExpenses.Columns[dtgExpenses.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblExpenseCount.Text = dtgExpenses.RowCount.ToString();
            if (xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblExpenseSum.Text = dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search").Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblExpenseSum.Text = "0.00";
            }
            /////////////////////
            if ((xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Daily").Rows[0]["Günlük Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseDaily.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Daily").Rows[0]["Günlük Xərc Məbləği"]));
            }
            else
            {
                lblExpenseDaily.Text = "0.00";
            }
            if ((xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Weekly").Rows[0]["Son 1 Həftəlik Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseWeekly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Weekly").Rows[0]["Son 1 Həftəlik Xərc Məbləği"]));
            }
            else
            {
                lblExpenseWeekly.Text = "0.00";
            }
            if ((xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Monthly").Rows[0]["Son 1 Aylıq Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseMonthly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Monthly").Rows[0]["Son 1 Aylıq Xərc Məbləği"]));
            }
            else
            {
                lblExpenseMonthly.Text = "0.00";
            }
            if ((xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Yearly").Rows[0]["Son 1 İllik Xərc Məbləği"]).ToString() != "")
            {
                lblExpenseYearly.Text = (dtgExpenses.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", xORM.All_Search(i, x, xk, h, "prc_Xercler_Sum_Search_Yearly").Rows[0]["Son 1 İllik Xərc Məbləği"]));
            }
            else
            {
                lblExpenseYearly.Text = "0.00";
            }
        }
        public void dtgIncomeRefresh()
        {
            Istifadeci i = new Istifadeci();
            i.ID = Convert.ToInt32(ce.lblUserID.Text);
            lblUserID.Text = i.ID.ToString();
            dtgIncome.DataSource = qORM.Select(i);
            dtgIncome.Columns["ID"].Visible = false;
            dtgIncome.Columns["Məbləğ"].DefaultCellStyle.Format = "F";
            if (dtgIncome != null)
            {
                dtgIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgIncome.Columns[dtgIncome.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblIncomeCount.Text = dtgIncome.RowCount.ToString();
            if (qORM.SelectSum(i).Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblIncomeSum.Text = dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.SelectSum(i).Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblIncomeSum.Text = "0.00";
            }
            IncomeDateValue();
        }
        public void IncomeDateValue()
        {
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            if ((qORM.IncomeSum(h, "Daily").Rows[0]["Günlük Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeDaily.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.IncomeSum(h, "Daily").Rows[0]["Günlük Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeDaily.Text = "0.00";
            }
            if ((qORM.IncomeSum(h, "Weekly").Rows[0]["Son 1 Həftəlik Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeWeekly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.IncomeSum(h, "Weekly").Rows[0]["Son 1 Həftəlik Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeWeekly.Text = "0.00";
            }
            if ((qORM.IncomeSum(h, "Monthly").Rows[0]["Son 1 Aylıq Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeMonthly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.IncomeSum(h, "Monthly").Rows[0]["Son 1 Aylıq Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeMonthly.Text = "0.00";
            }
            if ((qORM.IncomeSum(h, "Yearly").Rows[0]["Son 1 İllik Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeYearly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.IncomeSum(h, "Yearly").Rows[0]["Son 1 İllik Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeYearly.Text = "0.00";
            }

        }
        public void dtgIncomeSearch()
        {
            Istifadeci i = new Istifadeci();
            Qazanclar q = new Qazanclar();
            QazancKateqoriya qk = new QazancKateqoriya();
            Hesablar h = new Hesablar();
            i.ID = Convert.ToInt32(ce.lblUserID.Text);
            lblUserID.Text = i.ID.ToString();
            if (mstBoxFromDateIncome.Text == "  /  /")
            {
                qORM.qazancTarixStart = null;
            }
            else
            {
                qORM.qazancTarixStart = Convert.ToDateTime(mstBoxFromDateIncome.Text);
            }
            if (mstBoxTillDateIncome.Text == "  /  /")
            {
                qORM.qazancTarixEnd = null;
            }
            else
            {
                qORM.qazancTarixEnd = Convert.ToDateTime(mstBoxTillDateIncome.Text);
            }
            qk.qazancKateqoriyaAdi = cmbIncomeCategorySearch.GetItemText(cmbIncomeCategorySearch.SelectedItem); /*Convert.ToInt32(cmbIncomeCategorySearch.SelectedValue);*/
            h.hesabAdi = cmbAccountSearchIncome.GetItemText(cmbAccountSearchIncome.SelectedItem); /*Convert.ToInt32(cmbAccountSearchIncome.SelectedValue);*/
            dtgIncome.DataSource = qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Search");
            dtgIncome.Columns["ID"].Visible = false;
            dtgIncome.Columns["Məbləğ"].DefaultCellStyle.Format = "F";
            if (dtgIncome != null)
            {
                dtgIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgIncome.Columns[dtgIncome.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            lblIncomeCount.Text = dtgIncome.RowCount.ToString();
            if (qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search").Rows[0]["Toplam Məbləğ"].ToString() != "")
            {
                lblIncomeSum.Text = dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search").Rows[0]["Toplam Məbləğ"]);
            }
            else
            {
                lblIncomeSum.Text = "0.00";
            }
            /////////////////////
            if ((qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Daily").Rows[0]["Günlük Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeDaily.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Daily").Rows[0]["Günlük Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeDaily.Text = "0.00";
            }
            if ((qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Weekly").Rows[0]["Son 1 Həftəlik Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeWeekly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Weekly").Rows[0]["Son 1 Həftəlik Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeWeekly.Text = "0.00";
            }
            if ((qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Monthly").Rows[0]["Son 1 Aylıq Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeMonthly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Monthly").Rows[0]["Son 1 Aylıq Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeMonthly.Text = "0.00";
            }
            if ((qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Yearly").Rows[0]["Son 1 İllik Qazanc Məbləği"]).ToString() != "")
            {
                lblIncomeYearly.Text = (dtgIncome.Rows[0].Cells["Pul Vahidi"].Value.ToString() + string.Format("{0:F}", qORM.All_Search(i, q, qk, h, "prc_Qazanclar_Sum_Search_Yearly").Rows[0]["Son 1 İllik Qazanc Məbləği"]));
            }
            else
            {
                lblIncomeYearly.Text = "0.00";
            }
        }
       
        public void ExpenseCategorySearch()
        {
            IstifadeciXercKateqoriya ixk = new IstifadeciXercKateqoriya();
            ixk.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            cmbExpenseCategorySearch.DataSource = ixkORM.Select(ixk);
            cmbExpenseCategorySearch.DisplayMember = "Xərc Kateqoriyaları";
            cmbExpenseCategorySearch.ValueMember = "ID";
        }
        public void IncomeCategorySearch()
        {
            IstifadeciQazancKateqoriya iqk = new IstifadeciQazancKateqoriya();
            iqk.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            cmbIncomeCategorySearch.DataSource = iqkORM.Select(iqk);
            cmbIncomeCategorySearch.DisplayMember = "Qazanc Kateqoriyaları";
            cmbIncomeCategorySearch.ValueMember = "ID";
        }
        public void AccountSearch()
        {
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(ce.lblUserID.Text);
            cmbAccountSearch.DataSource = hORM.Select(h, "prc_HesablarCombobox_Select");
            cmbAccountSearch.DisplayMember = "Hesab Adı";
            cmbAccountSearch.ValueMember = "ID";
            cmbAccountSearchIncome.DataSource = hORM.Select(h, "prc_HesablarCombobox_Select");
            cmbAccountSearchIncome.DisplayMember = "Hesab Adı";
            cmbAccountSearchIncome.ValueMember = "ID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgExpensesRefresh();
            dtgIncomeRefresh();
            dtgAccountRefresh();
            ExpenseCategorySearch();
            IncomeCategorySearch();
            AccountSearch();
            mstBoxFromDate.Mask = "00/00/0000";
            mstBoxTillDate.Mask = "00/00/0000";
            mstBoxFromDateIncome.Mask = "00/00/0000";
            mstBoxTillDateIncome.Mask = "00/00/0000";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories c = new Categories(this);
            c.ShowDialog();
        }

        private void btnInsertCateg_Click(object sender, EventArgs e)
        {
            ExpensesCardInsert ec = new ExpensesCardInsert(this);
            ec.ShowDialog();
        }

        private void btnUpdateCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenses.RowCount > 0)
            {
                ExpensesCardUpdate ecu = new ExpensesCardUpdate(this);
                ecu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }
        }

        private void btnDeleteCateg_Click(object sender, EventArgs e)
        {
            if (dtgExpenses.RowCount > 0)
            {
                ExpensesCardDelete ecd = new ExpensesCardDelete(this);
                ecd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }
        }

        private void btnInsertIncome_Click(object sender, EventArgs e)
        {
            IncomeCardInsert ici = new IncomeCardInsert(this);
            ici.ShowDialog();
        }

        private void btnUpdateIncome_Click(object sender, EventArgs e)
        {
            if (dtgIncome.RowCount > 0)
            {
                IncomeCardUpdate icu = new IncomeCardUpdate(this);
                icu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (dtgIncome.RowCount > 0)
            {
                IncomeCardDelete icd = new IncomeCardDelete(this);
                icd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dtPickerTillDate_ValueChanged(object sender, EventArgs e)
        {
            mstBoxTillDate.Mask = "";
            mstBoxTillDate.Text = dtPickerTillDate.Value.ToShortDateString();
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void cmbExpenseCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void cBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
            else
            {
                dtgExpensesRefresh();
                cBoxAllAccount.Checked = false;
                cBoxAllExpenseCategory.Checked = false;
            }
        }

        private void cBoxAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAllAccount.Checked)
            {
                cmbAccountSearch.DataSource = null;

            }
            else
            {
                AccountSearch();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAllExpenseCategory.Checked)
            {
                cmbExpenseCategorySearch.DataSource = null;
                // cmbExpenseCategorySearch.SelectedIndex = -1;        
            }
            else
            {
                ExpenseCategorySearch();
            }

        }

        private void cmbAccountSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void cmbExpenseSubCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtPickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            mstBoxFromDate.Mask = "";
            mstBoxFromDate.Text = dtPickerFromDate.Value.ToShortDateString();
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void cmbExpenseCategorySearch_Enter(object sender, EventArgs e)
        {
            cBoxAllExpenseCategory.Checked = false;
        }

        private void cmbAccountSearch_Enter(object sender, EventArgs e)
        {
            cBoxAllAccount.Checked = false;
        }

        private void btnFromDateClear_Click(object sender, EventArgs e)
        {
            dtPickerFromDate.Value = DateTime.Now;
            mstBoxFromDate.Mask = "00/00/0000";
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void btnTillDateClear_Click(object sender, EventArgs e)
        {
            dtPickerTillDate.Value = DateTime.Now;
            mstBoxTillDate.Mask = "00/00/0000";
            if (cBoxFilter.Checked)
            {
                dtgExpensesSearch();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AddAccount aa = new AddAccount(this);
            aa.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgAccount.SelectedRows.Count > 0)
            {
                UpdateAccount ua = new UpdateAccount(this);
                ua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgAccount.SelectedRows.Count > 0)
            {
                DeleteAccount da = new DeleteAccount(this);
                da.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili məlumat mövcud deyil");
            }
        }

        private void cBoxIncomeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
            else
            {
                dtgIncomeRefresh();
                cBoxAllAccountIncome.Checked = false;
                cBoxAllIncomeCategory.Checked = false;
            }
        }

        private void dtPickerFromDateIncome_ValueChanged(object sender, EventArgs e)
        {
            mstBoxFromDateIncome.Mask = "";
            mstBoxFromDateIncome.Text = dtPickerFromDateIncome.Value.ToShortDateString();
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void dtPickerTillDateIncome_ValueChanged(object sender, EventArgs e)
        {
            mstBoxTillDateIncome.Mask = "";
            mstBoxTillDateIncome.Text = dtPickerTillDateIncome.Value.ToShortDateString();
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void btnFromDateClearIncome_Click(object sender, EventArgs e)
        {
            dtPickerFromDateIncome.Value = DateTime.Now;
            mstBoxFromDateIncome.Mask = "00/00/0000";
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void btnTillDateClearIncome_Click(object sender, EventArgs e)
        {
            dtPickerTillDateIncome.Value = DateTime.Now;
            mstBoxTillDateIncome.Mask = "00/00/0000";
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void cmbAccountSearchIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void cmbIncomeCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxIncomeFilter.Checked)
            {
                dtgIncomeSearch();
            }
        }

        private void cBoxAllAccountIncome_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAllAccountIncome.Checked)
            {
                cmbAccountSearchIncome.DataSource = null;
                // cmbAccountSearch.SelectedIndex = -1;

            }
            else
            {
                AccountSearch();
            }
        }

        private void cBoxAllIncomeCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxAllIncomeCategory.Checked)
            {
                cmbIncomeCategorySearch.DataSource = null;
                // cmbExpenseCategorySearch.SelectedIndex = -1;        
            }
            else
            {
                IncomeCategorySearch();
            }
        }

        private void cmbAccountSearchIncome_Enter(object sender, EventArgs e)
        {
            cBoxAllAccountIncome.Checked = false;
        }

        private void cmbIncomeCategorySearch_Enter(object sender, EventArgs e)
        {
            cBoxAllIncomeCategory.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintSelection ps = new PrintSelection(this);
            ps.ShowDialog();
        }
    }
}
