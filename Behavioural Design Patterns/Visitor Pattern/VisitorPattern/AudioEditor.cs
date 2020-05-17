using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Segments;

namespace VisitorPattern
{
    class WaveFile
    {
        List<Segment> segments = new List<Segment>();

        public static WaveFile read(string fileName)
        {
            WaveFile waveFile = new WaveFile();
            waveFile.segments.Add(new FactSegment());
            waveFile.segments.Add(new FormatSegment());
            return waveFile;
        }

        public void ApplyFilter(Operation operation)
        {
            foreach (Segment segment in segments)
                segment.ApplyFilter(operation);
        }
    }
}
