using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.setContent("a", "1", 1);
            history.push(editor.createState());

            editor.setContent("b", "2", 2);
            history.push(editor.createState());


            editor.setContent("c", "3", 3);
            editor.restore(history.pop());
            editor.restore(history.pop());

            Console.WriteLine(editor.getContent());
            Console.ReadLine();
        }
    }
}
