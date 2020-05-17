using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class LabelCommand : AbstractUndoableCommand
    {
        private string previousText;
        private string text;
        VideoEditor videoEditor = new VideoEditor();

        public LabelCommand(string text,History history, VideoEditor videoEditor) : base(history,videoEditor)
        {
            this.previousText = videoEditor.getText();
            this.text = text;
            this.videoEditor = videoEditor;
        }

        public override void doExecute()
        {
            videoEditor.setText(text);
        }

        public override void undo()
        {
            videoEditor.setText(previousText);
        }
    }
}
