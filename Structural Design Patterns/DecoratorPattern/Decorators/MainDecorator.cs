using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    class MainDecorator : AbstractArtefact
    {
        private AbstractArtefact artefact;
        public MainDecorator(AbstractArtefact artefact)
        {
            this.artefact = artefact;
        }
        public string render()
        {
            return artefact.render() + "[Main]";
        }
    }
}
