using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.Context
{
    class Map
    {

        private TravelMode mode;

        public void getETA()
        {
            mode.getETA();
        }

        public void getDirection()
        {
            mode.getDirection();
        }

        public TravelMode Mode { get => mode; set => mode = value; }
    }
}
