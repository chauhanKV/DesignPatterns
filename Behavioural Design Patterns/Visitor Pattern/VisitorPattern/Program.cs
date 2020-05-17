using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Filters;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var waveFile = WaveFile.read("someFile.wave");
            waveFile.ApplyFilter(new NoiseReductionOperation());
            waveFile.ApplyFilter(new ReverbOperation());
            waveFile.ApplyFilter(new NormalizeOperation());

            Console.ReadLine();
        }
    }
}
