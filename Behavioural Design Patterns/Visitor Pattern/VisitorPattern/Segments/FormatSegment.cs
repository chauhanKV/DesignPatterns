using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Segments
{
    public class FormatSegment : Segment
    {
        public override void ApplyFilter(Operation operation)
        {
            operation.apply(this);
        }
    }
}
