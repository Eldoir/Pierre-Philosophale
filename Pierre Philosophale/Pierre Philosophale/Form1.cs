using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pierre_Philosophale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (openExcelFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    FileData fileData = new FileData();

                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    Excel.Workbook workbook = excelApp.Workbooks.Open(openExcelFile.FileName);
                    Excel.Worksheet firstSheet = workbook.Sheets[1];

                    int startNum = 2;
                    int endNum = firstSheet.UsedRange.Rows.Count;

                    for (int i = startNum; i <= endNum; i++)
                    {
                        string name = firstSheet.Range["A" + i].Text;
                        string cost = firstSheet.Range["B" + i].Text;
                        string points = firstSheet.Range["C" + i].Text;
                        string ex = firstSheet.Range["D" + i].Text;
                        string effect = firstSheet.Range["E" + i].Text;

                        fileData.AddCard(new Card(title: name + "(" + cost + " PS)", alignment: points + " pts", effects: effect, count: int.Parse(ex)));
                        //Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", name, cost, points, ex, effect));
                    }

                    string json = JsonConvert.SerializeObject(fileData, Formatting.Indented);

                    if (saveJSON.ShowDialog() == DialogResult.OK)
                    {
                        Stream myStream;
                        if ((myStream = saveJSON.OpenFile()) != null)
                        {
                            byte[] bytes = ASCIIEncoding.Default.GetBytes(json);
                            myStream.Write(bytes, 0, bytes.Length);
                            // Code to write the stream goes here.
                            myStream.Close();
                        }
                    }

                    Console.WriteLine(json);

                    Cursor = Cursors.Default;

                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private int GetLastFilledRow(Excel.Application excelApp, Excel.Worksheet sheet, string startColumn, string endColumn)
        {
            int lastFilledRow = sheet.UsedRange.Rows.Count - 1;

            for (int i = lastFilledRow; i >= 1; i--)
            {
                Excel.Range range = sheet.Range[$"{startColumn}{i}", $"{endColumn}{i}"];

                if (excelApp.WorksheetFunction.CountA(range) > 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
