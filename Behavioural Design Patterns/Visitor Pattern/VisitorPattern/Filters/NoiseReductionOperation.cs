using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Segments;

namespace VisitorPattern.Filters
{
    class NoiseReductionOperation : Operation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("FactSegment : Applying Noise Reduction filter");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("FormatSegment : Applying Noise Reduction filter");
        }
    }
}
