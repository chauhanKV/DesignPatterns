using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class FontStyle
    {
        private String fontFamily;
        private int fontSize;
        private bool isBold;

        public FontStyle(String fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
        }

        public string FontFamily { get => fontFamily; set => fontFamily = value; }
        public int FontSize { get => fontSize; set => fontSize = value; }
        public bool IsBold { get => isBold; set => isBold = value; }
    }
}
