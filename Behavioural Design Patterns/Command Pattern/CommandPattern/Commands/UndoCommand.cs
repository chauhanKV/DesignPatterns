using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class UndoCommand : Command
    {
        private History history;
        public UndoCommand(History history)
        {
            this.history = history;
        }
        public void execute()
        {
            if (history.size() > 0)
            {
                history.pop().undo();
            }
        }
    }
}
