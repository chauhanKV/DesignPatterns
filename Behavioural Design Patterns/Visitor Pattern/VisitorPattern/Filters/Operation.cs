using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Segments;

namespace VisitorPattern
{
    public interface Operation
    {
        void apply(FactSegment factSegment);
        void apply(FormatSegment formatSegment);
    }
}
