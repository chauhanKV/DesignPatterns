using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public interface TravelMode
    {
        void getETA();
        void getDirection();
    }
}
