using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    class DocumentAnalyzerUtility
    {
        public static string ConvertVariableData(string text)
        {
            //Remove variable data so that paragraphs will still be found if they have
            //different dates, dollar amounts, etc.

            string result = text;

            //the last one is ment to match month names but the implementation would 
            //need to be changed since it matches to many additional things.
            result = result.Replace(((char)13).ToString(), "");
            string[] findText = { "[0-9]{1,}", "\\.", "\\*", "\\$", "\\!",
                "[JFMASOND][a-z]{1,10}", "\\^" };

            foreach (string find in findText)
            {
                Regex regex = new Regex(find);
                result = regex.Replace(result, find); 
                //if the find pattern is found it is replaced with the literal pattern.
            }

            return result;
        }

        public static int[] FindBoldWords(Paragraph paraObj)
        {
            int[] result = { 0 };

            HashSet<int> boldWords = new HashSet<int>();

            //loop over the words if it's bold add it's index to the set.
            for (int i = 1; i <= paraObj.Range.Words.Count; i++)
            {
                if (paraObj.Range.Words[i].Font.Bold == -1)
                {
                    boldWords.Add(i);
                }
            }
            if (boldWords.Count > 0)
            {
                result = boldWords.ToArray();
            }

            return result;
        }

        public static void ExportBasFile(string filePath)
        {
            //exports .bas files which can be imported into Word to be run as macros.
            int fileNum = 0;
            int curNumOfBlocks = 0;
            int MAX_NUM_OF_BLOCKS = 75;
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + 
                "\\Formatting_" + fileNum.ToString("D3") + ".bas");

            file.WriteLine("Attribute VB_Name = \"Formatting_" + fileNum.ToString("D3") + "\"");
            file.WriteLine("Sub Formatting_" + fileNum.ToString("D3") + "()");
            file.WriteLine("");
            file.WriteLine("Dim regex As RegExp");
            file.WriteLine("Set regex = New RegExp");
            file.WriteLine("Dim matchColl As MatchCollection");
            file.WriteLine("Dim oMatch As Match");
            file.WriteLine("Dim myRng As Range");
            file.WriteLine("");
            file.WriteLine("regex.Global = True");
            file.WriteLine("regex.IgnoreCase = False");
            file.WriteLine("regex.MultiLine = True");

            foreach (ParagraphInfo paraInfoObj in ParagraphList.listOfParagraphs)
            {
                file.WriteLine("");
                file.WriteLine("regex.Pattern = Chr(13) & \"" + paraInfoObj.getText() + "\" & Chr(13)");
                file.WriteLine("Set matchColl = regex.Execute(ThisDocument.Range.Text) ");
                file.WriteLine("For Each oMatch In matchColl");
                file.WriteLine("    Set myRng = ThisDocument.Range(oMatch.FirstIndex + 1, oMatch.FirstIndex + oMatch.Length)");
                file.WriteLine("    boldWords = Array(" + 
                    String.Join(", ", paraInfoObj.getBoldWords()) + ")");
                file.WriteLine("    For Each wordNum In boldWords");
                file.WriteLine("        myRng.Words(wordNum).Bold = True");
                file.WriteLine("    Next");

                if (paraInfoObj.getBullet() != "0")
                {
                    if (paraInfoObj.getBullet() == "61623")
                    {
                        file.WriteLine("    With ListGalleries(wdBulletGallery).ListTemplates(1).ListLevels(1)");
                        file.WriteLine("        .NumberFormat = ChrW(61623)");
                        file.WriteLine("        .NumberStyle = wdListNumberStyleBullet");
                        file.WriteLine("        .Font.Name = \"Symbol\"");
                    }
                    else
                    {
                        file.WriteLine("    With ListGalleries(wdNumberGallery).ListTemplates(1).ListLevels(1)");
                        file.WriteLine("        .NumberFormat = " + paraInfoObj.getBullet() + "\"");
                        file.WriteLine("        .NumberStyle = wdListNumberStyleArabic");
                    }
                    file.WriteLine("    End With");
                    file.WriteLine("    myRng.ListFormat.ApplyListTemplateWithLevel ListTemplate:=ListGalleries(wdBulletGallery).ListTemplates(1)");
                }

                file.WriteLine("    With myRng.Paragraphs(1)");
                file.WriteLine("        .Range.Font.Size = " + paraInfoObj.getFontSize().ToString());
                file.WriteLine("        .Alignment = " + paraInfoObj.getFontSize().ToString());
                file.WriteLine("        .FirstLineIndent = " + paraInfoObj.getIndent()[0].ToString());
                file.WriteLine("        .LeftIndent = " + paraInfoObj.getIndent()[1].ToString());
                file.WriteLine("        .SpaceBefore = " + paraInfoObj.getSpacing()[0].ToString());
                file.WriteLine("        .SpaceAfter = " + paraInfoObj.getSpacing()[1].ToString());
                file.WriteLine("        .KeepWithNext = " + paraInfoObj.getKeepWithNext().ToString());
                file.WriteLine("        .KeepTogether = " + paraInfoObj.getKeepTogether().ToString());
                file.WriteLine("    End With");
                file.WriteLine("Next");

                curNumOfBlocks++;
                if (fileNum > MAX_NUM_OF_BLOCKS)
                {
                    file.WriteLine("");
                    file.WriteLine("End Sub");

                    file.Close();

                    file = new System.IO.StreamWriter(filePath + "\\Formatting_" + fileNum.ToString("D3"));
                    fileNum++;
                    curNumOfBlocks = 0;

                    file.WriteLine("Attribute VB_Name = \"Formatting_" + fileNum.ToString("D3") + ".bas");
                    file.WriteLine("Sub Formatting_" + fileNum.ToString("D3"));
                    file.WriteLine("");
                    file.WriteLine("Dim regex As RegExp");
                    file.WriteLine("Set regex = New RegExp");
                    file.WriteLine("Dim matchColl As MatchCollection");
                    file.WriteLine("Dim oMatch As Match");
                    file.WriteLine("Dim myRng As Range");
                    file.WriteLine("");
                    file.WriteLine("regex.Global = True");
                    file.WriteLine("regex.IgnoreCase = False");
                    file.WriteLine("regex.MultiLine = True");
                }
            }
            file.WriteLine("");
            file.WriteLine("End Sub");

            file.Close();
        }
    }
}
