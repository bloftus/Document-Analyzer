using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ParagraphList
    {
        //set is used since we don't need to record duplicate information if a paragraph
        //occurs more than once in the files we point to.
        public static HashSet<ParagraphInfo> listOfParagraphs;

        public static void LoadList(string filePath)
        {
            //Loads to the list from a text file
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] paraFormatting = line.Split('|');

                string text = paraFormatting[0];

                int fontSize = Convert.ToInt32(paraFormatting[1]);

                int alignment = Convert.ToInt32(paraFormatting[2]);

                string[] tempBoldWords = paraFormatting[3].Split(',');
                int[] boldWords = Array.ConvertAll(tempBoldWords, int.Parse);

                string[] tempIndent = paraFormatting[4].Split(',');
                double[] indent = Array.ConvertAll(tempIndent, double.Parse);

                string[] tempSpacing = paraFormatting[5].Split(',');
                double[] spacing = Array.ConvertAll(tempSpacing, double.Parse);

                int keepWithNext = Convert.ToInt32(paraFormatting[6]);

                int keepTogether = Convert.ToInt32(paraFormatting[7]);

                string bullet = paraFormatting[8];

                listOfParagraphs.Add(new ParagraphInfo(text, fontSize, alignment, boldWords, indent, spacing, keepWithNext, keepTogether, bullet));
            }
        }

        public static void WriteList(string filePath)
        {
            //Writes the list to a text file
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath);
            foreach (ParagraphInfo paragraghObj in listOfParagraphs)
            {
                file.WriteLine(paragraghObj.ToString());
            }
            file.Close();
        }
    }
}
