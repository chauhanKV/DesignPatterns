using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private String content;
        private FontStyle fontStyle;

        public Cell(int row, int column, FontStyle fontStyle)
        {
            this.row = row;
            this.column = column;
            this.fontStyle = fontStyle;
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public void setFontStyle(FontStyle fontStyle)
        {
            this.fontStyle = fontStyle;
        }

        public FontStyle getFontStyle()
        {
            return this.fontStyle;
        }

        public void render()
        {
            Console.WriteLine("({0}, {1}): {2} [{3}]\n", row, column, content, fontStyle.FontFamily);
        }
    }

}
