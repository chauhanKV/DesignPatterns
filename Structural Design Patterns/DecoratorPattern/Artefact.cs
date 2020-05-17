using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Artefact : AbstractArtefact
    {
        private string fileName;

        public Artefact(string fileName)
        {
            this.fileName = fileName;
        }
        public string render()
        {
            return fileName;
        }
    }
}
