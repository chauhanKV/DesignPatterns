using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Segments;

namespace VisitorPattern.Filters
{
    class ReverbOperation : Operation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("FactSegment : Applying Reverb filter");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("FormatSegment : Applying Reverbn filter");
        }
    }
}
