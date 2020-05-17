using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern
{
    class History
    {
       
        Stack<UndoableCommand> commands = new Stack<UndoableCommand>();

        public void push(UndoableCommand command)
        {
            commands.Push(command);
        }

        public UndoableCommand pop()
        {
            return commands.Pop();
        }

        public int size()
        {
            return commands.Count();
        }
    }
}
