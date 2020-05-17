using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Segments;

namespace VisitorPattern.Filters
{
    class NormalizeOperation : Operation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("FactSegment : Applying normalize filter");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("FormatSegment : Applying normalize filter");
        }
    }
}
