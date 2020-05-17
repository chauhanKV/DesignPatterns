using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Editor
    {
        public void openProject(string path)
        {
            AbstractArtefact[] artefacts = {
            new Artefact("Main"),
            new Artefact("Demo"),
            new Artefact("EmailClient"),
            new Artefact("EmailProvider"),
            };


            artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            artefacts[1] = new MainDecorator(artefacts[1]);
            artefacts[3] = new MainDecorator(new ErrorDecorator(artefacts[3]));

            foreach (AbstractArtefact artefact in artefacts)
                Console.WriteLine(artefact.render());
        }
    }
}
