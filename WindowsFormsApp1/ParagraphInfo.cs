using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class ParagraphInfo
    {
        private string text;
        private int fontSize;
        private int alignment;
        private int[] boldWords;
        private double[] indent;
        private double[] spacing;
        private int keepWithNext;
        private int keepTogether;
        private string bullet;

        public ParagraphInfo(string text, int fontSize, int alignment, int[] boldWords, double[] indent,
            double[] spacing, int keepWithNext, int keepTogether, string bullet)
        {
            this.text = text;

            this.fontSize = fontSize;

            this.alignment = alignment;

            this.boldWords = (int[]) boldWords.Clone();

            if (indent.Length == 2) //indent has only 2 values, first line and the whole paragraph.
            {
                this.indent = (double[])indent.Clone();
            } else
            {
                this.indent = new double[] { 0, 0};
            }

            if (spacing.Length == 2) //spacing has only 2 values, space before and space after.
            {
                this.spacing = (double[])spacing.Clone();
            }
            else
            {
                this.spacing = new double[] { 0, 0 };
            }

            this.keepWithNext = keepWithNext;

            this.keepTogether = keepTogether;

            this.bullet = bullet;
        }

        public string getText()
        {
            return this.text;
        }

        public int getFontSize()
        {
            return this.fontSize;
        }

        public int getAlignment()
        {
            return this.alignment;
        }
        public int[] getBoldWords()
        {
            return (int[]) this.boldWords.Clone();
        }

        public double[] getIndent()
        {
            return (double[]) this.indent.Clone();
        }

        public double[] getSpacing()
        {
            return (double[])this.spacing.Clone();
        }

        public int getKeepWithNext()
        {
            return this.keepWithNext;
        }

        public int getKeepTogether()
        {
            return this.keepTogether;
        }

        public string getBullet()
        {
            return this.bullet;
        }

        public override string ToString()
        {
            return text + "|" + fontSize.ToString() + "|" + alignment.ToString() + "|" + 
                String.Join(",", boldWords) + "|" + String.Join(",", indent) + "|" +
                String.Join(",", spacing) + "|" + keepWithNext.ToString() + "|" + 
                keepTogether.ToString() + "|" + bullet;
        }
    }

}
