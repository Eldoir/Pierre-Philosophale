using System;
using System.Linq;
using System.Collections.Generic;
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

                    SaveJSONFile("Buildings", json);

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

                    SaveJSONFile("Sorts", json);

                    Cursor = Cursors.Default;

                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void generateElementsJSON_Click(object sender, EventArgs e)
        {
            string[] elements = this.elements.Text.Split('\n');
            for (int i = 0; i < elements.Length; i++) elements[i] = CleanString(elements[i]);

            FileData fileData = new FileData();

            foreach(string element in elements)
            {
                fileData.AddCard(new Card(title: element, count: (int)nbCardsPerElement.Value));
            }

            string json = JsonConvert.SerializeObject(fileData.cards, Formatting.Indented);

            SaveJSONFile("Éléments", json);
        }

        private void generateCombinaisonsJSON_Click(object sender, EventArgs e)
        {
            string[] elements = this.elements.Text.Split('\n');
            for (int i = 0; i < elements.Length; i++) elements[i] = CleanString(elements[i]);

            FileData fileData = new FileData();

            for (int i = 1; i <= (int)lvlMaxCombis.Value; i++)
            {
                string[] combis = GetCombis(elements, i);

                foreach (string combi in combis)
                {
                    fileData.AddCard(new Card(title: "Combinaison", alignment: combi, count: (int)nbCardsPerCombinaison.Value));
                }
            }

            string json = JsonConvert.SerializeObject(fileData.cards, Formatting.Indented);

            SaveJSONFile("Combinaisons", json);
        }

        private string CleanString(string strIn)
        {
            // Replace invalid characters with empty strings.
            return System.Text.RegularExpressions.Regex.Replace(strIn, @"[^\w\.@-]", "");
        }

        private string[] GetCombis(string[] elements, int nb)
        {
            IEnumerable<IEnumerable<string>> combis = GetKCombs(elements, nb);

            List<string> ret = new List<string>();

            foreach (var stringArr in combis)
            {
                string combi = "";
                foreach(var str in stringArr)
                {
                    combi += str + ", ";
                }
                combi = combi.Substring(0, combi.Length - 2); // Remove last ", "
                ret.Add(combi);
            }

            return ret.ToArray();
        }

        private IEnumerable<IEnumerable<T>> GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return  GetKCombs(list, length - 1)
                    .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        private void SaveJSONFile(string fileName, string json)
        {
            MessageBox.Show("Choisissez l'emplacement où sauvegarder le .json.");

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    fileName += ".json";
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
        }
    }
}