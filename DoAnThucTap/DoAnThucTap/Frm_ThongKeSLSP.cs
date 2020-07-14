using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace DoAnThucTap
{
    public partial class Frm_ThongKeSLSP : Form
    {
        private Voids exit;
        public Frm_ThongKeSLSP()
        {
            InitializeComponent();
        }
        
        public Frm_ThongKeSLSP(Voids vd)
        {
            InitializeComponent();
            exit = vd;
        }
        XuLyDuLieuDataContext kn = new XuLyDuLieuDataContext();

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            exit();
            this.Close();
        }

        private void Frm_ThongKeSLSP_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kn.select_ThongKeSLSP();
        }

        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Kê Số Lượng Sản Phẩm Trong Kho";
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã Sản Phẩm";
            worksheet.Cells[3, 3] = " Tên Sản Phẩm";
            worksheet.Cells[3, 4] = " Số Lượng";
            worksheet.Cells[3, 5] = " Loại Sản Phẩm";
            

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            int dem = dataGridView1.RowCount;

            // Định dạng trang
            //worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            //worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            //worksheet.PageSetup.LeftMargin = 0;
            //worksheet.PageSetup.RightMargin = 0;
            //worksheet.PageSetup.TopMargin = 0;
            //worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 45;
            worksheet.Range["C1"].ColumnWidth = 49;
            worksheet.Range["D1"].ColumnWidth = 33;
            worksheet.Range["E1"].ColumnWidth = 31;
            //worksheet.Range["F1"].ColumnWidth = 52;
            //worksheet.Range["G1"].ColumnWidth = 23;
            //worksheet.Range["H1"].ColumnWidth = 22;

            // Định dạng font chữ
            worksheet.Range["A1", "E100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "E100"].Font.Size = 16;
            worksheet.Range["A1", "E1"].MergeCells = true;
            worksheet.Range["A1", "E1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
            worksheet.Range["A3", "E3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "E" + (dem + 3)].Borders.LineStyle = 1;


            //Định dạng dòng text
            worksheet.Range["A1", "E1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "E3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "E" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["B4", "E" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["C4", "E" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "E" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["E4", "E" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["F4", "E" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["G4", "E" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["H4", "E" + (dem + 4)].HorizontalAlignment = 3;
        }
    }
}
