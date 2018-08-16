using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using static WindowsFormsApp1.DocumentAnalyzerUtility;
using static WindowsFormsApp1.ParagraphList;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listOfParagraphs = new HashSet<ParagraphInfo>();
        }

        private void btnAnalyzeDocs_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting to Analyze";
            lblStatus.Visible = true;
            int numOfDocs = 1;
            string[] fileList = System.IO.Directory.GetFiles(txtDocDir.Text);
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            foreach (string filepath in fileList)
            {
                if (filepath.IndexOf(".doc") > 0)
                {
                    lblStatus.Text = "Analyzing Doc " + numOfDocs;

                    Document wordDoc = wordApp.Documents.Open(filepath);
                    foreach (Microsoft.Office.Interop.Word.Paragraph paraObj in wordDoc.Paragraphs)
                    {
                        string text = ConvertVariableData(paraObj.Range.Text);
                        
                        int fontSize = (int) paraObj.Range.Font.Size;

                        int alignment = (int) paraObj.Alignment;

                        int[] boldWords = FindBoldWords(paraObj);

                        double[] indent = { paraObj.FirstLineIndent, paraObj.LeftIndent};

                        double[] spacing = { paraObj.SpaceBefore, paraObj.SpaceAfter };

                        int keepWithNext = paraObj.KeepWithNext;

                        int keepTogether = paraObj.KeepTogether;

                        string bullet = paraObj.Range.ListFormat.ListString;

                        listOfParagraphs.Add(new ParagraphInfo(text, fontSize, alignment, boldWords, indent, spacing, keepWithNext, keepTogether, bullet));
                        }
                    numOfDocs++;
                    wordDoc.Close();

                }
            }
            lblStatus.Text = listOfParagraphs.Count + " paragraphs analyzed";
            wordApp.Quit();
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            LoadList(txtOutputDir.Text + "\\DocumentAnalyzer.txt");
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            WriteList(txtOutputDir.Text + "\\DocumentAnalyzer.txt");
        }

        private void btnSelectDocDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtDocDir.Text = fbd.SelectedPath;
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtOutputDir.Text = fbd.SelectedPath;
        }

        private void btnExportMacro_Click(object sender, EventArgs e)
        {
            ExportBasFile(txtOutputDir.Text);
        }
    }
}
