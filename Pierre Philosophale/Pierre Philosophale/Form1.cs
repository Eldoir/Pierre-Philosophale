using System;
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

        private void generateBuildingsJSON_Click(object sender, EventArgs e)
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

                        fileData.AddCard(new Card(title: name + " (" + cost + " PS)", alignment: points + " pts", effects: effect, count: int.Parse(ex)));
                    }

                    string json = JsonConvert.SerializeObject(fileData.cards, Formatting.Indented);

                    MessageBox.Show("Choisissez l'emplacement où sauvegarder le .json.");

                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            string fileName = "Buildings.json";
                            string filePath = Path.Combine(fbd.SelectedPath, fileName);

                            if (File.Exists(filePath))
                            {
                                if (MessageBox.Show("La destination comprend déjà un fichier nommé \"" + fileName + "\". Remplacer ?", "Remplacer ou ignorer les fichiers", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                    return;
                                }
                            }

                            File.WriteAllText(filePath, json);

                            MessageBox.Show("Le fichier a été sauvegardé dans " + filePath);
                        }
                    }

                    Cursor = Cursors.Default;

                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void generateSortsJSON_Click(object sender, EventArgs e)
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

                    int startNum = 4;
                    int endNum = firstSheet.UsedRange.Rows.Count;

                    for (int i = startNum; i <= endNum; i++)
                    {
                        string name = "Sort";//firstSheet.Range["A" + i].Text; // temporary
                        string cost = firstSheet.Range["B" + i].Text;
                        string effect = firstSheet.Range["C" + i].Text;
                        string ex = firstSheet.Range["D" + i].Text;

                        fileData.AddCard(new Card(title: name + " (" + cost + " PS)", effects: effect, count: int.Parse(ex)));
                    }

                    string json = JsonConvert.SerializeObject(fileData.cards, Formatting.Indented);

                    MessageBox.Show("Choisissez l'emplacement où sauvegarder le .json.");

                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            string fileName = "Sorts.json";
                            string filePath = Path.Combine(fbd.SelectedPath, fileName);

                            if (File.Exists(filePath))
                            {
                                if (MessageBox.Show("La destination comprend déjà un fichier nommé \"" + fileName + "\". Remplacer ?", "Remplacer ou ignorer les fichiers", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                    return;
                                }
                            }

                            File.WriteAllText(filePath, json);

                            MessageBox.Show("Le fichier a été sauvegardé dans " + filePath);
                        }
                    }

                    Cursor = Cursors.Default;

                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}