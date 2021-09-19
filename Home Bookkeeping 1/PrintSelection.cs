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
    public partial class PrintSelection : Form
    {
        public PrintSelection()
        {
            InitializeComponent();
        }
        private readonly Form1 frm1;
        public PrintSelection(Form1 frm_ps)
        {
            InitializeComponent();
            frm1 = frm_ps;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Hesablar h = new Hesablar();
            for (int i = 0; i < dtgPrintSelection.RowCount; i++)
            {
                h.ID = Convert.ToInt32(dtgPrintSelection.Rows[i].Cells["ID"].Value);
                h.hesabAdi = dtgPrintSelection.Rows[i].Cells["Hesab Adı"].Value.ToString();
                h.hesabMebleg = Convert.ToDecimal(dtgPrintSelection.Rows[i].Cells["Hesab Məbləği"].Value);
                h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
                h.hesabTarix = Convert.ToDateTime(dtgPrintSelection.Rows[i].Cells["Tarix"].Value);
                h.qeyd = dtgPrintSelection.Rows[i].Cells["Qeyd"].Value.ToString();
                h.show =Convert.ToBoolean(dtgPrintSelection.Rows[i].Cells["Seçim"].Value);
                bool result = hORM.Update(h);
            }
            dtgPrintSelection.DataSource = hORM.Update(h);
            Print p = new Print(this);
            this.Hide();
            p.ShowDialog();
           
        }
        HesablarORM hORM = new HesablarORM();
        public int istifadeciID { get; set; }
        public void dtgPrintSelectionRefresh()
        {
            Hesablar h = new Hesablar();
            h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
            istifadeciID = h.istifadeciid;
            dtgPrintSelection.DataSource = hORM.Select(h, "prc_Hesablar_Select");
            dtgPrintSelection.Columns["ID"].Visible = false;
            dtgPrintSelection.Columns["Tarix"].Visible = false;
            dtgPrintSelection.Columns["Xərc Məbləği"].DefaultCellStyle.Format = "F";
            dtgPrintSelection.Columns["Qazanc Məbləği"].DefaultCellStyle.Format = "F";
            dtgPrintSelection.Columns["Hesab Məbləği"].DefaultCellStyle.Format = "F";
            dtgPrintSelection.Columns["Toplam Məbləğ"].DefaultCellStyle.Format = "F";
            if (dtgPrintSelection != null)
            {
                dtgPrintSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtgPrintSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgPrintSelection.Columns[dtgPrintSelection.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            dtgPrintSelection.Columns["Seçim"].ReadOnly = false;
            dtgPrintSelection.Columns["Sıra"].ReadOnly = true;
            dtgPrintSelection.Columns["Hesab Adı"].ReadOnly = true;
            dtgPrintSelection.Columns["Xərc Məbləği"].ReadOnly = true;
            dtgPrintSelection.Columns["Qazanc Məbləği"].ReadOnly = true;
            dtgPrintSelection.Columns["Hesab Məbləği"].ReadOnly = true;
            dtgPrintSelection.Columns["Toplam Məbləğ"].ReadOnly = true;
            dtgPrintSelection.Columns["Qeyd"].ReadOnly = true;
        }
        private void PrintSelection_Load(object sender, EventArgs e)
        {
            dtgPrintSelectionRefresh();
        }

        private void dtgPrintSelection_DoubleClick(object sender, EventArgs e)
        {
            
            if (!Convert.ToBoolean(dtgPrintSelection.CurrentRow.Cells["Seçim"].Value))
            {
                dtgPrintSelection.CurrentRow.Cells["Seçim"].Value = true;
            }
            else
            {
                dtgPrintSelection.CurrentRow.Cells["Seçim"].Value = false;
            }
         
        }
        public void dtgPrintSelectionUpdate()
        {
            Hesablar h = new Hesablar();
            for (int i = 0; i < dtgPrintSelection.RowCount; i++)
            {
                h.ID = Convert.ToInt32(dtgPrintSelection.Rows[i].Cells["ID"].Value);
                h.hesabAdi = dtgPrintSelection.Rows[i].Cells["Hesab Adı"].Value.ToString();
                h.hesabMebleg = Convert.ToDecimal(dtgPrintSelection.Rows[i].Cells["Hesab Məbləği"].Value);
                h.istifadeciid = Convert.ToInt32(frm1.lblUserID.Text);
                h.hesabTarix = Convert.ToDateTime(dtgPrintSelection.Rows[i].Cells["Tarix"].Value);
                h.qeyd = dtgPrintSelection.Rows[i].Cells["Qeyd"].Value.ToString();
                h.show = false;
                bool result = hORM.Update(h);

            }
            dtgPrintSelectionRefresh();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtgPrintSelectionUpdate();
            this.Close();
        }

        private void PrintSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtgPrintSelectionUpdate();
        }
    }
}
