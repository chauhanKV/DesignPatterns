using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEditor = new VideoEditor();
            var history = new History();
            

            var setTextCommand = new LabelCommand("label", history, videoEditor);
            setTextCommand.execute();
            Console.WriteLine("Text: " + videoEditor);

            setTextCommand = new LabelCommand("New Label", history, videoEditor);
            setTextCommand.execute();
            Console.WriteLine("Text: " + videoEditor);


            var setContrastCommand = new ContrastCommand(100.65f, history, videoEditor);
            setContrastCommand.execute();
            Console.WriteLine("Contrast: " + videoEditor);

            setContrastCommand = new ContrastCommand(1.05f, history, videoEditor);
            setContrastCommand.execute();
            Console.WriteLine("Contrast: " + videoEditor);


            var undoCommand = new UndoCommand(history);
            undoCommand.execute();
            Console.WriteLine("Undo: " + videoEditor);

            undoCommand.execute();
            Console.WriteLine("Undo: " + videoEditor);

            undoCommand.execute();
            Console.WriteLine("Undo: " + videoEditor);

            Console.ReadLine();
        }
    }
}
