using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    class ErrorDecorator : AbstractArtefact
    {
        private AbstractArtefact artefact;
        public ErrorDecorator(AbstractArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string render()
        {
            var mainIcon = artefact.render();
            return mainIcon + "[Error]";
        }
    }
}
