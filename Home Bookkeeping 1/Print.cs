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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        private readonly PrintSelection ps;
        public Print(PrintSelection ps_p)
        {
            InitializeComponent();
            ps = ps_p;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        IstifadeciORM iORM = new IstifadeciORM();
        Font Basliq = new Font("Verdena", 13, FontStyle.Bold);
        Font altBasliq = new Font("Verdena", 10, FontStyle.Bold);
        Font mezmun = new Font("Verdena", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
        int countBool = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Istifadeci ist = new Istifadeci();
            ist.ID = ps.istifadeciID;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            ps.dtgPrintSelectionRefresh();
            e.Graphics.DrawString("İstifadəçi Adı: " + iORM.SelectAccountName(ist).Rows[0]["Istifadeci Adi"].ToString(), Basliq, sb, 35, 25, sf);
            e.Graphics.DrawString(DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString() + ", " + DateTime.Now.ToString("HH:mm"), Basliq, sb, 625, 25, sf);
            e.Graphics.DrawString("_________________________________________________________________________", Basliq, sb, 35, 30, sf);
            if (ps.dtgPrintSelection.RowCount > 0)
            {
                e.Graphics.DrawString(ps.dtgPrintSelection.Columns[3].HeaderText, altBasliq, sb, 60, 100, sf);
                e.Graphics.DrawString("_______________", altBasliq, sb, 35, 105, sf);
                e.Graphics.DrawString(ps.dtgPrintSelection.Columns[5].HeaderText, altBasliq, sb, 206, 100, sf);
                e.Graphics.DrawString("_______________", altBasliq, sb, 196, 105, sf);
                e.Graphics.DrawString(ps.dtgPrintSelection.Columns[6].HeaderText, altBasliq, sb, 372, 100, sf);
                e.Graphics.DrawString("_______________", altBasliq, sb, 355, 105, sf);
                e.Graphics.DrawString(ps.dtgPrintSelection.Columns[7].HeaderText, altBasliq, sb, 528, 100, sf);
                e.Graphics.DrawString("_______________", altBasliq, sb, 520, 105, sf);
                e.Graphics.DrawString(ps.dtgPrintSelection.Columns[8].HeaderText, altBasliq, sb, 688, 100, sf);
                e.Graphics.DrawString("_______________", altBasliq, sb, 680, 105, sf);
            }
            int j = 0;
            double account = 0.00, expense = 0.00, income = 0.00, total = 0.00;
            for (int i = 0; i < ps.dtgPrintSelection.RowCount; i++)
            {
                if (Convert.ToBoolean(ps.dtgPrintSelection.Rows[i].Cells["Seçim"].Value) == true)
                {

                    e.Graphics.DrawString(ps.dtgPrintSelection.Rows[i].Cells["Hesab Adı"].Value.ToString(), mezmun, sb, 35, 125 + j * 25, sf);
                    e.Graphics.DrawString(String.Format("{0:F}", ps.dtgPrintSelection.Rows[i].Cells["Hesab Məbləği"].Value).ToString(), mezmun, sb, 196, 125 + j * 25, sf);
                    e.Graphics.DrawString(String.Format("{0:F}", ps.dtgPrintSelection.Rows[i].Cells["Xərc Məbləği"].Value).ToString(), mezmun, sb, 355, 125 + j * 25, sf);
                    e.Graphics.DrawString(String.Format("{0:F}", ps.dtgPrintSelection.Rows[i].Cells["Qazanc Məbləği"].Value).ToString(), mezmun, sb, 520, 125 + j * 25, sf);
                    e.Graphics.DrawString(String.Format("{0:F}", ps.dtgPrintSelection.Rows[i].Cells["Toplam Məbləğ"].Value).ToString(), mezmun, sb, 680, 125 + j * 25, sf);
                    j++;
                    account += Convert.ToDouble(ps.dtgPrintSelection.Rows[i].Cells["Hesab Məbləği"].Value);
                    expense += Convert.ToDouble(ps.dtgPrintSelection.Rows[i].Cells["Xərc Məbləği"].Value);
                    income += Convert.ToDouble(ps.dtgPrintSelection.Rows[i].Cells["Qazanc Məbləği"].Value);
                    total += Convert.ToDouble(ps.dtgPrintSelection.Rows[i].Cells["Toplam Məbləğ"].Value);
                }

            }
            e.Graphics.DrawString("______________________________________________________________________________________________", altBasliq, sb, 35, 110 + j * 25, sf);
            e.Graphics.DrawString("Toplam Məbləğ", mezmun, sb, 35, 130 + j * 25, sf);
            e.Graphics.DrawString(String.Format("{0:F}", account).ToString(), mezmun, sb, 196, 130 + j * 25, sf);
            e.Graphics.DrawString(String.Format("{0:F}", expense).ToString(), mezmun, sb, 355, 130 + j * 25, sf);
            e.Graphics.DrawString(String.Format("{0:F}", income).ToString(), mezmun, sb, 520, 130 + j * 25, sf);
            e.Graphics.DrawString(String.Format("{0:F}", total).ToString(), mezmun, sb, 680, 130 + j * 25, sf);
        }

        private void Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            ps.Visible = true;
            ps.dtgPrintSelectionRefresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            countBool = 0;
            ps.dtgPrintSelectionRefresh();
            for (int i = 0; i < ps.dtgPrintSelection.RowCount; i++)
            {
                if (Convert.ToBoolean(ps.dtgPrintSelection.Rows[i].Cells["Seçim"].Value) == true)
                {
                    countBool++;
                }
            }
            if (countBool > 0)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Çap etmək üçün seçili məlumat tapılmadı. Məlumatlarınızı bir daha gözdən keçirin");
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            countBool = 0;
            ps.dtgPrintSelectionRefresh();
            for (int i = 0; i < ps.dtgPrintSelection.RowCount; i++)
            {
                if (Convert.ToBoolean(ps.dtgPrintSelection.Rows[i].Cells["Seçim"].Value) == true)
                {
                    countBool++;
                }
            }
            if (countBool > 0)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Çap etmək üçün seçili məlumat tapılmadı. Məlumatlarınızı bir daha gözdən keçirin");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ps.Visible = true;
            ps.dtgPrintSelectionRefresh();
            this.Hide();
        }
    }
}
