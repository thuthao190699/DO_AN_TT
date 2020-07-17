using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }
        public Frm_Report(int ID, string filename)
        {
            InitializeComponent();
            GetFileInvoice(ID, filename);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetDuLieu.selectReport' table. You can move, or remove it, as needed.
            this.selectReportTableAdapter.Fill(this.DataSetDuLieu.selectReport, Frm_HDN.mahd);
            // TODO: This line of code loads data into the 'DataSetDuLieu.selectReportTongTien' table. You can move, or remove it, as needed.
            this.selectReportTongTienTableAdapter.Fill(this.DataSetDuLieu.selectReportTongTien, Frm_HDN.mahd);

            this.reportViewer1.RefreshReport();
        }
        public void GetFileInvoice(int id, string link)
        {
            this.selectReportTableAdapter.Fill(this.DataSetDuLieu.selectReport, id);
            // TODO: This line of code loads data into the 'DataSetDuLieu.selectReportTongTien' table. You can move, or remove it, as needed.
            this.selectReportTongTienTableAdapter.Fill(this.DataSetDuLieu.selectReportTongTien, id);

            this.reportViewer1.RefreshReport();
           

            byte[] temp = reportViewer1.LocalReport.Render("PDF");
            var fullpath = Path.Combine(link, id.ToString() + ".pdf");
            File.WriteAllBytes(fullpath, temp);

        }
    }
}
