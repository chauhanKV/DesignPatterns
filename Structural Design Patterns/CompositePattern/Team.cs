using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Team : Resource
    {
        List<Resource> resources = new List<Resource>();

        public void addTeam(Resource resource)
        {
            resources.Add(resource);
        }

        public void deploy()
        {
            foreach (Resource resource in resources)
                resource.deploy();
        }
    }
}
