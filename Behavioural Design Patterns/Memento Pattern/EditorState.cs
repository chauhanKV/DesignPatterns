using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class EditorState
    {

        private readonly string content;
        private readonly string fontName;
        private readonly int fontSize;

        public EditorState(string content, string fontName, int fontSize)
        { 
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }

        public string Content => content;

        public string FontName => fontName;

        public int FontSize => fontSize;
    }
}
