using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class FontStyleFactory
    {
        private FontStyle fontStyle;
        public FontStyle getFontStyle()
        {
            fontStyle.FontFamily = "Times New Roman";
            fontStyle.FontSize = 12;
            fontStyle.IsBold = false;

            return fontStyle;
        }
    }
}
