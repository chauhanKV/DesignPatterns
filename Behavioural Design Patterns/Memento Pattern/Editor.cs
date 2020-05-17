using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Editor
    {
        private string content;
        private string fontName;
        private int fontSize;

        public EditorState createState()
        {
            return new EditorState(content, fontName, fontSize);
        }

        public void restore(EditorState state)
        {
            content = state.Content;
            fontName = state.FontName;
            fontSize = state.FontSize;
        }

        public void setContent(string content, string FontName, int fontSize)
        {
            this.content = content;
            this.fontName = FontName;
            this.fontSize = fontSize;
        }

        public string getContent()
        {
            return (this.content + ' ' + this.fontName + ' ' + this.fontSize);
        }

    }
}
