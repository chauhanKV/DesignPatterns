using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    abstract class AbstractUndoableCommand : UndoableCommand
    {

        private History history;
        private VideoEditor videoEditor;

        public AbstractUndoableCommand(History history, VideoEditor videoEditor)
        {
            this.history = history;
            this.videoEditor = videoEditor;
        }

        public void execute()
        {
            doExecute();
            history.push(this);
        }

        public abstract void doExecute();
        public abstract void undo();
    }
}
