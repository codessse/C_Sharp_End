using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Forms;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;

using Excel = Microsoft.Office.Interop.Excel;

namespace C_Sharp_End
{
    public partial class Form2 : Form
    {
        public Dictionary<string, object> SelectedName;
        private List<string> FieldName = new List<string> { "名字", "英文名字", "代號", "稀有度", "職業", "勢力出身地種族", "生命值", "攻擊力", "防禦力", "法術抗性", "標籤", "特性" };
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Text = SelectedName["名字"].ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<string> items = new List<string>() { };
            DataGridViewRowCollection rows = dataGridView1.Rows;
            DataGridViewColumnCollection columns = dataGridView1.Columns;


            foreach (string _name in FieldName)
            {
                rows.Add(new object[] { _name, SelectedName[_name].ToString() });
            }
        }



        private void 匯出PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPDF();
        }

        private void 匯出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application xls = null;
            try
            {
                xls = new Excel.Application();
                Excel.Workbook book = xls.Workbooks.Add();
                Excel.Worksheet Sheet = xls.ActiveSheet;
                Sheet.Name = SelectedName["名字"].ToString();

                for (int i = 0; i < FieldName.Count; i++)
                {
                    Sheet.Cells[i + 1, 1] = FieldName[i];
                    Sheet.Cells[i + 1, 2] = SelectedName[FieldName[i]];
                }

                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                save.FileName = SelectedName["名字"].ToString();
                save.Filter = "*.xlsx|*.xlsx";
                if (save.ShowDialog() != DialogResult.OK) return;
                book.SaveAs(save.FileName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                xls.Quit();
            }
        }


        private void 匯出CSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.FileName = SelectedName["名字"].ToString();
            save.Filter = "*.csv|*.csv";

            if (save.ShowDialog() != DialogResult.OK) return;

            string strFilePath = save.FileName;
            StringBuilder sbOutput = new StringBuilder();

            foreach (string _name in FieldName)
            {
                string tmp = String.Format("{0},{1}", _name, SelectedName[_name].ToString());
                sbOutput.AppendLine(tmp);
            }

            
            System.IO.File.WriteAllText(strFilePath, sbOutput.ToString());
            System.IO.File.AppendAllText(strFilePath, sbOutput.ToString());

        }

        void PrintPDF()
        {
            string src = "./test.pdf";
            string dst = @"./new_test.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.FileName = SelectedName["名字"].ToString();
            saveFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dst = saveFileDialog.FileName;
                manipulatePdf(src, dst);
            }
        }

        void manipulatePdf(String src, String dst)
        {
            PdfWriter writer = new PdfWriter(src);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.A4.Rotate());
            document.SetMargins(20, 20, 20, 20);
            PdfFont font = PdfFontFactory.CreateFont(@"c:/Windows/fonts/kaiu.ttf", PdfEncodings.IDENTITY_H);

            Table table = new Table(2, true);
            table.SetFont(font);
            foreach (string _name in FieldName)
            {
                table.AddCell(new Paragraph(_name));
                table.AddCell(new Paragraph(SelectedName[_name].ToString()));
            }

            document.Add(table);
            table.Complete();

            document.Close();


            PdfReader reader2 = new PdfReader(src);
            PdfWriter writer2 = new PdfWriter(dst);
            PdfDocument pdfDoc2 = new PdfDocument(reader2, writer2);
            Document document2 = new Document(pdfDoc2);

            draw_simple_page_num(pdfDoc2, document2);   
            document2.Close();
        }

        void draw_simple_page_num(PdfDocument pdfDoc, Document document)
        {
            int n = pdfDoc.GetNumberOfPages();
            for (int i = 1; i <= n; i++)
            {
                document.ShowTextAligned(new Paragraph(String.Format("page" + i + " of " + n)), 806, 595, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0);
            }
        }


    }
}
