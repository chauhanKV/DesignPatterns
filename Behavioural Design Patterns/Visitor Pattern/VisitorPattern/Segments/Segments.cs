using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Segments
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(Operation operation);
    }
}
