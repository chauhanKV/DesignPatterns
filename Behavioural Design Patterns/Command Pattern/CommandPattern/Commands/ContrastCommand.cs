using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class ContrastCommand : AbstractUndoableCommand
    {

        private float previousContrast;
        private float contrast;
        VideoEditor videoEditor = new VideoEditor();


        public ContrastCommand(float contrast, History history, VideoEditor videoEditor) : base(history, videoEditor)
        {
            this.previousContrast = videoEditor.getContrast();
            this.contrast = contrast;
            this.videoEditor = videoEditor;
        }
      

        public override void doExecute()
        {
            videoEditor.setContrast(contrast);
        }

        public override void undo()
        {
            videoEditor.setContrast(previousContrast);
        }

    }
}
