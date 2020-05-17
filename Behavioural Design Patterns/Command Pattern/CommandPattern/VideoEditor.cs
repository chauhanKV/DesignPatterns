using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VideoEditor
    {
        private float contrast;
        private String text;

        public void setText(String text)
        {
            this.text = text;
        }

        public void removeText()
        {
            this.text = "";
        }

        public string getText()
        {
            return text;
        }

        public float getContrast()
        {
            return contrast;
        }

        public void setContrast(float contrast)
        {
            this.contrast = contrast;
        }
        public override string ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + contrast +
                    ", text='" + text + '\'' +
                    '}';
        }

    }
}
